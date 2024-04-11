namespace StudentManagement
{
    partial class StudentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentList));
            label1 = new Label();
            dtvStudent = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvStudent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(468, 19);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 0;
            label1.Text = "List of all students";
            // 
            // dtvStudent
            // 
            dtvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvStudent.Location = new Point(44, 104);
            dtvStudent.Name = "dtvStudent";
            dtvStudent.ReadOnly = true;
            dtvStudent.RowHeadersWidth = 51;
            dtvStudent.Size = new Size(1059, 247);
            dtvStudent.TabIndex = 1;
            dtvStudent.CellContentClick += dtvStudent_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(532, 388);
            button1.Name = "button1";
            button1.Size = new Size(94, 49);
            button1.TabIndex = 2;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(33, 5);
            button2.Name = "button2";
            button2.Size = new Size(117, 62);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // StudentList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 504);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtvStudent);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "StudentList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentList";
            ((System.ComponentModel.ISupportInitialize)dtvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtvStudent;
        private Button button1;
        private Button button2;
    }
}