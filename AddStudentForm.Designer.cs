namespace StudentManagement
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtLname = new TextBox();
            textBox3 = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            picImage = new PictureBox();
            pictureBox2 = new PictureBox();
            txtFname = new TextBox();
            txtStudentId = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            dtpBirthDate = new DateTimePicker();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            btnUpload = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(108, 214);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(108, 247);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(112, 277);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(113, 310);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 3;
            label4.Text = "Birth Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(138, 343);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 4;
            label5.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(147, 377);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 5;
            label6.Text = "Phone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(133, 409);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 6;
            label7.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(12, 519);
            label8.Name = "label8";
            label8.Size = new Size(203, 25);
            label8.TabIndex = 7;
            label8.Text = "Representative Image:";
            // 
            // txtLname
            // 
            txtLname.Location = new Point(222, 278);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(201, 27);
            txtLname.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(222, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 27);
            textBox3.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(222, 377);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(201, 27);
            txtPhone.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(222, 410);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(201, 65);
            txtAddress.TabIndex = 14;
            // 
            // picImage
            // 
            picImage.BackColor = Color.White;
            picImage.Location = new Point(222, 481);
            picImage.Name = "picImage";
            picImage.Size = new Size(201, 118);
            picImage.TabIndex = 15;
            picImage.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(169, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(170, 144);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(222, 245);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(201, 27);
            txtFname.TabIndex = 9;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(222, 212);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(201, 27);
            txtStudentId.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 0, 192);
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(80, 694);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 39);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(329, 694);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 39);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(222, 311);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(201, 27);
            dtpBirthDate.TabIndex = 19;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radMale.ForeColor = SystemColors.Control;
            radMale.Location = new Point(222, 343);
            radMale.Name = "radMale";
            radMale.Size = new Size(70, 27);
            radMale.TabIndex = 20;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radFemale.ForeColor = SystemColors.Control;
            radFemale.Location = new Point(335, 343);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(88, 27);
            radFemale.TabIndex = 21;
            radFemale.TabStop = true;
            radFemale.Text = "Female";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(222, 605);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(201, 29);
            btnUpload.TabIndex = 22;
            btnUpload.Text = "Upload Image";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 15);
            button1.Name = "button1";
            button1.Size = new Size(110, 55);
            button1.TabIndex = 23;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(486, 781);
            Controls.Add(button1);
            Controls.Add(btnUpload);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(dtpBirthDate);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(pictureBox2);
            Controls.Add(picImage);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtStudentId);
            Controls.Add(txtFname);
            Controls.Add(textBox3);
            Controls.Add(txtLname);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudentForm";
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private TextBox txtLname;
        private TextBox textBox3;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private PictureBox picImage;
        private PictureBox pictureBox2;
        private TextBox txtFname;
        private TextBox txtStudentId;
        private Button btnAdd;
        private Button btnCancel;
        private DateTimePicker dtpBirthDate;
        private RadioButton radMale;
        private RadioButton radFemale;
        private Button btnUpload;
        private Button button1;
    }
}