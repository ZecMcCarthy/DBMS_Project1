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
    public partial class CreateBlogPage : Form
    {
        private string user, query;
        private MySqlConnection sql;
        private MySqlCommand command;//needed to execute queries
        private List<String> tags = new List<string>();
        public CreateBlogPage(MySqlConnection connection, string username)
        {
            InitializeComponent();
            sql = connection;
            user = username;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PostBlog_button1_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");//grabs todays date and is needed for database
            query = "Select Count(*) From blogs Where (postuser = @use and pdate = @date);";//come back to later
            command = new MySqlCommand(query, sql);

            command.Parameters.Add("@use", MySqlDbType.VarChar, 20).Value = user; //adding parameters through this method prevents SQL injection
            command.Parameters.Add("@date", MySqlDbType.Date).Value = date; //adding parameters through this method prevents SQL injection
            int j = 0;
            try
            {
                j = Convert.ToInt32(command.ExecuteScalar());
            }
            catch(MySqlException ex)
            {
                errorLabel.Text = "Error: " + ex.ToString();
                j = 14;//don't run loop if this fails
            }
            //errorLabel.Text = j.ToString() + " posts today";//test
            if (j < 2)//if we haven't posted 2 times today then make the post
            {
                if(subjectBox.Text == "" || descriptionBox.Text == "" || tags.Count < 1)//make sure we have enough information to post
                {
                    errorLabel.Text = "Error: you must have a subject, description, and 1 tag to post";
                }
                else
                {
                    String subject = subjectBox.Text; //take username and password from textboxes 
                    String description = descriptionBox.Text;

                    query = "insert into blogs(bsubject, bdescription, postuser, pdate) values(@subj, @descript, @use, @date);"; //create query that makes a table of usernames and passwords that match user-inputted credentials
                    command = new MySqlCommand(query, sql);

                    command.Parameters.Add("@subj", MySqlDbType.VarChar, 150).Value = subject; //adding parameters through this method prevents SQL injection
                    command.Parameters.Add("@descript", MySqlDbType.VarChar, 250).Value = description; //adding parameters through this method prevents SQL injection
                    command.Parameters.Add("@use", MySqlDbType.VarChar, 20).Value = user; //adding parameters through this method prevents SQL injection
                    command.Parameters.Add("@date", MySqlDbType.Date).Value = date; //adding parameters through this method prevents SQL injection

                    try
                    {
                        command.ExecuteNonQuery();//execute the sql query

                        int id;//where we will store our id for our blog post so we can make the tags
                        MySqlDataReader reader;//will be used to read table
                        query = "select * from blogs where (bsubject = @subj and bdescription = @descript and postuser = @use and pdate = @date);";//query to find our blogid
                        command = new MySqlCommand(query, sql);

                        command.Parameters.Add("@subj", MySqlDbType.VarChar, 150).Value = subject; //adding parameters through this method prevents SQL injection
                        command.Parameters.Add("@descript", MySqlDbType.VarChar, 250).Value = description; //adding parameters through this method prevents SQL injection
                        command.Parameters.Add("@use", MySqlDbType.VarChar, 20).Value = user; //adding parameters through this method prevents SQL injection
                        command.Parameters.Add("@date", MySqlDbType.Date).Value = date; //adding parameters through this method prevents SQL injection

                        reader = command.ExecuteReader();
                        reader.Read();
                        id = reader.GetInt32("blogid");//grab the blogid
                        reader.Close();//close it now that we are done with it
                        

                        for(int i = 0; i < tags.Count; i++)//loop to add all the tags to the blogtags database
                        {
                            query = "insert into blogtags values (@bid, @tag)";
                            command = new MySqlCommand(query, sql);

                            command.Parameters.Add("@bid", MySqlDbType.Int32).Value = id;
                            command.Parameters.Add("@tag", MySqlDbType.VarChar, 20).Value = tags[i];

                            command.ExecuteNonQuery();//execute command
                        }
                        this.Close();//created a blog now close the window
                    }
                    catch (MySqlException ex)
                    {
                        errorLabel.Text = "Failed to post blog: " + ex.ToString();  //if sql error (cant enter to table), inform user
                    }
                }
            }
            else
            {
                errorLabel.Text = "You cannot post more than twice a day";
            }
        }

        private void subjectBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomePage newPage; //create new welcome page

            newPage = new WelcomePage(sql, user);
            newPage.ShowDialog(); //open welcome page
        }

        private void AddTag_button_Click(object sender, EventArgs e)
        {
            string temp = "#";//temporary variable for the tag
            temp += tagBox.Text;
            if(temp.Length > 1 && !tags.Contains(temp))//make sure we actually entered in a value in the tag box
            {
                TagsLabel.Text += temp + " ";//add to the label to display our tags
                tags.Add(temp);//add tag to overall list
            }

            tagBox.Clear();//clear out tag box for next tag
        }

        private void RemoveTag_Click(object sender, EventArgs e)//clear all tags on blog
        {
            TagsLabel.Text = "";//set the label so it displays no tags
            tags.Clear();//clear our array of all tags
        }
    }
}
