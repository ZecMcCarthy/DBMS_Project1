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
        private string user;
        private MySqlConnection sql;
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
    }
}
