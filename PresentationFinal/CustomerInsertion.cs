using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categoryy.FForm
{
    public partial class CustomerInsertion : Form
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get;  set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public CustomerInsertion()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bttnSub_Click(object sender, EventArgs e)
        {
            FirstName= firstbox.Text;
             LastName= lastbox.Text;
             Phone = phonebox.Text;
             Email = mailbox.Text;
             Address= addresbox.Text;
            Close();
        }
    }
}
