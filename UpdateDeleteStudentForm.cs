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
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        Student student=new Student();

        private void btnFind_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtId.Text);
            SqlCommand cmd = new SqlCommand("SELECT id,fname,lname,bdate,gender,phone,address,picture FROM std WHERE id = "+id);
            DataTable dt = student.GetStudents(cmd);
            if (dt.Rows.Count > 0)
            {
                txtFname.Text = dt.Rows[0]["fname"].ToString();
                txtLname.Text= dt.Rows[0]["lname"].ToString();
                dtpBd.Value = (DateTime)dt.Rows[0]["bdate"];
                if (dt.Rows[0]["gender"].ToString() == "Female")
                {
                    radFemale.Checked = true;
                }
                else
                {
                    radMale.Checked = true;
                }
                txtPhone.Text= dt.Rows[0]["phone"].ToString();
                txtAddress.Text = dt.Rows[0]["address"].ToString();
                byte[] pic = (byte[])dt.Rows[0]["picture"];
                MemoryStream ba = new MemoryStream(pic);
                picImage.Image=Image.FromStream(ba);
            }
            else
            {
                MessageBox.Show("not found", "Find student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
