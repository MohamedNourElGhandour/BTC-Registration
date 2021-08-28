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
    public partial class frmUpdateGroup : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb");        

        public frmUpdateGroup()
        {
            InitializeComponent();
        }
        int value1, value2;
        bool loaded;
        private void frmUpdateGroup_Load(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                using (OleDbCommand com = new OleDbCommand("select group_ID from Groups", con))
                {
                    OleDbDataAdapter adap = new OleDbDataAdapter(com);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    comboID.DataSource = dt;
                    comboID.ValueMember = dt.Columns[0].ToString();
                }
            }

             // Fill combo box with instructor Names

            using (OleDbCommand com1 = new OleDbCommand("select InstuctorID,InstructorName from Instructors where Course_ID=1", con))
           {
            OleDbDataAdapter d = new OleDbDataAdapter(com1);
            DataTable dt = new DataTable();
            d.Fill(dt);
            comboInstructor.DataSource = dt;
            comboInstructor.ValueMember = dt.Columns[0].ToString();
            comboInstructor.DisplayMember = dt.Columns[1].ToString();
           
            }


           using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
           {
               using (OleDbCommand com = new OleDbCommand("select CourseID,CourseName from Courses", con))
               {
                   OleDbDataAdapter adap = new OleDbDataAdapter(com);
                   DataTable dt = new DataTable();
                   adap.Fill(dt);
                   comboCourse.DataSource = dt;
                   comboCourse.ValueMember = dt.Columns[0].ToString();
                   comboCourse.DisplayMember = dt.Columns[1].ToString();
               }
           }

           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            if (comboID.Text=="" || comboDays.Text == "" || comboHours.Text == "" || comboInstructor.Text == "" || comboClass.Text == "" || comboLevel.Text == "" || comboCourse.Text == "")
            {
                MessageBox.Show("Select Group ID"); return;
            }
            if (Convert.ToInt32( comboCourse.SelectedValue) == 1 &&  Convert.ToInt16( comboLevel.Text) == -1)
            {
                MessageBox.Show ("Please If You Want to select English Course,You Can Select Levels from 0 to 12");
                return;
            }
            
            con.Open();
            OleDbCommand com = new OleDbCommand("update  Groups set GroupDay=@txtGroupDay,GroupHours=@txtGroupHours,Class=@Class,CourseID=@CourseID,[level]=@txtlevel,InstuctorID=@txtInstuctorID where group_ID=" + double.Parse(comboID.Text) + "", con);
            com.Parameters.AddWithValue("@txtGroupDay", comboDays.Text);
            com.Parameters.AddWithValue("@txtGroupHours", comboHours.Text);
            //com.Parameters.AddWithValue("@txtGroupStart", DateTime.Now.Date);
            com.Parameters.AddWithValue("@Class", comboClass.Text);
            com.Parameters.AddWithValue("@CourseID",Convert.ToInt32(comboCourse.SelectedValue));
            if (Convert.ToInt32(comboCourse.SelectedValue) == 1)
            {
                com.Parameters.AddWithValue("@txtlevel", Convert.ToInt32(comboLevel.Text));
            }
            else
            {
                comboLevel.SelectedIndex = 13;
                com.Parameters.AddWithValue("@txtlevel", -1 );
            }
            com.Parameters.AddWithValue("@txtInstuctorID", comboInstructor.SelectedValue);
            try
            {
                int n = com.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Update Successed.");
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
                con.Close();
            }
        }

     
        

        private void comboID_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (loaded)
            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                {
                    con.Open();
                    using (OleDbCommand com = new OleDbCommand("select GroupDay,GroupHours,Class,[level],CourseID,InstuctorID  from Groups where group_ID=" + comboID.SelectedValue + "", con))
                    {
                        OleDbDataReader r = com.ExecuteReader();
                        while (r.Read())
                        {
                            comboDays.Text = r.GetString(0);
                            comboHours.Text = r.GetString(1);
                            comboClass.Text = r.GetString(2);
                            comboLevel.Text = r.GetInt32(3).ToString();
                            value1 = r.GetInt32(4);
                            value2 = r.GetInt32(5);

                        }
                        r.Close();

                    }
                    //using (OleDbCommand com = new OleDbCommand("select CourseName from Courses c join St s on c.CourseID =s.Course where Stud_ID=" + comboName.SelectedValue + "", con))
                    using (OleDbCommand com = new OleDbCommand("select CourseName from Courses where CourseID=" + value1 + "", con))
                    {
                        OleDbDataReader rr = com.ExecuteReader();
                        while (rr.Read())
                        {
                            //comboCourse.SelectedItem = rr["CourseName"].ToString();
                            comboCourse.Text = rr["CourseName"].ToString();
                        }
                        rr.Close();
                    }

                    using (OleDbCommand com = new OleDbCommand("select InstructorName from Instructors where InstuctorID=" + value2 + "", con))
                    {
                        OleDbDataReader rr = com.ExecuteReader();
                        while (rr.Read())
                        {
                            //comboCourse.SelectedItem = rr["CourseName"].ToString();
                            comboInstructor.Text = rr["InstructorName"].ToString();
                        }
                        rr.Close();
                    }


                }
            }

        }
      
        private void comboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded==true)
            {
                using (OleDbCommand com1 = new OleDbCommand("select InstuctorID,InstructorName from Instructors where Course_ID=" + comboCourse.SelectedValue + "", con))
                {
                    OleDbDataAdapter d = new OleDbDataAdapter(com1);
                    DataTable dt = new DataTable();
                    d.Fill(dt);
                    comboInstructor.DataSource = dt;
                    comboInstructor.ValueMember = dt.Columns[0].ToString();
                    comboInstructor.DisplayMember = dt.Columns[1].ToString();

                }
            }

            if (comboCourse.Text == "English")
            {
                comboLevel.Enabled = true;
            }
            else
            {
                comboLevel.Enabled = false;
                comboLevel.Text = "";

            }
            
        }

        private void frmUpdateGroup_Shown(object sender, EventArgs e)
        {
            loaded = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboID.Text == "" || comboDays.Text == "" || comboHours.Text == "" || comboInstructor.Text == "" || comboClass.Text == "" || comboLevel.Text == "" || comboCourse.Text == "")
            {
                MessageBox.Show("Select Group ID"); return;
            }

            DialogResult xx = MessageBox.Show("Are You Sure Deleting This Group?", "ِAttention", MessageBoxButtons.YesNo);
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

                    using (OleDbCommand com = new OleDbCommand("delete from Groups where group_ID=" + comboID.SelectedValue + "", con))
                    {
                        int i = com.ExecuteNonQuery();
                        MessageBox.Show(i.ToString() + " Record is eliminated ", "Attention", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "The record cannot be deleted or changed because table 'St' includes related records.")
                {
                    MessageBox.Show("You Must Delete The Trainee Who Paticipate In This Group  before Deleting It,Or Update The Trainee With Anthor Group?", "Attention");

                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       


    }
}
