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
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


                DataBase con = new DataBase();
                con.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from std ", con.GetConnection);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.SelectCommand = cmd;
                adt.Fill(dt);
                dtvStudent.DataSource = dt;


                con.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void dtvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            UpdateDeleteStudentForm udp = new UpdateDeleteStudentForm();
            udp.txtId.Text = dtvStudent.CurrentRow.Cells[0].Value.ToString();
            udp.txtFname.Text = dtvStudent.CurrentRow.Cells[1].Value.ToString();
            udp.txtLname.Text = dtvStudent.CurrentRow.Cells[2].Value.ToString();
            udp.dtpBd.Value = (DateTime)dtvStudent.CurrentRow.Cells[3].Value;
            udp.radMale.Checked = true;
            if ((dtvStudent.CurrentRow.Cells[4].Value.ToString() == "Female")){
               udp.radFemale.Checked=true;
            }
            udp.txtPhone.Text = dtvStudent.CurrentRow.Cells[5].Value.ToString();
            udp.txtAddress.Text = dtvStudent.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])dtvStudent.CurrentRow.Cells[7].Value;
            MemoryStream picure= new MemoryStream(pic);
            udp.picImage.Image=Image.FromStream(picure);
            udp.Show();
            
        }
    }
}
