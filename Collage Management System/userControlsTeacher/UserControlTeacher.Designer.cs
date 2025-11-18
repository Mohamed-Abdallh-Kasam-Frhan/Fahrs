namespace Collage_Management_System
{
    partial class UserControlTeacher
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
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGradeViewStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGradeViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "رقم الهاتف";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "المقرر";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "الراتب";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "الدرجة الوضيفية";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "الاسم الكامل";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "الرقم الوضيفي";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
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
            this.Id,
            this.colName,
            this.Column1,
            this.Column3,
            this.Column2,
            this.colPhone});
            this.dataGradeViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGradeViewStudents.Location = new System.Drawing.Point(0, 0);
            this.dataGradeViewStudents.Margin = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.dataGradeViewStudents.Name = "dataGradeViewStudents";
            this.dataGradeViewStudents.ReadOnly = true;
            this.dataGradeViewStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGradeViewStudents.RowHeadersVisible = false;
            this.dataGradeViewStudents.RowTemplate.Height = 35;
            this.dataGradeViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGradeViewStudents.Size = new System.Drawing.Size(1559, 769);
            this.dataGradeViewStudents.TabIndex = 5;
            // 
            // UserControlTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGradeViewStudents);
            this.Name = "UserControlTeacher";
            this.Size = new System.Drawing.Size(1559, 769);
            ((System.ComponentModel.ISupportInitialize)(this.dataGradeViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridView dataGradeViewStudents;
    }
}
