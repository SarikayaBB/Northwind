namespace ToDo
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstUserName = new System.Windows.Forms.TextBox();
            this.lstPassword = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.grpNew = new System.Windows.Forms.GroupBox();
            this.btnSingUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewAccount = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpUpdate.SuspendLayout();
            this.grpNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUserName
            // 
            this.lstUserName.Location = new System.Drawing.Point(15, 60);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(170, 23);
            this.lstUserName.TabIndex = 1;
            this.lstUserName.TextChanged += new System.EventHandler(this.lstUserName_TextChanged);
            // 
            // lstPassword
            // 
            this.lstPassword.Location = new System.Drawing.Point(15, 145);
            this.lstPassword.Name = "lstPassword";
            this.lstPassword.Size = new System.Drawing.Size(170, 23);
            this.lstPassword.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(54, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(73, 15);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Kullanici Adi";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(76, 103);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(30, 15);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Sifre";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 181);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 83);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "GUNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 15;
            this.lstBox.Location = new System.Drawing.Point(12, 48);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(151, 184);
            this.lstBox.TabIndex = 7;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lstBox.DoubleClick += new System.EventHandler(this.lstBox_DoubleClick);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.Location = new System.Drawing.Point(12, 242);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(151, 27);
            this.btnNewAccount.TabIndex = 8;
            this.btnNewAccount.Text = "YENI KAYIT";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.lblUser);
            this.grpUpdate.Controls.Add(this.lstUserName);
            this.grpUpdate.Controls.Add(this.lstPassword);
            this.grpUpdate.Controls.Add(this.btnUpdate);
            this.grpUpdate.Controls.Add(this.lblPassword);
            this.grpUpdate.Location = new System.Drawing.Point(169, 12);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(214, 285);
            this.grpUpdate.TabIndex = 9;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "KULLANICI GUNCELLE";
            // 
            // grpNew
            // 
            this.grpNew.Controls.Add(this.btnSingUp);
            this.grpNew.Controls.Add(this.label2);
            this.grpNew.Controls.Add(this.label1);
            this.grpNew.Controls.Add(this.txtNewPassword);
            this.grpNew.Controls.Add(this.txtNewAccount);
            this.grpNew.Location = new System.Drawing.Point(414, 20);
            this.grpNew.Name = "grpNew";
            this.grpNew.Size = new System.Drawing.Size(200, 277);
            this.grpNew.TabIndex = 11;
            this.grpNew.TabStop = false;
            this.grpNew.Text = "YENI KAYIT";
            this.grpNew.Visible = false;
            this.grpNew.Enter += new System.EventHandler(this.grpNew_Enter);
            // 
            // btnSingUp
            // 
            this.btnSingUp.Location = new System.Drawing.Point(13, 194);
            this.btnSingUp.Name = "btnSingUp";
            this.btnSingUp.Size = new System.Drawing.Size(175, 56);
            this.btnSingUp.TabIndex = 6;
            this.btnSingUp.Text = "KAYIT OL";
            this.btnSingUp.UseVisualStyleBackColor = true;
            this.btnSingUp.Click += new System.EventHandler(this.btnSingUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanici Adi";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(13, 145);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(175, 23);
            this.txtNewPassword.TabIndex = 1;
            // 
            // txtNewAccount
            // 
            this.txtNewAccount.Location = new System.Drawing.Point(13, 60);
            this.txtNewAccount.Name = "txtNewAccount";
            this.txtNewAccount.Size = new System.Drawing.Size(175, 23);
            this.txtNewAccount.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 22);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "SIL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(151, 23);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(628, 324);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grpNew);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.btnNewAccount);
            this.Controls.Add(this.lstBox);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.grpNew.ResumeLayout(false);
            this.grpNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private TextBox lstUserName;
        private TextBox lstPassword;
        private Label lblUser;
        private Label lblPassword;
        private Button btnUpdate;
        private ListBox lstBox;
        private Button btnNewAccount;
        private GroupBox grpUpdate;
        private GroupBox grpNew;
        private Button btnSingUp;
        private Label label2;
        private Label label1;
        private TextBox txtNewPassword;
        private TextBox txtNewAccount;
        private Button btnDelete;
        private TextBox txtSearch;
    }
}