namespace Collage_Management_System
{
    partial class UserControlStudent
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
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGradeViewStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGradeViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // Column3
            // 
            this.Column3.HeaderText = "الحالة";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "رقم الهاتف";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colLevel
            // 
            this.colLevel.HeaderText = "المستوى";
            this.colLevel.Name = "colLevel";
            this.colLevel.ReadOnly = true;
            // 
            // colMajor
            // 
            this.colMajor.HeaderText = "التخصص";
            this.colMajor.Name = "colMajor";
            this.colMajor.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "الاسم الكامل";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "الرقم الاكاديمي";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dataGradeViewStudents
            // 
            this.dataGradeViewStudents.AllowUserToAddRows = false;
            this.dataGradeViewStudents.AllowUserToDeleteRows = false;
            this.dataGradeViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGradeViewStudents.BackgroundColor = System.Drawing.Color.White;
            this.dataGradeViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGradeViewStudents.ColumnHeadersHeight = 40;
            this.dataGradeViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.colName,
            this.colMajor,
            this.colLevel,
            this.colPhone,
            this.Column3});
            this.dataGradeViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGradeViewStudents.Location = new System.Drawing.Point(0, 0);
            this.dataGradeViewStudents.Margin = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.dataGradeViewStudents.Name = "dataGradeViewStudents";
            this.dataGradeViewStudents.ReadOnly = true;
            this.dataGradeViewStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGradeViewStudents.RowHeadersVisible = false;
            this.dataGradeViewStudents.RowTemplate.Height = 35;
            this.dataGradeViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGradeViewStudents.Size = new System.Drawing.Size(916, 778);
            this.dataGradeViewStudents.TabIndex = 4;
            // 
            // UserControlStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGradeViewStudents);
            this.Name = "UserControlStudent";
            this.Size = new System.Drawing.Size(916, 778);
            this.Load += new System.EventHandler(this.UserControlStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGradeViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dataGradeViewStudents;
    }
}
