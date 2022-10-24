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
        public MB(string caption, string message, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            InitializeComponent();
            lblCaption.Text = caption;
            lblMessage.Text = message;

            if (buttons == MessageBoxButtons.OK)
            {
                pnlOK.Visible = true;
            }
            else if (buttons == MessageBoxButtons.YesNo)
            {
                pnlYesNo.Visible = true;
            }

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

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
