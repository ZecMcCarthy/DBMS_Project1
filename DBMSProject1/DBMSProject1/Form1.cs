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
            query = "Drop table if exists Accounts;\ncreate table Accounts(Username varchar(20) not null,UserPassword varchar(20) not null,primary key(Username)); ";//mysql code to initialize a table
            command = new MySqlCommand(query, sql);
            command.ExecuteNonQuery();//execute the sql query
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreatAccount_button_Click(object sender, EventArgs e)
        {

        }

        private void Signin_button_Click(object sender, EventArgs e)
        {

        }
    }
}
