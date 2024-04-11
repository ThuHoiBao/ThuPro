namespace StudentManagement
{
    partial class UpdateDeleteStudentForm
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
        private void label1_Click(object sender, EventArgs e)
        {
            // Xử lý khi Label 1 được click
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Xử lý khi Label 2 được click
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Xử lý khi Label 3 được click
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Xử lý khi Label 4 được click
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Xử lý khi Label 5 được click
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Xử lý khi Label 6 được click
        }

        // ... (Thêm các phương thức xử lý sự kiện khác tương tự)

        private void UpdateDeleteStudentForm_Load(object sender, EventArgs e)
        {
            // Xử lý khi Form được load
        }
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtId = new TextBox();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            picImage = new PictureBox();
            btnUpPicter = new Button();
            dtpBd = new DateTimePicker();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            btnEdit = new Button();
            btnRemove = new Button();
            btnFind = new Button();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(158, 34);
            label1.Name = "label1";
            label1.Size = new Size(33, 23);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(89, 93);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(92, 154);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(93, 212);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 3;
            label4.Text = "Birth Date:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(117, 268);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 4;
            label5.Text = "Gender:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(127, 324);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 5;
            label6.Text = "Phone:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(623, 34);
            label7.Name = "label7";
            label7.Size = new Size(79, 23);
            label7.TabIndex = 6;
            label7.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(623, 154);
            label8.Name = "label8";
            label8.Size = new Size(71, 23);
            label8.TabIndex = 7;
            label8.Text = "Picture:";
            // 
            // txtId
            // 
            txtId.Location = new Point(191, 33);
            txtId.Name = "txtId";
            txtId.Size = new Size(176, 27);
            txtId.TabIndex = 8;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(191, 93);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(176, 27);
            txtFname.TabIndex = 9;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(191, 150);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(176, 27);
            txtLname.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(191, 321);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(176, 27);
            txtPhone.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(698, 32);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(155, 86);
            txtAddress.TabIndex = 12;
            // 
            // picImage
            // 
            picImage.Location = new Point(698, 150);
            picImage.Name = "picImage";
            picImage.Size = new Size(155, 120);
            picImage.TabIndex = 13;
            picImage.TabStop = false;
            // 
            // btnUpPicter
            // 
            btnUpPicter.Location = new Point(698, 274);
            btnUpPicter.Name = "btnUpPicter";
            btnUpPicter.Size = new Size(155, 29);
            btnUpPicter.TabIndex = 14;
            btnUpPicter.Text = "Upload Image";
            btnUpPicter.UseVisualStyleBackColor = true;
            // 
            // dtpBd
            // 
            dtpBd.CustomFormat = "dd/MM/yyyy";
            dtpBd.Format = DateTimePickerFormat.Custom;
            dtpBd.Location = new Point(191, 208);
            dtpBd.Name = "dtpBd";
            dtpBd.Size = new Size(176, 27);
            dtpBd.TabIndex = 15;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            radMale.ForeColor = SystemColors.ButtonHighlight;
            radMale.Location = new Point(198, 264);
            radMale.Name = "radMale";
            radMale.Size = new Size(70, 27);
            radMale.TabIndex = 16;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            radFemale.ForeColor = SystemColors.ButtonHighlight;
            radFemale.Location = new Point(279, 266);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(88, 27);
            radFemale.TabIndex = 17;
            radFemale.TabStop = true;
            radFemale.Text = "Female";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DeepSkyBlue;
            btnEdit.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(361, 384);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnRemove.ForeColor = SystemColors.ButtonHighlight;
            btnRemove.Location = new Point(623, 384);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 19;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Lime;
            btnFind.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btnFind.ForeColor = SystemColors.ButtonHighlight;
            btnFind.Location = new Point(399, 31);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 20;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // UpdateDeleteStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1190, 450);
            Controls.Add(btnFind);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(dtpBd);
            Controls.Add(btnUpPicter);
            Controls.Add(picImage);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateDeleteStudentForm";
            Text = "UpdateDeleteStudentForm";
            Load += UpdateDeleteStudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        public TextBox txtId;
        public TextBox txtFname;
        public TextBox txtLname;
        public TextBox txtPhone;
        public TextBox txtAddress;
        public DateTimePicker dtpBd;
        public RadioButton radMale;
        public RadioButton radFemale;
        public Button btnEdit;
        public Button btnRemove;
        public Button btnFind;
        public Button btnUpPicter;
        public PictureBox picImage;
    }
}