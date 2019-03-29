using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace DBMSProject1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MySqlConnection connection;

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "127.0.0.1";
            builder.UserID = "root";
            builder.Password = "Ig0tj0y!";
            builder.Port = 3306;
            builder.Database = "studentgrades";
            connection = new MySqlConnection(builder.ToString());

            try
            {
                connection.Open();
                //Console.WriteLine("Success");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }

            //^^Establish the connection^^
            if (connection != null)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new GUI(connection));
            }

        }
    }
}
