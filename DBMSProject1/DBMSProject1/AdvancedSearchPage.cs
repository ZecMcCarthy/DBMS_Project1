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

        public AdvancedSearchPage(MySqlConnection connection, string username)
        {
            sql = connection;
            user = username;
            InitializeComponent();
        }
    }
}
