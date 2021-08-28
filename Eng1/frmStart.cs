using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eng1
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStu y = new frmAddStu();
            y.ShowDialog();
        }

       

     

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteStu s = new frmDeleteStu();
            s.ShowDialog();
        }

       

        private void enterMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarks f = new frmMarks();
            f.ShowDialog();
        }

       

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmRepAll r = new frmRepAll();
            //r.ShowDialog();
            RpMarks o = new RpMarks();
            o.ShowDialog();
        }

      

       

       

        private void viewDegreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewDegree v = new frmViewDegree();
            v.ShowDialog();
        }

       

       

        private void evaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvaluation r = new frmEvaluation();
            r.ShowDialog();
        }

        private void allEvaluationReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllEvaluationReport r = new frmAllEvaluationReport();
            r.ShowDialog();
        }

       

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddInstructor g = new frmAddInstructor();
            g.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser a = new frmAddUser();
            a.ShowDialog();
        }

        private void updateGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateGroup f = new frmUpdateGroup();
            f.ShowDialog();
        }

        private void viewGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewGroup v = new frmViewGroup();
            v.ShowDialog();
        }

        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateGroup n = new frmCreateGroup();
            n.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAttend f = new frmAttend();
            f.ShowDialog();
        }

        private void ProjectDetailstoolStrip_Click(object sender, EventArgs e)
        {
            frmProjectDetails p = new frmProjectDetails();
            p.ShowDialog();
        }

      

        private void aDDCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCourse h = new frmAddCourse();
            h.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteCourse h = new frmDeleteCourse();
            h.ShowDialog();
        }

        private void deleteIntructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteInstructor u = new frmDeleteInstructor();
            u.ShowDialog();
        }

        private void memberGroupsNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCount k = new frmCount();
            k.ShowDialog();
        }

        private void byIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateStudentByID p = new frmUpdateStudentByID();
            p.ShowDialog();
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateStu y = new frmUpdateStu();
            y.ShowDialog();
        }

        private void byCourseOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmUpdateStudentByCourseOnly h = new frmUpdateStudentByCourseOnly();
            h.ShowDialog();
        }

        private void byCourseAndGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateStudentByCourse p = new frmUpdateStudentByCourse();
            p.ShowDialog();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttendByName o = new frmAttendByName();
            o.ShowDialog();
        }

        private void projectDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProgramDetailsByName j = new frmProgramDetailsByName();
            j.ShowDialog();
        }

        private void enterMarksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProgramDetailsByName o = new frmProgramDetailsByName();
            o.ShowDialog();
        }

        
        

        

      

      
        
     

     
        
    }
}
