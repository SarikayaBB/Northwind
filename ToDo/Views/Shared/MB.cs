using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class MB : Form
    {
        public MB(string caption,string message)
        {
            InitializeComponent();
            lblCaption.Text = caption;
            lblMessage.Text = message;


        }

        private void txtBoxMb_TextChanged(object sender, EventArgs e)
        {

        }

        private void MB_Load(object sender, EventArgs e)
        {

        }

        private void btnRetry_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
