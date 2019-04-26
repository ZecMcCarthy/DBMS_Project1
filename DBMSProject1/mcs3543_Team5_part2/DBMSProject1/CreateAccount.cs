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
   
    public partial class CreateAccount : Form
    {
        public MySqlConnection sql;
        private string query; //string that we plan to use to write queries for mySQL
        private MySqlCommand command; //variable we will use to run sql commands

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void CreateAccount_button1_Click(object sender, EventArgs e)
        {
            String username = Username_textbox1.Text; //take username and password that have been entered in textboxes
            String password = Password_textbox1.Text;

            if(username != "" && password != "" ) //check if nothing entered - would let empty string be entered as username or password
            {
                query = "insert into users values ( @usrnme, @passwd, @tempFirstName, @tempLastName, @tempEmail);"; //creation of insert query
                command = new MySqlCommand(query, sql);

                command.Parameters.Add("@usrnme", MySqlDbType.VarChar, 20).Value = username; //adding parameters through this method prevents SQL injection
                command.Parameters.Add("@passwd", MySqlDbType.VarChar, 20).Value = password; //adding parameters through this method prevents SQL injection
                command.Parameters.Add("@tempFirstName", MySqlDbType.VarChar, 20).Value = username;
                command.Parameters.Add("@tempLastName", MySqlDbType.VarChar, 20).Value = username;
                command.Parameters.Add("@tempEmail", MySqlDbType.VarChar, 20).Value = username;

                try
                {
                    command.ExecuteNonQuery();//execute the sql query
                    this.Close(); //account was created, so return to main page
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                    label1.Text = "Invalid or duplicate credentials. Please try again.";  //if sql error (cant enter to table), inform user
                }
            }

        }

        private void Password_textbox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
