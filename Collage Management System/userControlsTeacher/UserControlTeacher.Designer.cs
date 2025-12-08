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
            this.dataGradeViewTeachers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGradeViewTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "رقم الهاتف";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "المقرر";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "الراتب";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "الدرجة الوضيفية";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "الاسم الكامل";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "الرقم الوضيفي";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // dataGradeViewTeachers
            // 
            this.dataGradeViewTeachers.AllowUserToAddRows = false;
            this.dataGradeViewTeachers.AllowUserToDeleteRows = false;
            this.dataGradeViewTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGradeViewTeachers.BackgroundColor = System.Drawing.Color.White;
            this.dataGradeViewTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGradeViewTeachers.ColumnHeadersHeight = 40;
            this.dataGradeViewTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.colName,
            this.Column1,
            this.Column3,
            this.Column2,
            this.colPhone});
            this.dataGradeViewTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGradeViewTeachers.Location = new System.Drawing.Point(0, 0);
            this.dataGradeViewTeachers.Margin = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.dataGradeViewTeachers.Name = "dataGradeViewTeachers";
            this.dataGradeViewTeachers.ReadOnly = true;
            this.dataGradeViewTeachers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGradeViewTeachers.RowHeadersVisible = false;
            this.dataGradeViewTeachers.RowHeadersWidth = 51;
            this.dataGradeViewTeachers.RowTemplate.Height = 35;
            this.dataGradeViewTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGradeViewTeachers.Size = new System.Drawing.Size(1559, 769);
            this.dataGradeViewTeachers.TabIndex = 5;
            this.dataGradeViewTeachers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGradeViewStudents_CellContentClick_1);
            // 
            // UserControlTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGradeViewTeachers);
            this.Name = "UserControlTeacher";
            this.Size = new System.Drawing.Size(1559, 769);
            ((System.ComponentModel.ISupportInitialize)(this.dataGradeViewTeachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridView dataGradeViewTeachers;
    }
}
