using Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T11_12
{
    public partial class Sign_In : Form
    {
        public Sign_In()
        {
            InitializeComponent();
        }

        private void bttnSign_Click(object sender, EventArgs e)
        {
            AdminInterface inter = new AdminInterface();
            if (txtUserName.Text == "Group3" && txtPass.Text == "abbas")
            {
                inter.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("User Name Or Password Is Incorrect");
            }

        }

        private void bttnUser_Click(object sender, EventArgs e)
        {
            ClientController client = new ClientController();
            client.Show();
        }
    }
}
