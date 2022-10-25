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
using ToDo.Controllers;
using ToDo.Models;
using Task = ToDo.Models.Task;

namespace ToDo
{
    public partial class TaList : Form
    {
        public TaList(User user)
        {
            InitializeComponent();       
            List<Task> AllTasks = TaskController.GetAllByUser(user);
            foreach (Task task in AllTasks)
            {
                TaskItem taskItem = new TaskItem(task);
                pnlTasks.Controls.Add(taskItem);
            }
        }
    }
}
