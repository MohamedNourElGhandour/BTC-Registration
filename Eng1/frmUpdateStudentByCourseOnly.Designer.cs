namespace Eng1
{
    partial class frmUpdateStudentByCourseOnly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateStudentByCourseOnly));
            this.comboCourseSearch = new System.Windows.Forms.ComboBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnCreateGroup = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.comboRervedType = new System.Windows.Forms.ComboBox();
            this.comboCourse = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRemained = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPayed = new System.Windows.Forms.TextBox();
            this.txtDeserved = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEducation = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboGroupId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudent_Name_Ar = new System.Windows.Forms.TextBox();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudent_Name = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_ID_Card = new System.Windows.Forms.CheckBox();
            this.chk_Adoption = new System.Windows.Forms.CheckBox();
            this.chk_Pic = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboCourseSearch
            // 
            this.comboCourseSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCourseSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCourseSearch.FormatString = "d";
            this.comboCourseSearch.FormattingEnabled = true;
            this.comboCourseSearch.Location = new System.Drawing.Point(380, 52);
            this.comboCourseSearch.Name = "comboCourseSearch";
            this.comboCourseSearch.Size = new System.Drawing.Size(273, 24);
            this.comboCourseSearch.TabIndex = 164;
            this.comboCourseSearch.SelectedIndexChanged += new System.EventHandler(this.comboCourseSearch_SelectedIndexChanged);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(465, 260);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(36, 24);
            this.btnAddCourse.TabIndex = 163;
            this.btnAddCourse.Text = "...";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Location = new System.Drawing.Point(896, 504);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(36, 24);
            this.btnCreateGroup.TabIndex = 162;
            this.btnCreateGroup.Text = "...";
            this.btnCreateGroup.UseVisualStyleBackColor = true;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Highlight;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(42, 303);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 19);
            this.label17.TabIndex = 161;
            this.label17.Text = "Reserve Type";
            // 
            // comboRervedType
            // 
            this.comboRervedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRervedType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRervedType.FormattingEnabled = true;
            this.comboRervedType.Items.AddRange(new object[] {
            "منحة12 شهر مستردة",
            "منحة 12 شهر غير مسترده شاملة الشهادة",
            "منحة 6 شهر غير مسترده شاملة الشهادة",
            "منحة 12 شهر غير  شاملة الشهادة",
            "منحة 6 شهر غير شاملة الشهادة",
            "ثلاث شهور",
            "محادثة"});
            this.comboRervedType.Location = new System.Drawing.Point(166, 298);
            this.comboRervedType.Name = "comboRervedType";
            this.comboRervedType.Size = new System.Drawing.Size(273, 24);
            this.comboRervedType.TabIndex = 160;
            this.comboRervedType.SelectedIndexChanged += new System.EventHandler(this.comboRervedType_SelectedIndexChanged);
            // 
            // comboCourse
            // 
            this.comboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCourse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCourse.FormattingEnabled = true;
            this.comboCourse.Location = new System.Drawing.Point(166, 260);
            this.comboCourse.Name = "comboCourse";
            this.comboCourse.Size = new System.Drawing.Size(273, 24);
            this.comboCourse.TabIndex = 159;
            this.comboCourse.SelectedIndexChanged += new System.EventHandler(this.comboCourse_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Highlight;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(42, 260);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 19);
            this.label16.TabIndex = 158;
            this.label16.Text = "Course";
            // 
            // txtRemained
            // 
            this.txtRemained.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemained.Enabled = false;
            this.txtRemained.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtRemained.Location = new System.Drawing.Point(645, 463);
            this.txtRemained.Name = "txtRemained";
            this.txtRemained.Size = new System.Drawing.Size(273, 22);
            this.txtRemained.TabIndex = 157;
            this.txtRemained.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumber);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Highlight;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(528, 466);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 19);
            this.label15.TabIndex = 156;
            this.label15.Text = "Remained";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Highlight;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(528, 417);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 19);
            this.label14.TabIndex = 155;
            this.label14.Text = "Payed";
            // 
            // txtPayed
            // 
            this.txtPayed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPayed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPayed.Location = new System.Drawing.Point(645, 417);
            this.txtPayed.Name = "txtPayed";
            this.txtPayed.Size = new System.Drawing.Size(273, 22);
            this.txtPayed.TabIndex = 154;
            this.txtPayed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumber);
            // 
            // txtDeserved
            // 
            this.txtDeserved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeserved.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtDeserved.Location = new System.Drawing.Point(645, 371);
            this.txtDeserved.Name = "txtDeserved";
            this.txtDeserved.Size = new System.Drawing.Size(273, 22);
            this.txtDeserved.TabIndex = 153;
            this.txtDeserved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumber);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(528, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 152;
            this.label4.Text = "Deserved";
            // 
            // txtEndDate
            // 
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEndDate.Location = new System.Drawing.Point(645, 277);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(273, 22);
            this.txtEndDate.TabIndex = 151;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Highlight;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(528, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 19);
            this.label12.TabIndex = 150;
            this.label12.Text = "End  Date";
            // 
            // txtStartDate
            // 
            this.txtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStartDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtStartDate.Location = new System.Drawing.Point(645, 227);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(273, 22);
            this.txtStartDate.TabIndex = 149;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Highlight;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(528, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 19);
            this.label13.TabIndex = 148;
            this.label13.Text = "Start Date";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(645, 326);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 22);
            this.txtEmail.TabIndex = 147;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Highlight;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(528, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 19);
            this.label11.TabIndex = 146;
            this.label11.Text = "E-mail";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBirthDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBirthDate.Location = new System.Drawing.Point(645, 168);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(273, 22);
            this.txtBirthDate.TabIndex = 145;
            this.txtBirthDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Justdate);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Highlight;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(42, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 144;
            this.label10.Text = "Mobile";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAddress.Location = new System.Drawing.Point(166, 482);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(273, 22);
            this.txtAddress.TabIndex = 143;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(42, 485);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 142;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(42, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 141;
            this.label8.Text = "Education";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(528, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 140;
            this.label7.Text = "Birth Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(42, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 139;
            this.label5.Text = "Telephone";
            // 
            // txtEducation
            // 
            this.txtEducation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEducation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEducation.Location = new System.Drawing.Point(166, 437);
            this.txtEducation.Name = "txtEducation";
            this.txtEducation.Size = new System.Drawing.Size(273, 22);
            this.txtEducation.TabIndex = 138;
            this.txtEducation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustLetter);
            // 
            // txtMobile
            // 
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMobile.Location = new System.Drawing.Point(166, 388);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(273, 22);
            this.txtMobile.TabIndex = 137;
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumber);
            // 
            // txtTelephone
            // 
            this.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelephone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTelephone.Location = new System.Drawing.Point(166, 345);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(273, 22);
            this.txtTelephone.TabIndex = 136;
            this.txtTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumber);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(528, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 135;
            this.label6.Text = "Group ID";
            // 
            // comboGroupId
            // 
            this.comboGroupId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGroupId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGroupId.FormattingEnabled = true;
            this.comboGroupId.Location = new System.Drawing.Point(645, 504);
            this.comboGroupId.Name = "comboGroupId";
            this.comboGroupId.Size = new System.Drawing.Size(245, 24);
            this.comboGroupId.TabIndex = 134;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(42, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 133;
            this.label3.Text = "Arabic Name";
            // 
            // txtStudent_Name_Ar
            // 
            this.txtStudent_Name_Ar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudent_Name_Ar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtStudent_Name_Ar.Location = new System.Drawing.Point(166, 166);
            this.txtStudent_Name_Ar.Name = "txtStudent_Name_Ar";
            this.txtStudent_Name_Ar.Size = new System.Drawing.Size(273, 23);
            this.txtStudent_Name_Ar.TabIndex = 132;
            this.txtStudent_Name_Ar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustLetter);
            // 
            // comboName
            // 
            this.comboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(380, 102);
            this.comboName.Name = "comboName";
            this.comboName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboName.Size = new System.Drawing.Size(273, 24);
            this.comboName.TabIndex = 131;
            this.comboName.SelectedIndexChanged += new System.EventHandler(this.comboName_SelectedIndexChanged);
            this.comboName.DropDown += new System.EventHandler(this.comboName_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(33, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 130;
            this.label2.Text = "English Name";
            // 
            // txtStudent_Name
            // 
            this.txtStudent_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudent_Name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtStudent_Name.Location = new System.Drawing.Point(166, 219);
            this.txtStudent_Name.Name = "txtStudent_Name";
            this.txtStudent_Name.Size = new System.Drawing.Size(273, 23);
            this.txtStudent_Name.TabIndex = 129;
            this.txtStudent_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustLetter);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(449, 573);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 41);
            this.btnUpdate.TabIndex = 128;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.MenuText;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(225, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 19);
            this.label18.TabIndex = 166;
            this.label18.Text = "Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuText;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(225, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 165;
            this.label1.Text = "Name";
            // 
            // chk_ID_Card
            // 
            this.chk_ID_Card.AutoSize = true;
            this.chk_ID_Card.BackColor = System.Drawing.SystemColors.Highlight;
            this.chk_ID_Card.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.chk_ID_Card.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_ID_Card.Location = new System.Drawing.Point(43, 535);
            this.chk_ID_Card.Name = "chk_ID_Card";
            this.chk_ID_Card.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_ID_Card.Size = new System.Drawing.Size(85, 23);
            this.chk_ID_Card.TabIndex = 169;
            this.chk_ID_Card.Text = "ID Card";
            this.chk_ID_Card.UseVisualStyleBackColor = false;
            // 
            // chk_Adoption
            // 
            this.chk_Adoption.AutoSize = true;
            this.chk_Adoption.BackColor = System.Drawing.SystemColors.Highlight;
            this.chk_Adoption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.chk_Adoption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_Adoption.Location = new System.Drawing.Point(204, 535);
            this.chk_Adoption.Name = "chk_Adoption";
            this.chk_Adoption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_Adoption.Size = new System.Drawing.Size(94, 23);
            this.chk_Adoption.TabIndex = 168;
            this.chk_Adoption.Text = "Contract";
            this.chk_Adoption.UseVisualStyleBackColor = false;
            // 
            // chk_Pic
            // 
            this.chk_Pic.AutoSize = true;
            this.chk_Pic.BackColor = System.Drawing.SystemColors.Highlight;
            this.chk_Pic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.chk_Pic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chk_Pic.Location = new System.Drawing.Point(355, 535);
            this.chk_Pic.Name = "chk_Pic";
            this.chk_Pic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_Pic.Size = new System.Drawing.Size(82, 23);
            this.chk_Pic.TabIndex = 167;
            this.chk_Pic.Text = "Picture";
            this.chk_Pic.UseVisualStyleBackColor = false;
            // 
            // frmUpdateStudentByCourseOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 652);
            this.Controls.Add(this.chk_ID_Card);
            this.Controls.Add(this.chk_Adoption);
            this.Controls.Add(this.chk_Pic);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCourseSearch);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnCreateGroup);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboRervedType);
            this.Controls.Add(this.comboCourse);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtRemained);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPayed);
            this.Controls.Add(this.txtDeserved);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEducation);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboGroupId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStudent_Name_Ar);
            this.Controls.Add(this.comboName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudent_Name);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmUpdateStudentByCourseOnly";
            this.Text = "Update Student By Course Only";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUpdateStudentByCourseOnly_Load);
            this.Shown += new System.EventHandler(this.frmUpdateStudentByCourseOnly_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCourseSearch;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnCreateGroup;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboRervedType;
        private System.Windows.Forms.ComboBox comboCourse;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRemained;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPayed;
        private System.Windows.Forms.TextBox txtDeserved;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEducation;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboGroupId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudent_Name_Ar;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudent_Name;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_ID_Card;
        private System.Windows.Forms.CheckBox chk_Adoption;
        private System.Windows.Forms.CheckBox chk_Pic;
    }
}