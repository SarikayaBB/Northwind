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
    public partial class TaskItem : UserControl
    {
        public Models.Task _task;
        public TaskItem(Models.Task task)
        {
            _task = task;
            InitializeComponent();
            //if (task.Description.Length > 160)
            //{
            //    lblDescription.Text = task.Description.Substring(0, 160);
            //}
            //else
            //{}
            lblDescription.Text = task.Description;
            lblSubject.Text = task.Subject;
            lblEndDate.Text =  task.endDate.ToString();
        }
        private void lblDescription_Click(object sender, EventArgs e)
        {
        }
        private void cbIsDone_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsDone.Checked)
            {
                DialogResult dr = MesajKutusu.Goster("TAMAMLANDI MI?", "EMIN MISINIZ?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {

                    Result res = TaskController.Complete(_task);
                    if (res.Status == ResultStatus.Success)
                    {
                        this.Visible = false;
                    }
                }
                else
                {
                    cbIsDone.Checked = false;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MesajKutusu.Goster("SILINSIN MI?", "EMIN MISINIZ?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                Result res = TaskController.Delete(_task);
                if (res.Status == ResultStatus.Success)
                {
                    this.Visible = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MesajKutusu.Goster("GUNCELLEME", "EMIN MISINIZ?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                /*Result res = TaskController.Update(_task);
                if (res.Status == ResultStatus.Success)
                {
                    this.ParentForm.Refresh();
                }*/
                TaskUpdate taskUpdate = new TaskUpdate(_task);
                taskUpdate.Show();
                
            }
        }
    }

}
