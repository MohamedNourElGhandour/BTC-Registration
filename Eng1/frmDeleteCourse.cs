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
    public partial class frmDeleteCourse : Form
    {
        public frmDeleteCourse()
        {
            InitializeComponent();
        }
        bool loaded = false;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Are you sure deleting the the student
            DialogResult xx = MessageBox.Show("Are you sure  Deleting This Course?", "ATTENTION", MessageBoxButtons.YesNo);
            if (xx == DialogResult.No)
            {
                return;
            }
            //Finish
            try
            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                {
                    con.Open();
                    using (OleDbCommand com = new OleDbCommand("delete from Courses where CourseID=" + comboCourseNameDel.SelectedValue + "", con))
                    {
                        int i = com.ExecuteNonQuery();
                        MessageBox.Show(i.ToString() + "ٌ Record is eliminated", "Attention", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "The record cannot be deleted or changed because table 'St' includes related records." || ex.Message == "The record cannot be deleted or changed because table 'Instructors' includes related records.")
                {
                    MessageBox.Show("You cant not delete this Course, at First You must delete The students that paticipate in it,Second Delete The Instructors who teach this Course");
                }

                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void frmDeleteCourse_Load(object sender, EventArgs e)
        {
           
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                using (OleDbCommand com = new OleDbCommand("select CourseID,CourseName from Courses", con))
                {
                    OleDbDataAdapter adap = new OleDbDataAdapter(com);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    comboCourseNameDel.DataSource = dt;
                    comboCourseNameDel.ValueMember = dt.Columns[0].ToString();
                    comboCourseNameDel.DisplayMember = dt.Columns[1].ToString();
                }
            }
        }

        private void frmDeleteCourse_Shown(object sender, EventArgs e)
        {
            loaded = true;
        }

        private void comboCourseNameDel_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
