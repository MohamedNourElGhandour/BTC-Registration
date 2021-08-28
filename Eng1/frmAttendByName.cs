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
    public partial class frmAttendByName : Form
    {
        public frmAttendByName()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
               

                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                {
                    con.Open();
                    string y = "select [Day1],[Day2],[Day3],[Day4],[Day5],[Day6],[Day7],[Day8] from St  where Student_Name_Ar='" + txtName.Text + "'";

                    OleDbCommand com = new OleDbCommand(y, con);
                    OleDbDataReader r = com.ExecuteReader();
                    while (r.Read())
                    {
                        checkBox1.Checked = r.GetBoolean(0);
                        checkBox2.Checked = r.GetBoolean(1);
                        checkBox3.Checked = r.GetBoolean(2);
                        checkBox4.Checked = r.GetBoolean(3);
                        checkBox5.Checked = r.GetBoolean(4);
                        checkBox6.Checked = r.GetBoolean(5);
                        checkBox7.Checked = r.GetBoolean(6);
                        checkBox8.Checked = r.GetBoolean(7);
                        // اذا كان هناك استرجاع لنتائج insert اظهر زر 
                        btnInsert.Visible = true;
                        // اذا كان هناك استرجاع لنتائج checkboxes اظهر زر 
                        checkBox1.Enabled = true;
                        checkBox2.Enabled = true;
                        checkBox3.Enabled = true;
                        checkBox4.Enabled = true;
                        checkBox5.Enabled = true;
                        checkBox6.Enabled = true;
                        checkBox7.Enabled = true;
                        checkBox8.Enabled = true;

                    }
                    r.Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "No value given for one or more required parameters.")
                {
                    MessageBox.Show("Click OK");
                }
                else { MessageBox.Show(ex.Message); }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            float total = 0;
            if (txtName.Text == "")
            {
                return;
            }

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                con.Open();
                string m = "update St set [Day1]=" + checkBox1.Checked + ",[Day2]=" + checkBox2.Checked + ",[Day3]=" + checkBox3.Checked + ",[Day4]=" + checkBox4.Checked + ",[Day5]=" + checkBox5.Checked + ",[Day6]=" + checkBox6.Checked + ",[Day7]=" + checkBox7.Checked + ",[Day8]=" + checkBox8.Checked + ",[Attendence_Degree]=@total where Student_Name_Ar='" + txtName.Text + "'";//+ comboName.ValueMember +;
                using (OleDbCommand com = new OleDbCommand(m, con))
                {
                    if (checkBox1.Checked == true)
                    {
                        total = total + 2.5f;
                    }
                    if (checkBox2.Checked == true)
                    {
                        total = total + 2.5f;
                    }
                    if (checkBox3.Checked == true)
                    {
                        total = total + 2.5f;
                    }
                    if (checkBox4.Checked == true)
                    {
                        total = total + 2.5f;
                    }
                    if (checkBox5.Checked == true)
                    {
                        total = total + 2.5f;
                    }
                    if (checkBox6.Checked == true)
                    {
                        total = total + 2.5f;
                    }
                    if (checkBox7.Checked == true)
                    {
                        total = total + 2.5f;
                    }
                    if (checkBox8.Checked == true)
                    {
                        total = total + 2.5f;
                    }

                    com.Parameters.AddWithValue("@total", total);
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    checkBox3.Enabled = false;
                    checkBox4.Enabled = false;
                    checkBox5.Enabled = false;
                    checkBox6.Enabled = false;
                    checkBox7.Enabled = false;
                    checkBox8.Enabled = false;
                    int g = com.ExecuteNonQuery();

                    if (g > 0)
                    {
                        //label8.Visible = true;
                        //lblResult.Text = n.ToString();                     
                        con.Close();
                        MessageBox.Show("Insertion Successed.");
                    }

                }

            }
            btnInsert.Visible = false;
        }
    }
}
