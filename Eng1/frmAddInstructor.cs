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
    public partial class frmAddInstructor : Form
    {
        public frmAddInstructor()
        {
            InitializeComponent();
        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            if (txtName.Text=="")
            {
                MessageBox.Show("Please Insert Instructor Name ","Attention"); return;
            }

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb");
            OleDbCommand com = new OleDbCommand("Insert Into Instructors (InstructorName,Telephone,Course_ID) values (@InstructorName,@Telephone,@Course_ID)", con);
            com.Parameters.AddWithValue("@InstructorName", txtName.Text);
            com.Parameters.AddWithValue("@Telephone", txtTelephone.Text);
            com.Parameters.AddWithValue("@Course_ID",Convert.ToInt32( comboCourseName.SelectedValue));

          
            try
            {
                

                con.Open();
                int n = com.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Insertion Successed.");
                }

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //تنبيه اضافة جديد
                DialogResult xx = MessageBox.Show("Do you want to add new Instructor?", "Attention", MessageBoxButtons.YesNo);
                if (xx == DialogResult.Yes)
                {
                    this.Close();
                    frmAddInstructor  l = new frmAddInstructor ();
                    l.Show();
                    //this.Show();
                }
                else
                {
                    this.Close();
                }
                //انتهى اضافة جديد

                con.Close();
            }
        }

        private void frmAddInstructor_Load(object sender, EventArgs e)
        {
            
            int h = 0;
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                con.Open();
                OleDbCommand com1 = new OleDbCommand("select max(InstuctorID) from Instructors", con);
                h = (int)com1.ExecuteScalar() + 1;
                txtId.Text = h.ToString(); 
            }

            //Fill combo box with Course Names
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                using (OleDbCommand com = new OleDbCommand("select CourseID,CourseName from Courses", con))
                {
                    OleDbDataAdapter adap = new OleDbDataAdapter(com);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    comboCourseName.DataSource = dt;
                    comboCourseName.ValueMember = dt.Columns[0].ToString();
                    comboCourseName.DisplayMember = dt.Columns[1].ToString();
                }
            }

        }

        private void JustLetter(object sender, KeyPressEventArgs e)
        {
            //Enter Just Leters in textbox Arabic Name,English Name,Nationality
            if (Char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;
            }
            //8 bachspace , 32 space
            if (e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;

            }
        }

        private void JustNumber(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false || e.KeyChar == 8)
            {
                e.Handled = true;
            }

            
            if (e.KeyChar == 8 )
            {
                e.Handled = false;

            }
        }
    }
}
