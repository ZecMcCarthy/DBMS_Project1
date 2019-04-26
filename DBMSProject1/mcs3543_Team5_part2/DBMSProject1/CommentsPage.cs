using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DBMSProject1
{
    public partial class CommentsPage : Form
    {
        private string user, query;
        private MySqlConnection sql;
        private MySqlCommand command;//needed to execute queries
        public string bID;

        private void DropDown_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Post_button_Click(object sender, EventArgs e)
        {
            string comment = richTextBox1.Text;
            string sentiment = DropDown_comboBox1.SelectedItem.ToString();
            string date = DateTime.Now.ToString("yyyy-MM-dd");//grabs todays date and is needed for database


            string commentsForDay = "0"; //used to hold users comment number for the day
            query = "Select Count(*) From comments Where(author = @user and cdate = @date)"; //checks how many comments user has posted
            command = new MySqlCommand(query, sql);

            command.Parameters.Add("@user", MySqlDbType.VarChar, 20).Value = user; //prevent sql injection
            command.Parameters.Add("@date", MySqlDbType.Date, 20).Value = date; //prevent sql injection

            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();//execute the sql query

                while (reader.Read())
                {
                    commentsForDay = reader[0].ToString(); 
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }


            if ((Convert.ToInt32(commentsForDay)) > 2 ) //ensure user hasnt posted 3 comments today
             {
                label3.Text = "You may only post up to three comments a day."; //tell user too many comments for the day
            }
            else
            {

                query = "Select Count(*) From comments Where(author = @user and blogid = @id)"; //check how many times this user has commented on this blogpost
                command = new MySqlCommand(query, sql);

                command.Parameters.Add("@user", MySqlDbType.VarChar, 20).Value = user; 
                command.Parameters.Add("@id", MySqlDbType.Int32, 20).Value = bID;

                string postNum = "0"; //holds number of posts on this blogpost. start at 0
                try
                {
                    reader = command.ExecuteReader();//execute the sql query

                    while (reader.Read())
                    {
                        postNum = reader[0].ToString(); //if user has commented on this post, postnum will go up
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                }



                if ((Convert.ToInt32(postNum)) != 0) //ensure user hasnt commented on this blog before
                {
                    label3.Text = "You may only post one comment for each blog.";//tell user only one comment per blog
                }
                else
                {
                    query = "Select postuser from blogs where blogid = @id"; //make sure that this isnt the current users blogpost
                    command = new MySqlCommand(query, sql);

                    command.Parameters.Add("@id", MySqlDbType.Int32, 20).Value = bID;

                    string myPost = "0"; //holds the name of the user that posted the blogpost
                    try
                    {
                        reader = command.ExecuteReader();//execute the sql query

                        while (reader.Read())
                        {
                            myPost = reader[0].ToString();//add the name of the user that posted the blogpost
                        }
                        reader.Close();
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine("Error: {0}", ex.ToString());
                    }

                    if (myPost == user) //ensure this isnt the users blog
                    {
                        label3.Text = "You cannot post a comment on your own blog.";//tell user cant comment on own blog
                    }
                    else //can finally let them post the comment
                    {
                        query = "insert into comments(sentiment, cdescription, cdate, blogId, author) values( @sentiment, @descript, @date, @blogid, @author )"; ;// "insert into comments(sentiment, cdescription, cdate, blogId, author) values( @sentiment , @descript, @date , @blogid , @author );"; //create query that makes a table of usernames and passwords that match user-inputted credentials
                        command = new MySqlCommand(query, sql);


                        command.Parameters.Add("@sentiment", MySqlDbType.VarChar, 150).Value = sentiment; //adding parameters through this method prevents SQL injection
                        command.Parameters.Add("@descript", MySqlDbType.VarChar, 250).Value = comment; //adding parameters through this method prevents SQL injection
                        command.Parameters.Add("@date", MySqlDbType.Date).Value = date; //adding parameters through this method prevents SQL injection
                        command.Parameters.Add("@blogid", MySqlDbType.Int32).Value = bID; //adding parameters through this method prevents SQL injection
                        command.Parameters.Add("@author", MySqlDbType.VarChar, 20).Value = user; //adding parameters through this method prevents SQL injection


                        try
                        {
                            command.ExecuteNonQuery();//execute the sql query
                            richTextBox1.Text = "";
                            updateComments();
                        }
                        catch (MySqlException ex)
                        {
                            Console.WriteLine("Error: {0}", ex.ToString());
                        }
                    }
                }
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void updateComments()
        {
           label2.Text = "";

            query = "select author, cdescription, sentiment from comments where blogID = @id;";
            command = new MySqlCommand(query, sql);

            command.Parameters.Add("@id", MySqlDbType.VarChar, 20).Value = bID;

            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();//execute the sql query
                int count = 0;
                while (reader.Read())
                {
                    string author = reader[count + 0].ToString();
                    string descrip = reader[count + 1].ToString();
                    string sentiment = reader[count + 2].ToString();

                    label2.Text += $"({sentiment}) {author}: {descrip}\n";
                }
                label2.Text += "No more comments to display.";
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        public CommentsPage(MySqlConnection connection, string username, string blogID)
        {
            InitializeComponent();

            label3.Text = ""; //used to show error messages
            DropDown_comboBox1.SelectedIndex = 0; //make dropdown box start with a value
            bID = blogID; //set variable to use throughout form
            sql = connection;//get the mysql connection
            user = username;//store the current user

            updateComments(); //update comments on current post

            query = "select bsubject, bdescription from blogs where blogid = @id "; //get the subject and description to show on form
            command = new MySqlCommand(query, sql);

            command.Parameters.Add("@id", MySqlDbType.VarChar, 20).Value = blogID;

            string blogSub = "";
            string blogDesc = "";
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();//execute the sql query

                while (reader.Read())
                {
                    blogSub = reader[0].ToString();
                    blogDesc = reader[1].ToString();
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }

            Subject_textBox1.Text = blogSub;
            Description_TextBox2.Text = blogDesc;

            query = "select tag from blogtags where blogid = @id"; //get the tags to show on form
            command = new MySqlCommand(query, sql);
            command.Parameters.Add("@id", MySqlDbType.VarChar, 20).Value = blogID;
            string temp = "Tags: ";
            try
            {
                reader = command.ExecuteReader();//execute the sql query

                while (reader.Read())
                {
                    int count = 0;
                    temp+= reader[count].ToString();
                    temp += ' ';
                    count++;
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            Tags_textBox2.Text = temp;
        }

        private void Welcome_label_Click(object sender, EventArgs e)
        {

        }

        private void Subject_textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
