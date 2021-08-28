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
    public partial class frmCount : Form
    {
        public frmCount()
        {
            InitializeComponent();
        }
        bool Loaded, Loaded1;

        private void frmCount_Load(object sender, EventArgs e)
        {
            

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
            {
                using (OleDbCommand com = new OleDbCommand("select CourseID,CourseName from Courses", con))
                {
                    OleDbDataAdapter k = new OleDbDataAdapter(com);
                    DataTable t = new DataTable();
                    k.Fill(t);
                    comboCourse.DataSource = t;
                    comboCourse.ValueMember = t.Columns[0].ToString();
                    comboCourse.DisplayMember = t.Columns[1].ToString();

                }
            }
        }

        private void comboGroupId_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Loaded1)
            {
                try
                {

                    using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                    {
                        con.Open();
                        using (OleDbCommand com = new OleDbCommand("select Count(Stud_ID) from St where group_ID=" + comboGroupId.SelectedValue + "", con))
                        {
                            int o = (int)com.ExecuteScalar();
                            textBox1.Text = o.ToString();

                        }
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message == "No value given for one or more required parameters.")
                    {
                        MessageBox.Show("Click OK");
                    }
                    else
                    {
                        MessageBox.Show( ex.Message);
                    }
                }
            }
        }

        private void frmCount_Shown(object sender, EventArgs e)
        {
            Loaded = true;
        }

        private void comboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Loaded)
            {
                using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=English_DB.mdb"))
                {
                    using (OleDbCommand com = new OleDbCommand("select group_ID from Groups where CourseID="+comboCourse.SelectedValue +"", con))
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
        }

        private void comboGroupId_DropDown(object sender, EventArgs e)
        {
            Loaded1 = true;
        }
    }
}
