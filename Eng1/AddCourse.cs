using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Eng1
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnStu_Click(object sender, EventArgs e)
        {
            OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb");
            con2.Open();
            OleDbCommand com3 = new OleDbCommand("Insert Into Courses (CourseName) values (@CourseName)", con2);
            com3.Parameters.AddWithValue("@CourseName", txtElseCourse.Text);
            com3.ExecuteNonQuery();
            con2.Close();
        }
    }
}
