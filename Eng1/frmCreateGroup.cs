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
    public partial class frmCreateGroup : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb");
        bool u;
        bool loaded;
        public frmCreateGroup()
        {
            InitializeComponent();
        }

        private void frmCreateGroup_Load(object sender, EventArgs e)
        {
            con.Open();
            
                //Fill combo box with Course Names
                using (OleDbCommand com1 = new OleDbCommand("select CourseID,CourseName from Courses", con))
                {
                    OleDbDataAdapter d1 = new OleDbDataAdapter(com1);
                    DataTable t = new DataTable();
                    d1.Fill(t);
                    comboCourse.DataSource = t;
                    comboCourse.ValueMember = t.Columns[0].ToString();
                    comboCourse.DisplayMember = t.Columns[1].ToString();
               }
            

            using (OleDbCommand com2 = new OleDbCommand("select InstuctorID,InstructorName from Instructors where Course_ID=1", con))
            {
                OleDbDataAdapter d = new OleDbDataAdapter(com2);
                DataTable dt = new DataTable();
                d.Fill(dt);
                comboInstructor.DataSource = dt;
                comboInstructor.ValueMember = dt.Columns[0].ToString();
                comboInstructor.DisplayMember = dt.Columns[1].ToString();

            }
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (txtGroupID.Text == "")
            {
                MessageBox.Show("Please insert Group ID");
                return;
            }

            if (comboDays.Text== "" || comboHours.Text == "" || comboInstructor.Text == "" || comboClass.Text == ""|| comboCourse.Text == "")
            {
                MessageBox.Show("Please select value in Days,Hours,Class,Course and Instructor"); return;
            }

            if (comboCourse.Text == "English")
            {
                if (comboLevel.Text == "")
                {
                    MessageBox.Show("please select the number of level"); return;
                }
            }
            if (Convert.ToInt32(comboCourse.SelectedValue) == 1 && Convert.ToInt16(comboLevel.Text) == -1)
            {
                MessageBox.Show("Please If You Want to select English Course,You Can Select Levels from 0 to 12");
                return;
            }

            con.Open();
            try
            {
                u = false;

           
            OleDbCommand com = new OleDbCommand("Insert Into Groups (group_ID,GroupDay,GroupHours,GroupStart,Class,[level],CourseID,InstuctorID) values (@group_ID,@txtGroupDay,@txtGroupHours,@txtGroupStart,@Class,@txtlevel,@txtCourseID,@txtInstuctorID)", con);
            com.Parameters.AddWithValue("@group_ID", double.Parse(txtGroupID.Text));
            com.Parameters.AddWithValue("@txtGroupDay", comboDays.Text );
            com.Parameters.AddWithValue("@txtGroupHours", comboHours.Text);
            com.Parameters.AddWithValue("@txtGroupStart", DateTime.Now.Date);
            com.Parameters.AddWithValue("@Class", comboClass.Text);
            if (comboCourse.Text == "English")
            {
                if (comboLevel.Text=="")
                {
                    MessageBox.Show("please select the number of level"); return;
                }
                com.Parameters.AddWithValue("@txtlevel", Convert.ToInt32(comboLevel.Text));
            }
            else
            {
                comboLevel.SelectedIndex = 13;
                com.Parameters.AddWithValue("@txtlevel", -1);
            }
            com.Parameters.AddWithValue("@txtCourseID", comboCourse.SelectedValue);
            com.Parameters.AddWithValue("@txtInstuctorID", comboInstructor.SelectedValue);

            u = true;
                int n = com.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Insertion Successed.");
                }

            }
            catch (OleDbException ex)
            {
                u = false;
                if (ex.Message == "The changes you requested to the table were not successful because they would create duplicate values in the index, primary key, or relationship.  Change the data in the field or fields that contain duplicate data, remove the index, or redefine the index to permit duplicate entries and try again.")
                {
                    MessageBox.Show("Sorry,This ID is repeated");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                u = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //تنبيه اضافة جديد
                if (u)
                {
                    DialogResult xx = MessageBox.Show("Do you need to add anew group", "Attention", MessageBoxButtons.YesNo);
                    if (xx == DialogResult.Yes)
                    {
                        this.Close();
                        frmCreateGroup l = new frmCreateGroup();
                        l.Show();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                //انتهى اضافة جديد

                con.Close();
            }
        }

        private void comboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Fill combo box with instructor Names
            if(loaded)
            {
                OleDbCommand com = new OleDbCommand("select InstuctorID,InstructorName from Instructors where Course_ID="+ comboCourse.SelectedValue  +"", con);
            OleDbDataAdapter d = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            d.Fill(dt);
            comboInstructor.DataSource = dt;
            comboInstructor.ValueMember = dt.Columns[0].ToString();
            comboInstructor.DisplayMember = dt.Columns[1].ToString();
            con.Close();
            }
            if (comboCourse.Text == "English")
            {
                comboLevel .Enabled = true;
            }
            else
            {
                comboLevel.Enabled = false  ;

            }
        }

        private void frmCreateGroup_Shown(object sender, EventArgs e)
        {
            loaded = true;
        }

        private void btnAddIntructor_Click(object sender, EventArgs e)
        {
            frmAddInstructor u = new frmAddInstructor();
            u.ShowDialog();

            //Fill combo box with Course Names
            OleDbCommand com1 = new OleDbCommand("select CourseID,CourseName from Courses", con);
            OleDbDataAdapter d1 = new OleDbDataAdapter(com1);
            DataTable t = new DataTable();
            d1.Fill(t);
            comboCourse.DataSource = t;
            comboCourse.ValueMember = t.Columns[0].ToString();
            comboCourse.DisplayMember = t.Columns[1].ToString();

        }

     

       

       
        

        
    }
}
