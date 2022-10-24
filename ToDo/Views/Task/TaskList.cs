using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.Models;

namespace ToDo
{
    public partial class TaskList : Form
    {
        public TaskList(User user)
        {

            InitializeComponent();
            lblKullanici.Text = user.UserName;
        }
    }
}
