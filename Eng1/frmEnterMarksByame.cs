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
    public partial class frmEnterMarksByame : Form
    {
        public frmEnterMarksByame()
        {
            InitializeComponent();
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            // Prevent to remain text box empty
            if (txtParticipation.Text == "" || txtListening.Text == "" || txtFinalExam.Text == "")
            {
                MessageBox.Show("Please insert values in Participation,Homework,FinalExam");
                return;
            }

            // Prevent to enter >5 in Homework and Participation
            if (float.Parse(txtListening.Text) > 5 || float.Parse(txtParticipation.Text) > 5)
            {
                MessageBox.Show("Please insert at most 5 degrees in Homework and Participation");
                return;
            }

            // Prevent to enter >50 in FinalExam
            if (float.Parse(txtFinalExam.Text) > 50)
            {
                MessageBox.Show("Please insert at most 50 degrees in Final Exam");
                return;
            }




            // insert Degress of Student
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                string l = "";
                con.Open();

                //string o = "update St set [Homework]=" + float.Parse(txtHomework.Text) + ",[Participation]=" + float.Parse(txtParticipation.Text) + ",[Exam_degree]=" + float.Parse(txtFinalExam.Text) + " where Stud_ID=" + comboName.SelectedValue + "";
                float k = float.Parse(txtListening.Text) + float.Parse(txtParticipation.Text) + float.Parse(txtFinalExam.Text) + float.Parse(txtAttendence_Degree.Text) + float.Parse(txtProjectdegree.Text);

                //check
                if (k >= 90 && k <= 100)
                {
                    l = "Excellent";
                    txtGrade.Text = "Excellent";
                }
                else if (k < 90 && k >= 80)
                {
                    l = "Very Good";
                    txtGrade.Text = "Very Good";
                }
                else if (k < 80 && k >= 70)
                {
                    l = "Good";
                    txtGrade.Text = "Good";
                }
                else if (k < 70 && k >= 65)
                {
                    l = "Pass";
                    txtGrade.Text = "Pass";
                }
                else if (k < 65 && k >= 0)
                {
                    l = "Fail";
                    txtGrade.Text = "Fail";
                }
                string b = "update St set [Homework]=" + float.Parse(txtListening.Text) + ",[Participation]=" + float.Parse(txtParticipation.Text) + ",[Exam_degree]=" + float.Parse(txtFinalExam.Text) + ",[Grade]=@Grade,[Finaldegree]=" + k + " where Stud_ID=" + txtTrainerName.Text  + "";

                using (OleDbCommand com = new OleDbCommand(b, con))
                {
                    com.Parameters.AddWithValue("@Grade", txtGrade.Text);
                    int h = com.ExecuteNonQuery();
                    if (h > 0)
                    {
                        MessageBox.Show("Insertion Successed.");
                    }
                }

            }

            lblGrade.Visible = true;
            txtGrade.Visible = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
