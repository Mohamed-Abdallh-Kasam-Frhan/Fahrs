namespace Fahrs
{
    partial class ucCourses
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.BackgroundColor = System.Drawing.Color.White;
            this.dgvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCourses.ColumnHeadersHeight = 40;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colTeacher,
            this.Column2,
            this.colLevel,
            this.colHours});
            this.dgvCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourses.Location = new System.Drawing.Point(0, 0);
            this.dgvCourses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.RowTemplate.Height = 35;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(1167, 788);
            this.dgvCourses.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "إسم المقرر";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // colTeacher
            // 
            this.colTeacher.HeaderText = "الأستاذ المحاضر";
            this.colTeacher.Name = "colTeacher";
            this.colTeacher.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "التخصصات";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // colLevel
            // 
            this.colLevel.HeaderText = "المستوى";
            this.colLevel.Name = "colLevel";
            this.colLevel.ReadOnly = true;
            // 
            // colHours
            // 
            this.colHours.HeaderText = "الساعات المعتمدة";
            this.colHours.Name = "colHours";
            this.colHours.ReadOnly = true;
            // 
            // ucCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.dgvCourses);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucCourses";
            this.Size = new System.Drawing.Size(1167, 788);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHours;
    }
}
