namespace Collage_Management_System.usercontrolCourse
{
    partial class UserControlDeleteCourse
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
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.textBoxDeleteCourse = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeleteCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCourse.FlatAppearance.BorderSize = 0;
            this.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCourse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCourse.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCourse.Location = new System.Drawing.Point(52, 257);
            this.btnDeleteCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(236, 38);
            this.btnDeleteCourse.TabIndex = 58;
            this.btnDeleteCourse.Text = "🗑 حذف";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            // 
            // textBoxDeleteCourse
            // 
            this.textBoxDeleteCourse.Location = new System.Drawing.Point(52, 158);
            this.textBoxDeleteCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDeleteCourse.Multiline = true;
            this.textBoxDeleteCourse.Name = "textBoxDeleteCourse";
            this.textBoxDeleteCourse.Size = new System.Drawing.Size(236, 31);
            this.textBoxDeleteCourse.TabIndex = 57;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(361, 74);
            this.lblTitle.TabIndex = 95;
            this.lblTitle.Text = "📚  حذف مقرر";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlDeleteCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.textBoxDeleteCourse);
            this.Name = "UserControlDeleteCourse";
            this.Size = new System.Drawing.Size(361, 711);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.TextBox textBoxDeleteCourse;
        private System.Windows.Forms.Label lblTitle;
    }
}
