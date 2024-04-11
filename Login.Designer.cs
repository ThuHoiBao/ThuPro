namespace StudentManagement
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
        /// 
        private void Login_Load(object sender, EventArgs e)
        {
            // Thực hiện các thao tác khi form Login được tải
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Thực hiện các thao tác khi label1 được nhấp
        }
        private void label2_Click(object sender, EventArgs e)
        {
            // Thực hiện các thao tác khi label2 được nhấp
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxUser = new TextBox();
            textBoxPass = new TextBox();
            button1 = new Button();
            buttonLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(132, 122);
            label1.Name = "label1";
            label1.Size = new Size(170, 31);
            label1.TabIndex = 0;
            label1.Text = "Account Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(46, 187);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(46, 263);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            label3.Click += label3_Click;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(179, 191);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(200, 27);
            textBoxUser.TabIndex = 3;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(179, 263);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(200, 27);
            textBoxPass.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(46, 348);
            button1.Name = "button1";
            button1.Size = new Size(130, 48);
            button1.TabIndex = 5;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Lime;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonLogin.ForeColor = SystemColors.ButtonHighlight;
            buttonLogin.Location = new Point(257, 348);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(122, 48);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(154, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(467, 521);
            Controls.Add(pictureBox1);
            Controls.Add(buttonLogin);
            Controls.Add(button1);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxUser;
        private TextBox textBoxPass;
        private Button button1;
        private Button buttonLogin;
        private PictureBox pictureBox1;
    }
}