﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            StudentList st = new StudentList();
            st.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.Show();
            this.Hide();

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateStdF = new UpdateDeleteStudentForm();
            updateStdF.Show();
            this.Hide();
        }
    }
}
