using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ToDoEF
{

    public partial class TaskAdd : Form
    {
        Models.Task _task;
        Models.User _user;

        public TaskAdd(Models.User user)
        {
            _user = user;
            InitializeComponent();



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Models.Task task = new Models.Task();
            task.UserId = _user.Id;
            task.DateCreated = DateTime.Now;
            task.Subject = txtSubject.Text;
            task.Description = txtDescription.Text;
            task.EndDate = dateDue.Value;
            task.DateModified= DateTime.Now;
            _task = task;
            Result res = TaskController.Add(_task);
            if (res.Status == ResultStatus.Success)
            {
                MesajKutusu.Goster("BASARILI!", "TASK EKLENDI!");
                this.Close();
            }
        }
    }
}
