using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoEF.Controllers;

namespace ToDoEF
{

    public partial class TaList : Form
    {
        public Models.User _user;
        public TaList(Models.User user)
        {
            _user = user;
            InitializeComponent();
            Doldur();

        }
        private void Doldur()
        {
            pnlTasks.Controls.Clear();
            List<Models.Task> AllTasks = TaskController.GetAllByUser(_user);
            foreach (Models.Task task in AllTasks)
            {
                TaskItem taskItem = new TaskItem(task);
                pnlTasks.Controls.Add(taskItem);
            }
        }
        private void pnlTasks_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnAdd11_Click(object sender, EventArgs e)
        {/*
            TaskAdd taskAdd = new TaskAdd(_user);
            taskAdd.ShowDialog();
            Doldur();*/
        }
        private void TaList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Doldur();
        }
    }
}
