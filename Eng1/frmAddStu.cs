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
    public partial class frmAddStu : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb");        

        public frmAddStu()
        {
            InitializeComponent();
        }
        // This bool variable prevents message"Do You want to add new trainee?" when The ID message is repeated   
        bool u ;
        bool load = false;

        private void btnStu_Click(object sender, EventArgs e)
        {
            u = false  ;          
            try
            {

                //Validation For required fields

               
            if (txtIdentity.Text == "" || txtStudent_Name.Text == "" || txtStudent_Name_Ar.Text == "" || comboCourse.Text=="" ||txtMobile.Text=="")
            {
                MessageBox.Show("Please insert ID,Name,Course,Mobile");
                return;
            }

            if (txtEducation.Text==""||txtBirthDate.Text==""||txtStartDate.Text=="" ||txtDeserved.Text==""||txtPayed.Text =="")
            {
                MessageBox.Show("Please insert Education,Birthdate,StartDate,Deserved,Payed");
                return;              
            }
            
             
             //open Connection
            con.Open();
            OleDbCommand com = new OleDbCommand("Insert Into St (Stud_ID,Student_Name_Ar,Student_Name,Course,Reserved_Type,Telephone,Mobile,Education,Address,Birthdate,StartDate,EndDate,Email,Desrved,Payed,Remained,Pic,Adoption,ID_Card,group_ID) values (@Stud_ID,@txtStudent_Name_Ar,@txtStudent_Name,@Course,@Reserved_Type,@Telephone,@Mobile,@Education,@Address,@Birthdate,@StartDate,@EndDate,@Email,@Desrved,@Payed,@Remained,@Pic,@Adoption,@ID_Card,@group_ID)", con);
            com.Parameters.AddWithValue("@Stud_ID",Convert.ToInt64( txtIdentity.Text ));
            com.Parameters.AddWithValue("@txtStudent_Name_Ar", txtStudent_Name_Ar.Text);
            com.Parameters.AddWithValue("@txtStudent_Name", txtStudent_Name.Text);               
            com.Parameters.AddWithValue("@Course", comboCourse.SelectedValue);
           

            if (comboCourse.Text == "English")
            {
                // يبقى لازم يختار إذا كان 3 شهور أو منحة English Courseفي حالة اختيار 
                if (comboRervedType.Text  == "")
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
            if (Convert.ToDateTime(txtBirthDate.Text)>=Convert.ToDateTime(txtStartDate.Text))
            {
                MessageBox.Show("Please BirthDate must < StartDate"); return;
            }
            com.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(txtStartDate.Text));

            if ((comboCourse.Text == "English" && comboRervedType.Text == "منحة12 شهر مستردة") || (comboCourse.Text == "English" && comboRervedType.Text == "منحة 12 شهر غير مسترده شاملة الشهادة") || (comboCourse.Text == "English" && comboRervedType.Text == "منحة 12 شهر غير  شاملة الشهادة"))
            {

               DateTime t1=Convert.ToDateTime(txtStartDate.Text );
               DateTime t2 = t1.AddYears(1).AddMonths(6) ;                   
               txtEndDate.Text = t2.ToString() ;
               com.Parameters.AddWithValue("@EndDate", t2 );
            }
            else if (comboCourse.Text=="English" && comboRervedType.Text=="ثلاث شهور")
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
           
                u =true;
                int n = com.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Insertion Successed.");
                }
            }
            catch (OleDbException ex)
            {
                u = false;
                //txtElseCourse.Text = "";
                if (ex.Message == "The changes you requested to the table were not successful because they would create duplicate values in the index, primary key, or relationship.  Change the data in the field or fields that contain duplicate data, remove the index, or redefine the index to permit duplicate entries and try again.")
                {
                    MessageBox.Show("Sorry,This ID is repeated");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception px)
            {
               //txtElseCourse.Text = "";
                u = false;

                
                if (px.Message == "String was not recognized as a valid DateTime.")
                {
                    MessageBox.Show("Please Insert Valid Date like 15/09/2011");
                }
                else
                {
                    MessageBox.Show(px.Message);

                }
            }
            finally
            {
                //تنبيه اضافة جديد
                if (u)
                {
                    DialogResult xx = MessageBox.Show("Do you want to add new trainee?", "Attention", MessageBoxButtons.YesNo);
                    if (xx == DialogResult.Yes)
                    {
                        this.Close();
                        frmAddStu l = new frmAddStu();
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

        private void frmAddStu_Load(object sender, EventArgs e)
        {
            OleDbCommand com = new OleDbCommand("select group_ID from Groups where CourseID=1", con);
            OleDbDataAdapter d = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            d.Fill(dt);
            comboGroupId.DataSource = dt;
            comboGroupId.ValueMember = dt.Columns[0].ToString();
            comboGroupId.DisplayMember = dt.Columns[0].ToString();



            OleDbCommand com1 = new OleDbCommand("select CourseID,CourseName from Courses", con);
            OleDbDataAdapter da = new OleDbDataAdapter(com1);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            comboCourse.DataSource = dt1;
            comboCourse.ValueMember = dt1.Columns[0].ToString();
            comboCourse.DisplayMember = dt1.Columns[1].ToString();
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
            if (Char.IsNumber(e.KeyChar) == false)
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

                if ((comboCourse.Text == "English" && comboRervedType.Text == "منحة12 شهر مستردة") || (comboCourse.Text == "English" && comboRervedType.Text == "منحة 12 شهر غير مسترده شاملة الشهادة") || (comboCourse.Text == "English" && comboRervedType.Text == "منحة 12 شهر غير  شاملة الشهادة") || (comboCourse.Text == "English" && comboRervedType.Text == "ثلاث شهور"))
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
            if ((comboCourse.Text == "English" && comboRervedType.Text == "منحة12 شهر مستردة") || (comboCourse.Text == "English" && comboRervedType.Text == "منحة 12 شهر غير مسترده شاملة الشهادة") || (comboCourse.Text == "English" && comboRervedType.Text == "منحة 12 شهر غير  شاملة الشهادة") || (comboCourse.Text == "English" && comboRervedType.Text == "ثلاث شهور"))
            {
                txtEndDate.Enabled = false;

            }
            else
            {
                txtEndDate.Enabled = true;
            }
        }

        private void frmAddStu_Shown(object sender, EventArgs e)
        {
            load = true;
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
   

    }
}
//"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=StartUpPath\Database.mdb;Jet OLEDB:Database Password='ShaktiSinghDulawat';"
//http://www.vb4arab.com/vb/showthread.php?t=30813
//"Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" & Application.StartupPath & "\addnewemp.mdb"
