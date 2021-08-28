namespace Eng1
{
    partial class frmDeleteCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteCourse));
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboCourseNameDel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(41, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Course Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(219, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboCourseNameDel
            // 
            this.comboCourseNameDel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCourseNameDel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboCourseNameDel.FormattingEnabled = true;
            this.comboCourseNameDel.Location = new System.Drawing.Point(219, 88);
            this.comboCourseNameDel.Name = "comboCourseNameDel";
            this.comboCourseNameDel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboCourseNameDel.Size = new System.Drawing.Size(168, 24);
            this.comboCourseNameDel.TabIndex = 35;
            this.comboCourseNameDel.SelectedIndexChanged += new System.EventHandler(this.comboCourseNameDel_SelectedIndexChanged);
            // 
            // frmDeleteCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 243);
            this.Controls.Add(this.comboCourseNameDel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Name = "frmDeleteCourse";
            this.Text = "Delete Course";
            this.Load += new System.EventHandler(this.frmDeleteCourse_Load);
            this.Shown += new System.EventHandler(this.frmDeleteCourse_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboCourseNameDel;
    }
}