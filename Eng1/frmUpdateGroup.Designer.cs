namespace Eng1
{
    partial class frmUpdateGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateGroup));
            this.label6 = new System.Windows.Forms.Label();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboHours = new System.Windows.Forms.ComboBox();
            this.comboDays = new System.Windows.Forms.ComboBox();
            this.comboInstructor = new System.Windows.Forms.ComboBox();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboID = new System.Windows.Forms.ComboBox();
            this.comboCourse = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(151, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Class";
            // 
            // comboClass
            // 
            this.comboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "J"});
            this.comboClass.Location = new System.Drawing.Point(392, 296);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(210, 24);
            this.comboClass.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(151, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Hours";
            // 
            // comboHours
            // 
            this.comboHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHours.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboHours.FormattingEnabled = true;
            this.comboHours.Items.AddRange(new object[] {
            "10: 12",
            "12: 2",
            "2  : 4",
            "4  : 6",
            "6  : 8",
            "8  : 10",
            "1  : 5",
            "5  : 9",
            "12: 4",
            "10: 2"});
            this.comboHours.Location = new System.Drawing.Point(392, 254);
            this.comboHours.Name = "comboHours";
            this.comboHours.Size = new System.Drawing.Size(210, 24);
            this.comboHours.TabIndex = 24;
            // 
            // comboDays
            // 
            this.comboDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDays.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboDays.FormattingEnabled = true;
            this.comboDays.Items.AddRange(new object[] {
            "Saturday,Tuesday",
            "Sunday , Wesdenday",
            "Monday,Thuresday",
            "Friday",
            "Saturday",
            "Saturday,Tuesday,Thuresday",
            "Sunday,Thuresday,Thuresday",
            "Saturday,Sunday,Wesdenday"});
            this.comboDays.Location = new System.Drawing.Point(392, 210);
            this.comboDays.Name = "comboDays";
            this.comboDays.Size = new System.Drawing.Size(210, 24);
            this.comboDays.TabIndex = 23;
            // 
            // comboInstructor
            // 
            this.comboInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInstructor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboInstructor.FormattingEnabled = true;
            this.comboInstructor.Location = new System.Drawing.Point(392, 426);
            this.comboInstructor.Name = "comboInstructor";
            this.comboInstructor.Size = new System.Drawing.Size(210, 24);
            this.comboInstructor.TabIndex = 22;
            // 
            // comboLevel
            // 
            this.comboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.comboLevel.Location = new System.Drawing.Point(392, 382);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(210, 24);
            this.comboLevel.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(151, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Instructor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(151, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(151, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(151, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Group ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(392, 511);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 28);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboID
            // 
            this.comboID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboID.FormattingEnabled = true;
            this.comboID.Items.AddRange(new object[] {
            "Saturday,Tuesday",
            "Sunday , Wesdenday",
            "Monday,Thuresday",
            "Friday"});
            this.comboID.Location = new System.Drawing.Point(392, 162);
            this.comboID.Name = "comboID";
            this.comboID.Size = new System.Drawing.Size(210, 24);
            this.comboID.TabIndex = 28;
            this.comboID.SelectedIndexChanged += new System.EventHandler(this.comboID_SelectedIndexChanged);
            // 
            // comboCourse
            // 
            this.comboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCourse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCourse.FormattingEnabled = true;
            this.comboCourse.Location = new System.Drawing.Point(392, 339);
            this.comboCourse.Name = "comboCourse";
            this.comboCourse.Size = new System.Drawing.Size(210, 24);
            this.comboCourse.TabIndex = 30;
            this.comboCourse.SelectedIndexChanged += new System.EventHandler(this.comboCourse_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(151, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Course";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(545, 511);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 28);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmUpdateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 593);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboCourse);
            this.Controls.Add(this.comboID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboClass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboHours);
            this.Controls.Add(this.comboDays);
            this.Controls.Add(this.comboInstructor);
            this.Controls.Add(this.comboLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateGroup";
            this.Text = "Update Group";
            this.Load += new System.EventHandler(this.frmUpdateGroup_Load);
            this.Shown += new System.EventHandler(this.frmUpdateGroup_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboHours;
        private System.Windows.Forms.ComboBox comboDays;
        private System.Windows.Forms.ComboBox comboInstructor;
        private System.Windows.Forms.ComboBox comboLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboID;
        private System.Windows.Forms.ComboBox comboCourse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
    }
}