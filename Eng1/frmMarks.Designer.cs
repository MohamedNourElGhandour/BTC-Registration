namespace Eng1
{
    partial class frmMarks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarks));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWriting = new System.Windows.Forms.TextBox();
            this.txtReading = new System.Windows.Forms.TextBox();
            this.txtFinalExam = new System.Windows.Forms.TextBox();
            this.btnMarks = new System.Windows.Forms.Button();
            this.txtAttendence_Degree = new System.Windows.Forms.TextBox();
            this.txtProjectdegree = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.comboGroupID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtListening = new System.Windows.Forms.TextBox();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(114, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Writing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(114, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Reading";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(114, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "FinalExam";
            // 
            // txtWriting
            // 
            this.txtWriting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWriting.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtWriting.Location = new System.Drawing.Point(354, 388);
            this.txtWriting.Name = "txtWriting";
            this.txtWriting.Size = new System.Drawing.Size(200, 23);
            this.txtWriting.TabIndex = 5;
            this.txtWriting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumber);
            // 
            // txtReading
            // 
            this.txtReading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReading.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtReading.Location = new System.Drawing.Point(354, 350);
            this.txtReading.Name = "txtReading";
            this.txtReading.Size = new System.Drawing.Size(200, 23);
            this.txtReading.TabIndex = 4;
            this.txtReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumber);
            // 
            // txtFinalExam
            // 
            this.txtFinalExam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinalExam.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtFinalExam.Location = new System.Drawing.Point(354, 307);
            this.txtFinalExam.Name = "txtFinalExam";
            this.txtFinalExam.Size = new System.Drawing.Size(200, 23);
            this.txtFinalExam.TabIndex = 6;
            this.txtFinalExam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumber);
            // 
            // btnMarks
            // 
            this.btnMarks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnMarks.Location = new System.Drawing.Point(354, 477);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(144, 38);
            this.btnMarks.TabIndex = 8;
            this.btnMarks.Text = "Enter Marks";
            this.btnMarks.UseVisualStyleBackColor = true;
            this.btnMarks.Click += new System.EventHandler(this.btnMarks_Click);
            // 
            // txtAttendence_Degree
            // 
            this.txtAttendence_Degree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAttendence_Degree.Enabled = false;
            this.txtAttendence_Degree.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAttendence_Degree.Location = new System.Drawing.Point(354, 184);
            this.txtAttendence_Degree.Name = "txtAttendence_Degree";
            this.txtAttendence_Degree.Size = new System.Drawing.Size(200, 23);
            this.txtAttendence_Degree.TabIndex = 2;
            this.txtAttendence_Degree.Text = "0";
            // 
            // txtProjectdegree
            // 
            this.txtProjectdegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProjectdegree.Enabled = false;
            this.txtProjectdegree.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtProjectdegree.Location = new System.Drawing.Point(354, 228);
            this.txtProjectdegree.Name = "txtProjectdegree";
            this.txtProjectdegree.Size = new System.Drawing.Size(200, 23);
            this.txtProjectdegree.TabIndex = 3;
            this.txtProjectdegree.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(117, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Attendence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(114, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Projectdegree";
            // 
            // comboName
            // 
            this.comboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(354, 101);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(200, 24);
            this.comboName.TabIndex = 1;
            this.comboName.SelectedIndexChanged += new System.EventHandler(this.comboName_SelectedIndexChanged);
            this.comboName.DropDown += new System.EventHandler(this.comboName_DropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(114, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Trainee Name";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblGrade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblGrade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGrade.Location = new System.Drawing.Point(114, 428);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(55, 19);
            this.lblGrade.TabIndex = 13;
            this.lblGrade.Text = "Grade";
            this.lblGrade.Visible = false;
            // 
            // txtGrade
            // 
            this.txtGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrade.Enabled = false;
            this.txtGrade.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtGrade.Location = new System.Drawing.Point(354, 428);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(200, 23);
            this.txtGrade.TabIndex = 7;
            this.txtGrade.Visible = false;
            this.txtGrade.WordWrap = false;
            // 
            // comboGroupID
            // 
            this.comboGroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGroupID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboGroupID.FormattingEnabled = true;
            this.comboGroupID.Location = new System.Drawing.Point(354, 55);
            this.comboGroupID.Name = "comboGroupID";
            this.comboGroupID.Size = new System.Drawing.Size(200, 24);
            this.comboGroupID.TabIndex = 0;
            this.comboGroupID.SelectedIndexChanged += new System.EventHandler(this.comboGroupID_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(114, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Group ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(115, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Listening";
            // 
            // txtListening
            // 
            this.txtListening.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtListening.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtListening.Location = new System.Drawing.Point(354, 270);
            this.txtListening.Name = "txtListening";
            this.txtListening.Size = new System.Drawing.Size(200, 23);
            this.txtListening.TabIndex = 22;
            // 
            // comboLevel
            // 
            this.comboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLevel.Enabled = false;
            this.comboLevel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboLevel.FormattingEnabled = true;
            this.comboLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "-1"});
            this.comboLevel.Location = new System.Drawing.Point(354, 145);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(200, 24);
            this.comboLevel.TabIndex = 23;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLevel.Location = new System.Drawing.Point(114, 147);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(50, 19);
            this.lblLevel.TabIndex = 24;
            this.lblLevel.Text = "Level";
            // 
            // frmMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 547);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.comboLevel);
            this.Controls.Add(this.txtListening);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboGroupID);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProjectdegree);
            this.Controls.Add(this.txtAttendence_Degree);
            this.Controls.Add(this.btnMarks);
            this.Controls.Add(this.txtFinalExam);
            this.Controls.Add(this.txtReading);
            this.Controls.Add(this.txtWriting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMarks";
            this.Text = "Final Score";
            this.Load += new System.EventHandler(this.frmMarks_Load);
            this.Shown += new System.EventHandler(this.frmMarks_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWriting;
        private System.Windows.Forms.TextBox txtReading;
        private System.Windows.Forms.TextBox txtFinalExam;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.TextBox txtAttendence_Degree;
        private System.Windows.Forms.TextBox txtProjectdegree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.ComboBox comboGroupID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtListening;
        private System.Windows.Forms.ComboBox comboLevel;
        private System.Windows.Forms.Label lblLevel;
    }
}