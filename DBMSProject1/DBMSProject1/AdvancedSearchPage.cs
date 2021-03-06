﻿using System;
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

        private void TagSearch_Click(object sender, EventArgs e) // Query #2
        {
            List<string> users = new List<string>();//this will store the usernames
            query = "SELECT distinct a.postuser FROM blogs a JOIN blogtags c ON a.blogid = c.blogid  AND c.tag = @2X AND exists (SELECT * FROM blogs, blogtags WHERE (blogs.blogid = blogtags.blogid and blogtags.tag = @2Y and blogs.postuser = a.postuser and blogs.blogid != a.blogid) );";
            command = new MySqlCommand(query, sql);

            command.Parameters.Add("@2X", MySqlDbType.VarChar, 20).Value = Tag1.Text; //insert tags, prevent sql injection
            command.Parameters.Add("@2Y", MySqlDbType.VarChar, 20).Value = Tag2.Text;

            String txt = ""; //used to add names of users that fit criteria
            int count = 0;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();//execute the sql query

                while (reader.Read()) //loop through resulting table
                {
                    txt = reader[0].ToString(); 
                    users.Add(txt); //grab all users that have posted blogs with these tags and add to list of users
                    count++; 
                }

                reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            if(count == 0) //in the case that no users fit the query, notify user
            {
                ErrorBox.Text = "No results found for this query.";
            }
            else
            {
                UserList newPage; //create page to display resulting blogs

                string title = $"Users that have posted a blogs with the tag {Tag1.Text} and {Tag2.Text}"; //generate title for new page
                newPage = new UserList(title, users);
                newPage.ShowDialog(); //open new window with results of query
            }
        }

        private void NoComments_Click(object sender, EventArgs e)
        {
            query = "drop view if exists allusers; drop view if exists comusers; create view allusers as select distinct username as author from users; create view comusers as select distinct author from comments; select author from allusers left join comusers using(author) where comusers.author is null;";
            string title = "Users who haven't posted any comments";
            MySqlDataReader reader;
            command = new MySqlCommand(query, sql);
            List<String> users = new List<String>();//list that will store all of our data from the query
            try
            {
                reader = command.ExecuteReader();//read in our data
                while (reader.Read())
                {
                    users.Add(reader[0].ToString());
                }
                reader.Close();//close the reader now that we are done with it
                UserList newPage;//will open our next GUI

                newPage = new UserList(title, users);
                newPage.ShowDialog();
            }
            catch (MySqlException ex)
            {
                ErrorBox.Text = $"Error: {ex.ToString()}";
            }
        }

        private void NegativeComments_Click(object sender, EventArgs e)
        {
            query = "drop view if exists poscom; drop view if exists negcom; create view poscom as select distinct author from (select * from comments where(sentiment = \"Positive\"))alias; create view negcom as select distinct author from (select * from comments where(sentiment = \"Negative\"))alias; select author from negcom left join poscom using(author) where poscom.author is null;";//this is the sql quey needed for this search
            string title = "Users who only post negative comments";
            MySqlDataReader reader;
            command = new MySqlCommand(query, sql);
            List<String> users = new List<String>();//list that will store all of our data from the query
            try
            {
                reader = command.ExecuteReader();//read in our data
                while(reader.Read())
                {
                    users.Add(reader[0].ToString());
                }
                reader.Close();//close the reader now that we are done with it
                UserList newPage;//will open our next GUI

                newPage = new UserList(title, users);
                newPage.ShowDialog();
            }
            catch (MySqlException ex)
            {
                ErrorBox.Text = $"Error: {ex.ToString()}";
            }
        }

        private void SearchDate_Click(object sender, EventArgs e)
        {
            if(DayBox.SelectedIndex == -1 || YearBox.SelectedIndex == -1 || MonthBox.SelectedIndex == -1)
            {
                ErrorBox.Text = "Error: You must input a date to search";
            }
            else//User inputted a date so find out who posted the most blogs
            {
                string date = $"{YearBox.Text}-{MonthBox.Text}-{DayBox.Text}";
                query = "select postuser, Count(*) as posts from (select * from blogs where(pdate = @date))alias group by postuser order by posts desc;";
                MySqlDataReader reader;
                command = new MySqlCommand(query, sql);
                command.Parameters.Add("@date", MySqlDbType.Date).Value = date;//search by the given date
                try
                {
                    reader = command.ExecuteReader(); //read in the data
                    int max = -1;
                    List<String> users = new List<String>();
                    while(reader.Read())
                    {
                        if(max == -1)//set the max of the function
                        {
                            max = int.Parse(reader[1].ToString());
                            users.Add(reader[0].ToString());
                        }
                        else if(int.Parse(reader[1].ToString()) == max)//tie for max
                        {
                            users.Add(reader[0].ToString());
                        }
                        else//no more ties so break the loop
                        {
                            break;
                        }
                    }
                    reader.Close();

                    if(users.Count > 0)//have data for list
                    {
                        String title = $"User(s) who posted the most on {date}";
                        UserList newPage;
                        newPage = new UserList(title, users);
                        newPage.ShowDialog();
                    }
                    else
                    {
                        ErrorBox.Text = $"Sorry no blogs were found!";
                    }
                }
                catch(MySqlException ex)
                {
                    ErrorBox.Text = $"Error: {ex}";
                }
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
