using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không ?",
                   "Confirm",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBase db= new DataBase();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            db.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM TaiKhoan WHERE UserName = @User AND Pass = @Pass",
                    db.GetConnection);

            command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUser.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPass.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            db.CloseConnection();

            if (table.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Đăng Nhập Thành Công!!!");
                MainForm mainForm=new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
