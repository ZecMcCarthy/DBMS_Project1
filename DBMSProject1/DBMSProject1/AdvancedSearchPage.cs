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
    public partial class AdvancedSearchPage : Form
    {
        private string user, query;
        private MySqlConnection sql;
        private MySqlCommand command;//needed to execute queries

        private void PositiveComments_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();//this will store the ids of all the positive only comments
            query = "drop view if exists allblogs; drop view if exists negatives; create view allblogs as select distinct blogid from comments; create view negatives as select distinct blogid from comments where (sentiment = \"Negative\"); select blogid from allblogs left join negatives using(blogid) where negatives.blogid is null;";//query that will grab all blogids with only positive comments
            command = new MySqlCommand(query, sql);
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();//read in the data from the database
                while(reader.Read())
                {
                    ids.Add(Int32.Parse(reader[0].ToString()));//store the ids of the blogs with only positive comments
                    
                }
                reader.Close();
                if(ids.Count < 1)//if there is no positive blogs found
                {
                    ErrorBox.Text = "Error 1: No blogs with only positive comments found.";
                }
                else//have positive blogids
                {
                    String temp = ids[0].ToString();//temporary string that we will use to insert the range
                    String title;
                    for(int i = 1; i < ids.Count; i++)
                    {
                        temp += "," + ids[i].ToString();
                    }
                    if(UserBox.TextLength < 1)//no input for user then we display all users
                    {
                        query = "select bsubject from (select * from blogs) alias where (alias.blogid in (" + temp + "));";
                        command = new MySqlCommand(query, sql);
                        title = "Blogs with only positive comments";
                    }
                    else//did specify a user
                    {
                        query = "select bsubject from (select * from blogs) alias where (alias.postuser = @user and alias.blogid in (" + temp + "));";
                        command = new MySqlCommand(query, sql);
                        command.Parameters.Add("@user", MySqlDbType.VarChar, 20).Value = UserBox.Text;
                        title = UserBox.Text + "'s blogs with only positive comments";
                    }
                    try
                    {
                        reader = command.ExecuteReader();
                        List<String> blogs = new List<String>();
                        while(reader.Read())
                        {
                            blogs.Add(reader[0].ToString());
                        }
                        reader.Close();
                        if(blogs.Count < 1)//no results found
                        {
                            ErrorBox.Text = "Error 2: no results found";
                        }
                        else
                        {
                            UserList newPage; //create new welcome page

                            newPage = new UserList(title, blogs);//pass the user to other GUI components
                            newPage.ShowDialog(); //open welcome page
                        }
                    }
                    catch(MySqlException except)
                    {
                        ErrorBox.Text = "Error 3: " + except.ToString();
                    }
                }
                
            }
            catch(MySqlException ex)
            {
                ErrorBox.Text = "Error 4: " + ex.ToString();
            }
        }

        public AdvancedSearchPage(MySqlConnection connection, string username)
        {
            sql = connection;
            user = username;
            InitializeComponent();
        }
    }
}
