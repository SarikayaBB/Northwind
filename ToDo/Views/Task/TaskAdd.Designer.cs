namespace ToDo
{
    partial class TaskAdd
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
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dateDue = new System.Windows.Forms.DateTimePicker();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblDUE = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(16, 22);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(226, 23);
            this.txtSubject.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(16, 87);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(226, 23);
            this.txtDescription.TabIndex = 1;
            // 
            // dateDue
            // 
            this.dateDue.Location = new System.Drawing.Point(16, 139);
            this.dateDue.Name = "dateDue";
            this.dateDue.Size = new System.Drawing.Size(226, 23);
            this.dateDue.TabIndex = 2;
            this.dateDue.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(101, 4);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(52, 15);
            this.lblSub.TabIndex = 3;
            this.lblSub.Text = "SUBJECT";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(88, 69);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(79, 15);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "DESCRIPTION";
            // 
            // lblDUE
            // 
            this.lblDUE.AutoSize = true;
            this.lblDUE.Location = new System.Drawing.Point(107, 121);
            this.lblDUE.Name = "lblDUE";
            this.lblDUE.Size = new System.Drawing.Size(46, 15);
            this.lblDUE.TabIndex = 5;
            this.lblDUE.Text = "DUE TO";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(226, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TaskAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 233);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDUE);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.dateDue);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TaskAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Task Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSubject;
        private TextBox txtDescription;
        private DateTimePicker dateDue;
        private Label lblSub;
        private Label lblDesc;
        private Label lblDUE;
        private Button btnAdd;
    }
}