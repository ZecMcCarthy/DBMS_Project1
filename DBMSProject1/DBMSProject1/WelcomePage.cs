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
    public partial class WelcomePage : Form
    {
        private string user;
        private MySqlConnection sql;

        public WelcomePage(MySqlConnection connection, string username)
        {
            InitializeComponent();
            sql = connection;//get the mysql connection
            user = username;//store the current user
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {

        }

        private void CreateBlog_button1_Click(object sender, EventArgs e)
        {
            CreateBlogPage newPage; //create new welcome page

            newPage = new CreateBlogPage(sql, user);
            newPage.ShowDialog(); //open Create new blog page
        }

        private void SearchBlog_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBlog_button_Click(object sender, EventArgs e)
        {
            SearchInterface newPage; //create new welcome page

            newPage = new SearchInterface(sql, user, SearchBlog_textBox.Text);
            newPage.ShowDialog(); //open Create new blog page
        }

        private void AdvancedSearch_button1_Click(object sender, EventArgs e)
        {
            AdvancedSearchPage newPage;

            newPage = new AdvancedSearchPage(sql, user);
            newPage = 
        }
    }
}
