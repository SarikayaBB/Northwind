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
            user = UserController.Login(user);


            if (user.Id != 0)
            {
                if (user.isAdmin) 
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    
                }

                MessageBox.Show("BASARILI " + user.UserName);
            }
            else
            {
                MessageBox.Show("BASARISIZ");
            }
        }
    }
}
