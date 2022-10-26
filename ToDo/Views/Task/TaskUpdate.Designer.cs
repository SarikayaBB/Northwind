namespace ToDo
{
    partial class TaskUpdate
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
            this.txtUpSubject = new System.Windows.Forms.TextBox();
            this.txtUpDescription = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dateUpDue = new System.Windows.Forms.DateTimePicker();
            this.lblUpSubject = new System.Windows.Forms.Label();
            this.lblUpDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUpSubject
            // 
            this.txtUpSubject.Location = new System.Drawing.Point(48, 54);
            this.txtUpSubject.Name = "txtUpSubject";
            this.txtUpSubject.Size = new System.Drawing.Size(198, 23);
            this.txtUpSubject.TabIndex = 0;
            // 
            // txtUpDescription
            // 
            this.txtUpDescription.Location = new System.Drawing.Point(48, 105);
            this.txtUpDescription.Name = "txtUpDescription";
            this.txtUpDescription.Size = new System.Drawing.Size(198, 23);
            this.txtUpDescription.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(48, 194);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "GUNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dateUpDue
            // 
            this.dateUpDue.Location = new System.Drawing.Point(48, 155);
            this.dateUpDue.Name = "dateUpDue";
            this.dateUpDue.Size = new System.Drawing.Size(200, 23);
            this.dateUpDue.TabIndex = 3;
            // 
            // lblUpSubject
            // 
            this.lblUpSubject.AutoSize = true;
            this.lblUpSubject.Location = new System.Drawing.Point(126, 25);
            this.lblUpSubject.Name = "lblUpSubject";
            this.lblUpSubject.Size = new System.Drawing.Size(52, 15);
            this.lblUpSubject.TabIndex = 4;
            this.lblUpSubject.Text = "SUBJECT";
            // 
            // lblUpDescription
            // 
            this.lblUpDescription.AutoSize = true;
            this.lblUpDescription.Location = new System.Drawing.Point(109, 87);
            this.lblUpDescription.Name = "lblUpDescription";
            this.lblUpDescription.Size = new System.Drawing.Size(79, 15);
            this.lblUpDescription.TabIndex = 5;
            this.lblUpDescription.Text = "DESCRIPTION";
            // 
            // TaskUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 265);
            this.Controls.Add(this.lblUpDescription);
            this.Controls.Add(this.lblUpSubject);
            this.Controls.Add(this.dateUpDue);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUpDescription);
            this.Controls.Add(this.txtUpSubject);
            this.Name = "TaskUpdate";
            this.Text = "TaskUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUpSubject;
        private TextBox txtUpDescription;
        private Button btnUpdate;
        private DateTimePicker dateUpDue;
        private Label lblUpSubject;
        private Label lblUpDescription;
    }
}