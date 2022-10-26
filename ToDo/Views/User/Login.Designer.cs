namespace ToDo
{
    partial class Login
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.grpSignIn = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grpSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPassword.Location = new System.Drawing.Point(81, 101);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Enter Password";
            this.txtPassword.Size = new System.Drawing.Size(152, 23);
            this.txtPassword.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUserName.Location = new System.Drawing.Point(81, 49);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "Enter Username:";
            this.txtUserName.Size = new System.Drawing.Size(152, 23);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // grpSignIn
            // 
            this.grpSignIn.BackColor = System.Drawing.Color.Indigo;
            this.grpSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpSignIn.Controls.Add(this.btnSignUp);
            this.grpSignIn.Controls.Add(this.btnSignIn);
            this.grpSignIn.Controls.Add(this.label2);
            this.grpSignIn.Controls.Add(this.label1);
            this.grpSignIn.Controls.Add(this.txtUserName);
            this.grpSignIn.Controls.Add(this.txtPassword);
            this.grpSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpSignIn.Location = new System.Drawing.Point(246, 37);
            this.grpSignIn.Name = "grpSignIn";
            this.grpSignIn.Size = new System.Drawing.Size(287, 214);
            this.grpSignIn.TabIndex = 2;
            this.grpSignIn.TabStop = false;
            this.grpSignIn.Text = "groupBox1";
            this.grpSignIn.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSignUp.Location = new System.Drawing.Point(188, 185);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(93, 23);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Visible = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSignIn.Location = new System.Drawing.Point(105, 145);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(93, 23);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(576, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 87);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GOOGLE ADS";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(576, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 87);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GOOGLE ADS";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(27, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GOOGLE ADS";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(27, 164);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 87);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GOOGLE ADS";
            // 
            // Login
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpSignIn);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.grpSignIn.ResumeLayout(false);
            this.grpSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUserName;
        private GroupBox grpSignIn;
        private Label label2;
        private Label label1;
        private Button btnSignUp;
        private Button btnSignIn;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
    }
}