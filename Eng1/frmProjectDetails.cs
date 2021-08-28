﻿using System;
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
    public partial class frmProjectDetails : Form
    {
        public frmProjectDetails()
        {
            InitializeComponent();
        }
        //bool load1 = false;
        bool load = false;
        private void btnProjectDetails_Click(object sender, EventArgs e)
        {
            // Prevent to remain text box empty
            if (txtProjectName.Text=="" || txtAccuracy.Text == "" || txtCommunication.Text == "" || txtConfidance.Text == "" || txtPerformance.Text == "" || txtProjectUnity.Text == "")
            {
                MessageBox.Show("Please insert values");
                return;
            }

            // Prevent to enter >4 int text boxes
            if (float.Parse(txtAccuracy.Text) > 2 || float.Parse(txtCommunication.Text) >2 ||float.Parse( txtConfidance.Text) > 2 || float.Parse(txtPerformance.Text) > 2 || float.Parse(txtProjectUnity.Text) > 2)
            {
                MessageBox.Show("Please insert at most 2 Marks");
                return;
            }

            //insert project degress
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                con.Open();
                string m = "update St set [projectname]=@txtProjectName,[Accuracy]=@txtAccuracy,[Performance]=@txtPerformance,[Confidance]=@txtConfidance,[Communication]=@txtCommunication,[ProjectUnity]=@txtProjectUnity,[Projectdegree]=@Projectdegree where Stud_ID=" + comboName.SelectedValue + "";//+ comboName.ValueMember +;
                using (OleDbCommand com = new OleDbCommand(m, con))
                {
                    com.Parameters.AddWithValue("@txtProjectName", txtProjectName.Text);
                    com.Parameters.AddWithValue("@txtAccuracy", float.Parse(txtAccuracy.Text));
                    com.Parameters.AddWithValue("@txtPerformance", float.Parse(txtPerformance.Text));
                    com.Parameters.AddWithValue("@txtConfidance", float.Parse(txtConfidance.Text));
                    com.Parameters.AddWithValue("@txtCommunication", float.Parse(txtCommunication.Text));
                    com.Parameters.AddWithValue("@txtProjectUnity", float.Parse(txtProjectUnity.Text));
                    float n = float.Parse(txtAccuracy.Text) + float.Parse(txtCommunication.Text) + float.Parse(txtConfidance.Text) + float.Parse(txtPerformance.Text) + float.Parse(txtProjectUnity.Text);
                    com.Parameters.AddWithValue("@Projectdegree", n);
                    int g = com.ExecuteNonQuery();

                    if (g > 0)
                    {
                        lblShowProjectdegree.Visible = true;
                        lblResult.Visible = true;
                        lblResult.Text = n.ToString();
                        con.Close();
                        MessageBox.Show("Insertion Successed.");
                    }
                }
            }
        }

        private void frmProjectDetails_Load(object sender, EventArgs e)
        {
          
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                using (OleDbCommand com = new OleDbCommand("select group_ID from Groups where CourseID=1", con))
                {
                    OleDbDataAdapter d = new OleDbDataAdapter(com);
                    DataTable dt = new DataTable();
                    d.Fill(dt);
                    comboGroupID.DataSource = dt;
                    comboGroupID.ValueMember = dt.Columns[0].ToString();
                    comboGroupID.DisplayMember = dt.Columns[0].ToString();
                }
            }
        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProjectName.Text = "";
            txtProjectUnity.Text = "";
            txtPerformance.Text = "";
            txtConfidance.Text = "";
            txtCommunication.Text = "";
            txtAccuracy.Text = "";
            lblShowProjectdegree.Visible = false ;
            lblResult.Visible = false ;

            //try
            //{
            //    if (load1)
            //    {
            //        using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            //        {
            //            con.Open();
            //            using (OleDbCommand com = new OleDbCommand("select projectname,Accuracy,Performance,Confidance,Communication,ProjectUnity,Projectdegree from St where Stud_ID=" + comboName.SelectedValue + "", con))
            //            {
            //                OleDbDataReader r = com.ExecuteReader();
            //                while (r.Read())
            //                {
            //                    //txtStudent_Name_Ar.Text = r.GetString(0);
            //                    txtProjectName.Text = r.GetString(0);
            //                    txtAccuracy.Text = r.GetDecimal(1).ToString();
            //                    txtPerformance.Text = r.GetDecimal(2).ToString();
            //                    txtConfidance.Text = r.GetDecimal(3).ToString();
            //                    txtCommunication.Text = r.GetDecimal(4).ToString();
            //                    txtProjectUnity.Text = r.GetDecimal(5).ToString();
            //                    lblResult.Text = r.GetDecimal(6).ToString(); 
            //                }
            //                r.Close();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (ex.Message == "No value given for one or more required parameters.")
            //    {
            //        MessageBox.Show("Click OK");
            //    }
            //    else { MessageBox.Show(ex.Message); }
            //}
        }

        private void JustNumber(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false || e.KeyChar == 8)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;

            }

        }

        private void frmProjectDetails_Shown(object sender, EventArgs e)
        {
            load = true;
        }

        private void comboGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
                if (load == true)
                {
                    using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                    {
                        using (OleDbCommand com = new OleDbCommand("select Stud_ID,Student_Name_Ar from St where group_ID=" + comboGroupID.SelectedValue + "", con))
                        {
                            OleDbDataAdapter adap = new OleDbDataAdapter(com);
                            DataTable dt = new DataTable();
                            adap.Fill(dt);
                            comboName.DataSource = dt;
                            comboName.ValueMember = dt.Columns[0].ToString();
                            comboName.DisplayMember = dt.Columns[1].ToString();
                        }
                    }
                }
            //}
            //catch (Exception ex)
            //{
            //    if (ex.Message == "No value given for one or more required parameters.")
            //    {
            //        MessageBox.Show("Click OK");
            //    }
            //    else { MessageBox.Show(ex.Message); }
            //}
        }

        //private void comboName_DropDown(object sender, EventArgs e)
        //{
        //    //load1 = true;
        //}

        
      

      


    }
}
