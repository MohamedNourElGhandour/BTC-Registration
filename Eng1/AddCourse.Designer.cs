namespace Eng1
{
    partial class AddCourse
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
            this.txtElseCourse = new System.Windows.Forms.TextBox();
            this.btnStu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtElseCourse
            // 
            this.txtElseCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtElseCourse.Enabled = false;
            this.txtElseCourse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtElseCourse.Location = new System.Drawing.Point(197, 152);
            this.txtElseCourse.Name = "txtElseCourse";
            this.txtElseCourse.Size = new System.Drawing.Size(221, 22);
            this.txtElseCourse.TabIndex = 56;
            // 
            // btnStu
            // 
            this.btnStu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnStu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStu.Location = new System.Drawing.Point(197, 285);
            this.btnStu.Name = "btnStu";
            this.btnStu.Size = new System.Drawing.Size(114, 38);
            this.btnStu.TabIndex = 57;
            this.btnStu.Text = "Enter";
            this.btnStu.UseVisualStyleBackColor = true;
            this.btnStu.Click += new System.EventHandler(this.btnStu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStu);
            this.Controls.Add(this.txtElseCourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElseCourse;
        private System.Windows.Forms.Button btnStu;
        private System.Windows.Forms.Label label1;
    }
}