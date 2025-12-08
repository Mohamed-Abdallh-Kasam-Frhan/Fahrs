namespace Collage_Management_System.UserControlsStudent
{
    partial class UserControlDelete
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
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.textBoxDeleteStudent = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStudent.FlatAppearance.BorderSize = 0;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.Location = new System.Drawing.Point(29, 256);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(236, 38);
            this.btnDeleteStudent.TabIndex = 55;
            this.btnDeleteStudent.Text = "🗑 حذف";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            // 
            // textBoxDeleteStudent
            // 
            this.textBoxDeleteStudent.Location = new System.Drawing.Point(29, 161);
            this.textBoxDeleteStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDeleteStudent.Multiline = true;
            this.textBoxDeleteStudent.Name = "textBoxDeleteStudent";
            this.textBoxDeleteStudent.Size = new System.Drawing.Size(236, 31);
            this.textBoxDeleteStudent.TabIndex = 54;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(321, 68);
            this.lblTitle.TabIndex = 53;
            this.lblTitle.Text = "👨‍🎓 حذف طالب";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.textBoxDeleteStudent);
            this.Controls.Add(this.lblTitle);
            this.Name = "UserControlDelete";
            this.Size = new System.Drawing.Size(321, 681);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.TextBox textBoxDeleteStudent;
        private System.Windows.Forms.Label lblTitle;
    }
}
