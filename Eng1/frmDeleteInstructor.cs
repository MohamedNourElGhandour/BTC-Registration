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
    public partial class frmDeleteInstructor : Form
    {
        public frmDeleteInstructor()
        {
            InitializeComponent();
        }
        bool loaded;
        int classvalue;
        private void frmDeleteInstructor_Load(object sender, EventArgs e)
        {
            
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                {
                    using (OleDbCommand com = new OleDbCommand("select InstuctorID,InstructorName from Instructors", con))
                    {
                        OleDbDataAdapter adap = new OleDbDataAdapter(com);
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        comboName.DataSource = dt;
                        comboName.ValueMember = dt.Columns[0].ToString();
                        comboName.DisplayMember = dt.Columns[1].ToString();
                    }
                }

                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                {
                    using (OleDbCommand com = new OleDbCommand("select CourseID,CourseName from Courses", con))
                    {
                        OleDbDataAdapter k = new OleDbDataAdapter(com);
                        DataTable t = new DataTable();
                        k.Fill(t);
                        comboCourseName.DataSource = t;
                        comboCourseName.ValueMember = t.Columns[0].ToString();
                        comboCourseName.DisplayMember = t.Columns[1].ToString();

                    }
                }
          
        }

        private void frmDeleteInstructor_Shown(object sender, EventArgs e)
        {
            loaded = true;
        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(loaded)
            {

                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                {
                    con.Open();
                    using (OleDbCommand com = new OleDbCommand("select  InstructorName,Telephone,Course_ID from Instructors where InstuctorID=" + comboName.SelectedValue + "", con))
                    {
                        OleDbDataReader rr = com.ExecuteReader(CommandBehavior.SingleRow);
                        while (rr.Read())
                        {
                            txtIntructorName.Text = rr["InstructorName"].ToString();
                            txtTelephone.Text = rr["Telephone"].ToString();
                            classvalue =Convert.ToInt32( rr["Course_ID"]);

                        }
                    }

                    using (OleDbCommand com = new OleDbCommand("select CourseName from Courses where CourseID=" + classvalue + "", con))
                    {
                        OleDbDataReader rr = com.ExecuteReader();
                        while (rr.Read())
                        {
                            //comboCourse.SelectedItem = rr["CourseName"].ToString();
                            comboCourseName.Text = rr["CourseName"].ToString();
                        }
                        rr.Close();
                    }
                }


            }
        }

        private void btnDeleteInstructor_Click(object sender, EventArgs e)
        {

            if (txtIntructorName.Text == "")
            {
                MessageBox.Show("Please select Instructor Name?"); return;
            }
            DialogResult xx = MessageBox.Show("Are You Sure Deleting This Instructor", "ِAttention", MessageBoxButtons.YesNo);
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

                    using (OleDbCommand com = new OleDbCommand("delete from Instructors where InstuctorID=" + comboName.SelectedValue + "", con))
                    {
                        int i = com.ExecuteNonQuery();
                        MessageBox.Show(i.ToString() + " Record is eliminated ", "Attention", MessageBoxButtons.OK);
                    }
                }
            }
            catch(Exception ex)
            {
                if (ex.Message == "The record cannot be deleted or changed because table 'Groups' includes related records.")
                {
                    MessageBox.Show("You Must Delete The Group Or Update it  with anthor Instructor before Deleting him", "Attention");
                    
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtIntructorName.Text=="")
            {
                MessageBox.Show("Please select Instructor Name"); return;
            }
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                con.Open();
              using (OleDbCommand com = new OleDbCommand("update  Instructors set InstructorName=@InstructorName,Telephone=@Telephone,Course_ID=@Course_ID where InstuctorID=" + comboName.SelectedValue + "", con))
              {

                com.Parameters.AddWithValue("@InstructorName", txtIntructorName.Text);
                com.Parameters.AddWithValue("@Telephone", txtTelephone.Text);
                com.Parameters.AddWithValue("@Course_ID", comboCourseName.SelectedValue);
                int n = com.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Update Successed.");
                }
              }
            }
        }

       

        
    }
}
