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
    public partial class frmProgramDetailsByName : Form
    {
        public frmProgramDetailsByName()
        {
            InitializeComponent();
        }
        bool load1 = false;
        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtProjectName.Text = "";
            txtProjectUnity.Text = "";
            txtPerformance.Text = "";
            txtConfidance.Text = "";
            txtCommunication.Text = "";
            txtAccuracy.Text = "";
            lblShowProjectdegree.Visible = false;
            lblResult.Visible = false;

            //try
            //{
            //using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            //{
            //    con.Open();
            //    using (OleDbCommand com = new OleDbCommand("select Attendence_Degree,Projectdegree from St where Stud_ID=" + comboName.SelectedValue + "", con))
            //    {
            //        OleDbDataReader r = com.ExecuteReader();
            //        while (r.Read())
            //        {
            //            txtAttendence_Degree.Text = r.GetFloat(0).ToString();
            //            txtProjectdegree.Text = r.GetInt32(1).ToString();
            //        }
            //        r.Close();

            //    }
            //}
                if (load1)
                {
                    using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                    {
                        con.Open();
                        using (OleDbCommand com = new OleDbCommand("select Accuracy,Performance,Confidance,Communication,ProjectUnity,Projectdegree from St where Student_Name_Ar='" + txtName.Text + "'", con))
                        {
                            OleDbDataReader r = com.ExecuteReader();
                            while (r.Read())
                            {
                                //txtStudent_Name_Ar.Text = r.GetString(0);                                                          
                                //txtProjectName.Text = r.GetString(0);
                                txtAccuracy.Text = r.GetInt32(0).ToString();
                                txtPerformance.Text = r.GetInt32 (1).ToString();
                                txtConfidance.Text = r.GetInt32 (2).ToString();
                                txtCommunication.Text = r.GetInt32(3).ToString();
                                txtProjectUnity.Text = r.GetInt32 (4).ToString();
                                lblResult.Text = r.GetInt32(5).ToString();
                            }
                            r.Close();
                        }
                    }
                }
            //}
            //catch (Exception ex)
            //{
               
            //    MessageBox.Show(ex.Message); 
            //}
        }

        private void frmProgramDetailsByName_Shown(object sender, EventArgs e)
        {
            load1 = true;
        }
      
    }
}
