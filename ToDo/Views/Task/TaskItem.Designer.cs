namespace ToDo
{
    partial class TaskItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cbIsDone = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Location = new System.Drawing.Point(21, 50);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(264, 150);
            this.pnlDescription.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(0, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(264, 150);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "DESCRIPTION";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSubject.Location = new System.Drawing.Point(21, 13);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(103, 23);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "SUBJECT";
            this.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbIsDone
            // 
            this.cbIsDone.AutoSize = true;
            this.cbIsDone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbIsDone.Location = new System.Drawing.Point(177, 17);
            this.cbIsDone.Name = "cbIsDone";
            this.cbIsDone.Size = new System.Drawing.Size(129, 19);
            this.cbIsDone.TabIndex = 3;
            this.cbIsDone.Text = "TAMAMLANDI MI?";
            this.cbIsDone.UseVisualStyleBackColor = true;
            this.cbIsDone.CheckedChanged += new System.EventHandler(this.cbIsDone_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(231, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "SIL";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndDate.Location = new System.Drawing.Point(21, 218);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(115, 21);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "DUE TO";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(96, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "GUNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // TaskItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbIsDone);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.pnlDescription);
            this.Name = "TaskItem";
            this.Size = new System.Drawing.Size(317, 254);
            this.pnlDescription.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlDescription;
        private Label lblDescription;
        private Label lblSubject;
        private CheckBox cbIsDone;
        private Button btnDelete;
        private Label lblEndDate;
        private Button btnUpdate;
    }
}
