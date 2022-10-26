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

namespace ToDo
{
    public partial class  TaskUpdate : Form
    {
        public Models.Task _task;
        Models.Task _taskUpdated = new Models.Task();
        public TaskUpdate(Models.Task task)
        {

            _task = task;

            InitializeComponent();
            Doldur();

        }
        private void Doldur()
        {
            
            txtUpDescription.Text = _task.Description;
            txtUpSubject.Text = _task.Subject;
            dateUpDue.Value = _task.endDate;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _taskUpdated = _task;
            _taskUpdated.Subject = txtUpSubject.Text;
            _taskUpdated.Description = txtUpDescription.Text;
            _taskUpdated.endDate = dateUpDue.Value;
            Result res = TaskController.Update(_taskUpdated);
            /*Doldur();*/
            if(res.Status == ResultStatus.Success)
            {
                this.Close();
            }
            
        }
    }
}
