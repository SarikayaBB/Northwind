using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.Controllers;
using ToDo.Models;
using User = ToDo.Models.User;

namespace ToDo
{
    public partial class Dashboard : Form
    {List<User> list = UserController.GetAll();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            lstBox.DataSource = list;
            lstBox.DisplayMember = "UserName";
            lstBox.ValueMember = "Id";

        }


        private void pnlUser_Paint(object sender, PaintEventArgs e)
        {

        }



        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            User user = (User)lstBox.SelectedItem;
            user.UserName = lstUserName.Text;
            user.Password = lstPassword.Text;
            UserController.Update(user);

            lstBox.DataSource = UserController.GetAll();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            User user = (User)lstBox.SelectedItem;
            lstUserName.Text = user.UserName;
            lstPassword.Text = user.Password;
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            grpNew.Visible = true;
            grpUpdate.Visible = false;

        }

        private void lstUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {

            User user = new User();
            user.UserName = txtNewAccount.Text;
            user.Password = txtNewPassword.Text;
            if (user.UserName.Length > 0 && user.Password.Length > 0)
            {
                UserController.Add(user);
                lstBox.DataSource = UserController.GetAll();
                grpNew.Visible = false;
                grpUpdate.Visible = true;
            }


        }

        private void grpNew_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User user = (User)lstBox.SelectedItem;
            /*user.UserName = lstUserName.Text;
            user.Password = lstPassword.Text;*/
            
            UserController.Delete(user);
            lstBox.DataSource = UserController.GetAll();
            

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<User> list2 = list.Where(u=>u.UserName.Contains(txtSearch.Text)).ToList();
            lstBox.DataSource = list2;
        }
    }
}
