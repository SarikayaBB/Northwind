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
using ToDo.Views;


namespace ToDo
{
    public partial class Login : Form
    {
       Dashboard dashboard = new Dashboard();
        
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

            // ctrl d kopyalama, alt shift . next occurence ctl k d prettier
            if (user.Id != 0)
            {
                if (user.isAdmin)
                {
                    MesajKutusu.Goster("BASARILI!", "HOSGELDINIZ " + user.UserName);
                    dashboard.Show();
                    this.Hide();
                } else
                {
                    /*TaskList taskList = new TaskList(user);
                    taskList.Show();*/
                    TaList tl = new TaList(user);
                    this.Hide();
                    tl.ShowDialog();
                    
                }
            }
            else
            {
                MesajKutusu.Goster("HATA!", "HATALI GIRIS YAPTINIZ.");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
