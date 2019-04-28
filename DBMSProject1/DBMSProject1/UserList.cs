using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject1
{
    public partial class UserList : Form
    {
        public UserList(String title, List<String> data)
        {
            InitializeComponent();
            Title.Text = title;

            for(int i = 0; i < data.Count; i++)
            {
                ListBox.Items.Add(data[i]);
            }
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
