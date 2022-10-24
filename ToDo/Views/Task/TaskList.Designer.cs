namespace ToDo
{
    partial class TaskList
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
            this.lblKullanici = new System.Windows.Forms.Label();
            this.txtBoxMetin = new System.Windows.Forms.RichTextBox();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKullanici
            // 
            this.lblKullanici.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKullanici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKullanici.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblKullanici.Location = new System.Drawing.Point(305, 9);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(203, 23);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "label1";
            this.lblKullanici.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxMetin
            // 
            this.txtBoxMetin.Location = new System.Drawing.Point(12, 129);
            this.txtBoxMetin.Name = "txtBoxMetin";
            this.txtBoxMetin.Size = new System.Drawing.Size(267, 120);
            this.txtBoxMetin.TabIndex = 1;
            this.txtBoxMetin.Text = "Metin Giriniz :";
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(136, 41);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.PlaceholderText = "Baslik";
            this.txtCaption.Size = new System.Drawing.Size(143, 23);
            this.txtCaption.TabIndex = 2;
            // 
            // lblCaption
            // 
            this.lblCaption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCaption.Location = new System.Drawing.Point(12, 41);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(99, 23);
            this.lblCaption.TabIndex = 3;
            this.lblCaption.Text = "Baslik Giriniz:";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDueDate
            // 
            this.lblDueDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDueDate.Location = new System.Drawing.Point(12, 82);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(99, 23);
            this.lblDueDate.TabIndex = 4;
            this.lblDueDate.Text = "Due to:";
            this.lblDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(136, 82);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.PlaceholderText = "Tarih";
            this.txtDueDate.Size = new System.Drawing.Size(143, 23);
            this.txtDueDate.TabIndex = 5;
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.txtCaption);
            this.Controls.Add(this.txtBoxMetin);
            this.Controls.Add(this.lblKullanici);
            this.Name = "TaskList";
            this.Text = "TaskList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKullanici;
        private RichTextBox txtBoxMetin;
        private TextBox txtCaption;
        private Label lblCaption;
        private Label lblDueDate;
        private TextBox txtDueDate;
    }
}