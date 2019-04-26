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
    public partial class SearchInterface : Form
    {
        private string user, query, query2;
        private MySqlConnection sql;
        private MySqlCommand command, command2;//needed to execute queries
        
        public SearchInterface(MySqlConnection connection, string username, string tag)
        {
            InitializeComponent();
            sql = connection;//get the mysql connection
            user = username;//store the current user

            query = "select blogid from blogtags where tag = @tag ";
            command = new MySqlCommand(query, sql);

            command.Parameters.Add("@tag", MySqlDbType.VarChar, 20).Value = tag;

            int count = 0;
            String[] blogIDs = new String[20];

            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();//execute the sql query

                while (reader.Read()) 
                {
                    blogIDs[count] = reader[0].ToString();           
                    count++;
                }

                reader.Close();
               
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            for(int i = 0; i < count; i++)
                CreateDynamicButton(85 * (i+1), blogIDs[i]);
        }

        private void Welcome_label_Click(object sender, EventArgs e)
        {

        }

        private void CreateDynamicButton(int y, string blogID)
        {
           Button dynamicButton = new Button();


            dynamicButton.Height = 40;
            dynamicButton.Width = 200;

            dynamicButton.Location = new Point(180, y);

            query2 = "select bsubject from blogs where blogid = @id ";
            command2 = new MySqlCommand(query2, sql);

            command2.Parameters.Add("@id", MySqlDbType.VarChar, 20).Value = blogID;

            string blogName = "";
            MySqlDataReader reader2;
            try
            {
                
                reader2 = command2.ExecuteReader();//execute the sql query
                
                while (reader2.Read())
                {
                    blogName = reader2[0].ToString();
                }

                reader2.Close();
            }
            catch (MySqlException ex)
            {
                
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            dynamicButton.Text = blogName;

            dynamicButton.Name = blogID;

            dynamicButton.Click += new EventHandler(DynamicButton_Click);
           

            Controls.Add(dynamicButton);

        }


        private void DynamicButton_Click(object sender, EventArgs e)

        {
            Button mb = (sender as Button);
            string blogid = mb.Name;

            CommentsPage newPage; //create new welcome page

            newPage = new CommentsPage(sql, user, blogid);//pass the user to other GUI components
            newPage.ShowDialog(); //open welcome page

        }



        private void SearchResults_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
