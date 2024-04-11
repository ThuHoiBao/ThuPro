namespace StudentManagement
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem9 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.WhiteSmoke;
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6, toolStripMenuItem7, toolStripMenuItem8 });
            toolStripMenuItem1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(108, 29);
            toolStripMenuItem1.Text = "STUDENT";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.BackColor = Color.FromArgb(255, 128, 0);
            toolStripMenuItem3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(294, 30);
            toolStripMenuItem3.Text = "Add New Student";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.BackColor = Color.FromArgb(255, 128, 0);
            toolStripMenuItem4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(294, 30);
            toolStripMenuItem4.Text = "Students List";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.BackColor = Color.FromArgb(255, 128, 0);
            toolStripMenuItem5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(294, 30);
            toolStripMenuItem5.Text = "Statics";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.BackColor = Color.FromArgb(255, 128, 0);
            toolStripMenuItem6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(294, 30);
            toolStripMenuItem6.Text = "Edit/Remove";
            toolStripMenuItem6.Click += toolStripMenuItem6_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.BackColor = Color.FromArgb(255, 128, 0);
            toolStripMenuItem7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(294, 30);
            toolStripMenuItem7.Text = "Manager Student Form";
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.BackColor = Color.FromArgb(255, 128, 0);
            toolStripMenuItem8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(294, 30);
            toolStripMenuItem8.Text = "Print";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(96, 29);
            toolStripMenuItem2.Text = "COURSE";
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(83, 29);
            toolStripMenuItem9.Text = "SCORE";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
    }
}