using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.Controllers;
using ToDo.Models;

namespace ToDo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Password = txtPassword.Text;
            user.UserName = txtUserName.Text;

            if (UserController.Login(user))
            {
                MessageBox.Show("BASARILI");
            }
            else
            {
                MessageBox.Show("BASARISIZ");
            }
        }
    }
}
