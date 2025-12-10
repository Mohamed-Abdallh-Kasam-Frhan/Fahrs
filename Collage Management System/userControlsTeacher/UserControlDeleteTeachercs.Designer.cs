namespace Collage_Management_System.userControlsTeacher
{
    partial class UserControlDeleteTeachercs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDeleteTeacher = new System.Windows.Forms.TextBox();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(300, 68);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "👨‍🎓 حذف مدرس";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(119, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "المدرس المراد حذفه";
            // 
            // textBoxDeleteTeacher
            // 
            this.textBoxDeleteTeacher.Location = new System.Drawing.Point(28, 336);
            this.textBoxDeleteTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDeleteTeacher.Multiline = true;
            this.textBoxDeleteTeacher.Name = "textBoxDeleteTeacher";
            this.textBoxDeleteTeacher.Size = new System.Drawing.Size(151, 31);
            this.textBoxDeleteTeacher.TabIndex = 50;
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeleteTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTeacher.FlatAppearance.BorderSize = 0;
            this.btnDeleteTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTeacher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTeacher.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTeacher.Location = new System.Drawing.Point(185, 336);
            this.btnDeleteTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(90, 31);
            this.btnDeleteTeacher.TabIndex = 52;
            this.btnDeleteTeacher.Text = "🗑 حذف";
            this.btnDeleteTeacher.UseVisualStyleBackColor = false;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // UserControlDeleteTeachercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteTeacher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDeleteTeacher);
            this.Controls.Add(this.lblTitle);
            this.Name = "UserControlDeleteTeachercs";
            this.Size = new System.Drawing.Size(300, 730);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDeleteTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
    }
}
