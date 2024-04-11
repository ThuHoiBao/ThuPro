using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagement
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            int id = Convert.ToInt32(txtStudentId.Text);
            string fName = txtFname.Text;
            string lName = txtLname.Text;
            DateTime bDate = dtpBirthDate.Value;
            string phone = txtPhone.Text;
            string adress = txtAddress.Text;
            string gender = "Male";

            if (radFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born = dtpBirthDate.Value.Year;
            int thisYear = DateTime.Now.Year;
            if ((thisYear - born) < 10 || (thisYear - born > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Verif())
            {

                picImage.Image.Save(pic, picImage.Image.RawFormat);
                if (st.InsertStudent(id, fName, lName, bDate, gender, phone, adress, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
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
        bool Verif()
        {
            if ((txtFname.Text.Trim() == "")
                        || (txtLname.Text.Trim() == "")
                        || (txtAddress.Text.Trim() == "")
                        || (txtPhone.Text.Trim() == "")
                        || (picImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                picImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainForm mf=new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
