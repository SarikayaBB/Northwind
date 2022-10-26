namespace ToDoEF
{
    partial class TaList
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
            this.pnlTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd11 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlTasks
            // 
            this.pnlTasks.AutoScroll = true;
            this.pnlTasks.Location = new System.Drawing.Point(0, 85);
            this.pnlTasks.Name = "pnlTasks";
            this.pnlTasks.Size = new System.Drawing.Size(1006, 372);
            this.pnlTasks.TabIndex = 0;
            this.pnlTasks.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTasks_Paint);
            // 
            // btnAdd11
            // 
            this.btnAdd11.BackColor = System.Drawing.Color.Lime;
            this.btnAdd11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd11.Location = new System.Drawing.Point(418, 25);
            this.btnAdd11.Name = "btnAdd11";
            this.btnAdd11.Size = new System.Drawing.Size(175, 36);
            this.btnAdd11.TabIndex = 1;
            this.btnAdd11.Text = "E  K L E";
            this.btnAdd11.UseVisualStyleBackColor = false;
            this.btnAdd11.Click += new System.EventHandler(this.btnAdd11_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(843, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 29);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // TaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd11);
            this.Controls.Add(this.pnlTasks);
            this.Name = "TaList";
            this.Text = "TaList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaList_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel pnlTasks;
        private Button btnAdd;
        private Button btnAdd11;
        private Button btnRefresh;
    }
}