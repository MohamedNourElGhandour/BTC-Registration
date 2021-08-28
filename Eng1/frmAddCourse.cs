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
    public partial class frmAddCourse : Form
    {
        public frmAddCourse()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb");        
        private void frmAddCourse_Load(object sender, EventArgs e)
        {
            int h = 9;
            con.Open();
            OleDbCommand com1 = new OleDbCommand("select max(CourseID) from Courses", con);
            h = (int)com1.ExecuteScalar() + 1;
            txtCourseID.Text = h.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txtCourseName.Text =="")
            {
                MessageBox.Show("Please Insert Course Name"); return;
            }
            try
            {
                OleDbCommand com3 = new OleDbCommand("Insert Into Courses (CourseName) values (@CourseName)", con);
                com3.Parameters.AddWithValue("@CourseName", txtCourseName.Text);
                //com3.ExecuteNonQuery();
                int n = com3.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Insertion Successed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                DialogResult xx = MessageBox.Show("Do you want to add a new Course ?", "Attention", MessageBoxButtons.YesNo);
                if (xx == DialogResult.Yes)
                {
                    this.Close();
                    frmAddCourse l = new frmAddCourse();
                    l.Show();
                }
                else
                {
                    this.Close();
                }
                con.Close();

            }
            
        }
    }
}
