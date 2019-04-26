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
    public partial class GUI : Form
    {
        private MySqlConnection sql;
        private string query;//string that we plan to use to write queries for mySQL
        private MySqlCommand command;//variable we will use to run sql commands

        public GUI(MySqlConnection connection)
        {
            InitializeComponent();
            sql = connection;//save the connection in the class
        }

        private void Inititalize_button_Click(object sender, EventArgs e)
        {
            query = "delete from comments; delete from blogtags; delete from follow; delete from hobbies;";//delete values in tables with dependencies
            command = new MySqlCommand(query, sql);
            try
            {
                command.ExecuteNonQuery();//execute the sql query
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());//display the error
            }

            query = "delete from blogs;";//delete values in tables with dependencies
            command = new MySqlCommand(query, sql);
            try
            {
                command.ExecuteNonQuery();//execute the sql query
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());//display the error
            }

            query = "delete from users;";//delete values in tables with dependencies
            command = new MySqlCommand(query, sql);
            try
            {
                command.ExecuteNonQuery();//execute the sql query
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());//display the error
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreatAccount_button_Click(object sender, EventArgs e)
        {
            CreateAccount newPage; //open create account window

            newPage = new CreateAccount();
            newPage.sql = sql; //send sql connection to new window
            newPage.ShowDialog();
        }

        private void Signin_button_Click(object sender, EventArgs e)
        {

            String username = Username_textbox.Text; //take username and password from textboxes 
            String password = Password_textbox.Text;

            query = "select * from users where username = @usrnme and password = @passwd"; //create query that makes a table of usernames and passwords that match user-inputted credentials
            command = new MySqlCommand(query, sql);

            command.Parameters.Add("@usrnme", MySqlDbType.VarChar, 20).Value = username; //adding parameters through this method prevents SQL injection
            command.Parameters.Add("@passwd", MySqlDbType.VarChar, 20).Value = password; //adding parameters through this method prevents SQL injection

            MySqlDataReader reader;
            try
            {
                int count = 0;
                reader =  command.ExecuteReader();//execute the sql query

                while (reader.Read()) //check for cases of username and password in table
                    count++;

                reader.Close();

                if(count > 0) //user login has been foudn
                {
                    label1.Text = ""; //in case error text was displayed, remove from form

                    WelcomePage newPage; //create new welcome page

                    newPage = new WelcomePage(sql, username);//pass the user to other GUI components
                    newPage.ShowDialog(); //open welcome page

                    this.Close(); //form will close when child is manually closed
                }
                else
                {
                    label1.Text = "Invalid username or password. Please try again."; //if not found but no sql error, tell user
                }
                                  
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
                label1.Text = "Invalid username or password. Please try again."; //inform user if there is a sql error
            }
            
        }

        private void Username_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
