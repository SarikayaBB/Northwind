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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            List<User> list = UserController.GetAll();

            foreach (User user in list)
            {
                Button btn = new Button();
                btn.Text = user.UserName;
                 
                pnlUser.Controls.Add(btn);
            }
             
        }

        private void pnlUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
