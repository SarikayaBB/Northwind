using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoEF.Controllers;
using ToDoEF.Models;

namespace ToDoEF
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

            // ctrl d kopyalama, alt shift . next occurence ctl k d prettier
            if (user!=null)
            {
                if (user.IsAdmin)
                {
                    MessageBox.Show("BASARILI!", "HOSGELDINIZ " + user.UserName);
                    /*Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();*/
                }
                else
                {
                    TaList taskList = new TaList(user);
                    taskList.Show();
                    TaList tl = new TaList(user);
                    this.Hide();
                    tl.ShowDialog();

                }
            }
            else
            {
/*                MesajKutusu.Goster("HATA!", "HATALI GIRIS YAPTINIZ.");
*/            }
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
