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
    public partial class frmUpdateStudentByCourseOnly : Form
    {
        public frmUpdateStudentByCourseOnly()
        {
            InitializeComponent();
        }
        bool load = false;
        bool load1 = false;
        //bool load2 = false;
        int classvalue;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection con7 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb");
            con7.Open();


            try
            {
                //Validation For required fields

                if (txtStudent_Name.Text == "" || txtStudent_Name_Ar.Text == "" || comboCourse.Text == "" || txtMobile.Text == "")
                {
                    MessageBox.Show("Please insert Name,Course,Mobile");
                    return;
                }

                if (txtEducation.Text == "" || txtBirthDate.Text == "" || txtStartDate.Text == "" || txtDeserved.Text == "" || txtPayed.Text == "")
                {
                    MessageBox.Show("Please insert Education,Birthdate,StartDate,Deserved,Payed");
                    return;
                }
                if (comboGroupId.Text == "")
                {
                    MessageBox.Show("Please Select  Group");
                    return;
                }

                OleDbCommand com = new OleDbCommand("update  St set Student_Name_Ar=@Student_Name_Ar,Student_Name=@Student_Name,Course=@Course,Reserved_Type=@Reserved_Type,Telephone=@Telephone,Mobile=@Mobile,Education=@Education,Address=@Address,Birthdate=@Birthdate,StartDate=@StartDate,EndDate=@EndDate,Email=@Email,Desrved=@Desrved,Payed=@Payed,Remained=@Remained,Pic=@Pic,Adoption=@Adoption,ID_Card=@ID_Card,group_ID=@group_ID where Stud_ID=" + comboName.SelectedValue + "", con7);
                com.Parameters.AddWithValue("@Student_Name_Ar", txtStudent_Name_Ar.Text);
                com.Parameters.AddWithValue("@txtStudent_Name", txtStudent_Name.Text);
                com.Parameters.AddWithValue("@Course", comboCourse.SelectedValue);

                if (comboCourse.Text == "English")
                {
                    // يبقى لازم يختار إذا كان 3 شهور أو منحة English Courseفي حالة اختيار 
                    if (comboRervedType.Text == "")
                    {
                        MessageBox.Show("Please If You Select English Course You must specify Reserved type"); return;
                    }
                    //انتهى
                    com.Parameters.AddWithValue("@Reserved_Type", comboRervedType.Text);
                }
                else
                {
                    com.Parameters.AddWithValue("@Reserved_Type", string.Empty);
                }
                com.Parameters.AddWithValue("@Telephone", txtTelephone.Text);
                com.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                com.Parameters.AddWithValue("@Education", txtEducation.Text);
                com.Parameters.AddWithValue("@Address", txtAddress.Text);
                com.Parameters.AddWithValue("@Birthdate", Convert.ToDateTime(txtBirthDate.Text));
                if (Convert.ToDateTime(txtBirthDate.Text) >= Convert.ToDateTime(txtStartDate.Text))
                {
                    MessageBox.Show("Please BirthDate must < StartDate"); return;
                }
                com.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(txtStartDate.Text));

                if (comboCourse.Text == "English" && comboRervedType.Text == "منحة")
                {

                    DateTime t1 = Convert.ToDateTime(txtStartDate.Text);
                    DateTime t2 = t1.AddYears(1).AddMonths(6);
                    txtEndDate.Text = t2.ToString();
                    com.Parameters.AddWithValue("@EndDate", t2);

                }
                else if (comboCourse.Text == "English" && comboRervedType.Text == "ثلاث شهور")
                {
                    DateTime t1 = Convert.ToDateTime(txtStartDate.Text);
                    DateTime t2 = t1.AddMonths(3);
                    txtEndDate.Text = t2.ToString();
                    com.Parameters.AddWithValue("@EndDate", t2);

                }
                else
                {
                    // ومنحة يبقى لازم تدخل تاريخ انتهاء الكورس English Courseفي حالة اختيار أي حاجة غير 
                    if (txtEndDate.Text == "")
                    {
                        MessageBox.Show("Please Insert End Date "); return;
                    }
                    //انتهى
                    com.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(txtEndDate.Text));
                }
                com.Parameters.AddWithValue("@Email", txtEmail.Text);
                com.Parameters.AddWithValue("@Desrved", Convert.ToInt32(txtDeserved.Text));

                //المبلغ المستحق لازم يكون أكبر من أو يساوي المدفوع 
                if (Convert.ToInt32(txtPayed.Text) > Convert.ToInt32(txtDeserved.Text))
                {
                    MessageBox.Show("Please Payed must <= Deserved"); return;
                }
                com.Parameters.AddWithValue("@Payed", Convert.ToInt32(txtPayed.Text));
                //المبلغ المتبقي =المبلغ المستحق - المبلغ المدفوع
                int remained = Convert.ToInt32(txtDeserved.Text) - Convert.ToInt32(txtPayed.Text);
                txtRemained.Text = remained.ToString();
                com.Parameters.AddWithValue("@Remained", remained);
                com.Parameters.AddWithValue("@Pic", chk_Pic.Checked);
                com.Parameters.AddWithValue("@Adoption", chk_Adoption.Checked);
                com.Parameters.AddWithValue("@ID_Card", chk_ID_Card.Checked);
                com.Parameters.AddWithValue("@group_ID", Convert.ToInt32(comboGroupId.Text));

                int n = com.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Update Successed.");
                }
            }
            catch (OleDbException ex)
            {
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
                if (ex.Message == "String was not recognized as a valid DateTime.")
                {
                    MessageBox.Show("Please Insert Valid Date like 15/09/2011");
                }
                else
                {
                    MessageBox.Show(ex.Message);

                }
               
            }
            finally
            {

                con7.Close();
            }
        }

        private void frmUpdateStudentByCourseOnly_Load(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                using (OleDbCommand com = new OleDbCommand("select CourseID,CourseName from Courses", con))
                {
                    OleDbDataAdapter k = new OleDbDataAdapter(com);
                    DataTable t = new DataTable();
                    k.Fill(t);
                    comboCourseSearch.DataSource = t;
                    comboCourseSearch.ValueMember = t.Columns[0].ToString();
                    comboCourseSearch.DisplayMember = t.Columns[1].ToString();
                    
                }
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

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                using (OleDbCommand com = new OleDbCommand("select group_ID from Groups where CourseID=1", con))
                {
                    OleDbDataAdapter d = new OleDbDataAdapter(com);
                    DataTable dt = new DataTable();
                    d.Fill(dt);
                    comboGroupId.DataSource = dt;
                    comboGroupId.ValueMember = dt.Columns[0].ToString();
                    comboGroupId.DisplayMember = dt.Columns[0].ToString();
                }
            }
        }

        private void comboCourseSearch_SelectedIndexChanged(object sender, EventArgs e) 
        {
            //try
            //{
                if ( load == true)
                {
                    using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                    {
                        using (OleDbCommand com = new OleDbCommand("select Stud_ID,Student_Name_Ar from St where Course=" + comboCourseSearch.SelectedValue + "", con))
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
            //    //if (ex.Message == "No value given for one or more required parameters.")
            //    //{
            //        //MessageBox.Show("Click OK");
            //    //}
            //    //else { 
            //        MessageBox.Show(ex.Message); 
            //    //}
            //}      
        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (load1)
                {

                    using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                    {
                        con.Open();
                        using (OleDbCommand com = new OleDbCommand("select Student_Name_Ar,Student_Name,Course,Reserved_Type,Telephone,Mobile,Education,Address,Birthdate,StartDate,EndDate,Email,Desrved,Payed,Remained,Pic,Adoption,ID_Card,group_ID  from St where Stud_ID=" + comboName.SelectedValue + "", con))
                        {
                            OleDbDataReader r = com.ExecuteReader();
                            while (r.Read())
                            {
                                txtStudent_Name_Ar.Text = r.GetString(0);
                                txtStudent_Name.Text = r.GetString(1);
                                classvalue = r.GetInt32(2);
                                comboRervedType.Text = r.GetString(3);
                                txtTelephone.Text = r.GetString(4);
                                txtMobile.Text = r.GetString(5);
                                txtEducation.Text = r.GetString(6);
                                txtAddress.Text = r.GetString(7);
                                txtBirthDate.Text = r.GetDateTime(8).ToString();
                                txtStartDate.Text = r.GetDateTime(9).ToString();
                                txtEndDate.Text = r.GetDateTime(10).ToString();
                                txtEmail.Text = r.GetString(11);
                                txtDeserved.Text = r.GetInt32(12).ToString();
                                txtPayed.Text = r.GetInt32(13).ToString();
                                txtRemained.Text = r.GetInt32(14).ToString();
                                chk_Pic.Checked = r.GetBoolean(15);
                                chk_Adoption.Checked = r.GetBoolean(16);
                                chk_ID_Card.Checked = r.GetBoolean(17);
                                comboGroupId.Text = r.GetInt32(18).ToString();
                            }
                            r.Close();
                        }
                        //using (OleDbCommand com = new OleDbCommand("select CourseName from Courses c join St s on c.CourseID =s.Course where Stud_ID=" + comboName.SelectedValue + "", con))
                        using (OleDbCommand com = new OleDbCommand("select CourseName from Courses where CourseID=" + classvalue + "", con))
                        {
                            OleDbDataReader rr = com.ExecuteReader();
                            while (rr.Read())
                            {
                                //comboCourse.SelectedItem = rr["CourseName"].ToString();
                                comboCourse.Text = rr["CourseName"].ToString();
                            }
                            rr.Close();
                        }
                    }

                    if (comboCourse.Text == "English")
                    {
                        comboRervedType.Enabled = true;
                    }
                    else
                    {
                        comboRervedType.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "No value given for one or more required parameters.")
                {
                    MessageBox.Show("click ok"); return;
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            frmAddCourse a = new frmAddCourse();
            a.ShowDialog();

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                using (OleDbCommand com = new OleDbCommand("select CourseID,CourseName from Courses", con))
                {
                    OleDbDataAdapter adap = new OleDbDataAdapter(com);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    comboCourse.DataSource = dt;
                    //ده عشان يعمل تحديث بالكورس الجديد للكورسات في مكان اختيار الكورسات
                    comboCourse.ValueMember = dt.Columns[0].ToString();
                    comboCourse.DisplayMember = dt.Columns[1].ToString();

                }
            }
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            frmCreateGroup a = new frmCreateGroup();
            a.ShowDialog();

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

        private void frmUpdateStudentByCourseOnly_Shown(object sender, EventArgs e)
        {
            load = true;
        }

        private void comboName_DropDown(object sender, EventArgs e)
        {
            load1 = true;
        }

        private void comboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //        هذا الكود يخرج لنا المجموعات على حسب نوع الكورس

            if (load)
            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                {
                    using (OleDbCommand com = new OleDbCommand("select group_ID from Groups where CourseID=" + comboCourse.SelectedValue + "", con))
                    {
                        OleDbDataAdapter d = new OleDbDataAdapter(com);
                        DataTable dt = new DataTable();
                        d.Fill(dt);
                        comboGroupId.DataSource = dt;
                        comboGroupId.ValueMember = dt.Columns[0].ToString();
                        comboGroupId.DisplayMember = dt.Columns[0].ToString();
                    }
                }
                //انتهى

                if (comboCourse.Text == "English")
                {
                    comboRervedType.Enabled = true;
                }
                else
                {
                    comboRervedType.Enabled = false;
                }


                if (comboCourse.Text == "English" && comboRervedType.Text == "منحة" || comboCourse.Text == "English" && comboRervedType.Text == "ثلاث شهور")
                {
                    txtEndDate.Enabled = false;

                }
                else
                {
                    txtEndDate.Enabled = true;
                }
            }
        }

        private void comboRervedType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCourse.Text == "English" && comboRervedType.Text == "منحة" || comboCourse.Text == "English" && comboRervedType.Text == "ثلاث شهور")
            {
                txtEndDate.Enabled = false;

            }
            else
            {
                txtEndDate.Enabled = true;
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

            if (e.KeyChar == 8)
            {
                e.Handled = false;

            }
        }

        private void Justdate(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false )
            {
                e.Handled = true;
            }

            if (e.KeyChar == 8)
            {
                e.Handled = false;

            }

            // 47 هذه العلامة / هي 
            if (e.KeyChar == 47)
            {
                e.Handled = false;

            }

        }

     
    }
}
