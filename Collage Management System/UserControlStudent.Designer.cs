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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panalActions = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.colGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGradeViewStudents = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.panalActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGradeViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(35, 25, 35, 25);
            this.pnlHeader.Size = new System.Drawing.Size(916, 98);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitle.Location = new System.Drawing.Point(35, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(846, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "👨‍🎓  إدارة الطلاب";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panalActions
            // 
            this.panalActions.BackColor = System.Drawing.Color.White;
            this.panalActions.Controls.Add(this.btnSearch);
            this.panalActions.Controls.Add(this.txtSearch);
            this.panalActions.Controls.Add(this.btnDelete);
            this.panalActions.Controls.Add(this.btnEdit);
            this.panalActions.Controls.Add(this.btnAdd);
            this.panalActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panalActions.Location = new System.Drawing.Point(0, 98);
            this.panalActions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panalActions.Name = "panalActions";
            this.panalActions.Padding = new System.Windows.Forms.Padding(35, 18, 35, 18);
            this.panalActions.Size = new System.Drawing.Size(916, 98);
            this.panalActions.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(414, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 49);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "🔍 بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(542, 27);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(338, 34);
            this.txtSearch.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(280, 25);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 49);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "🗑 حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(152, 25);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 49);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "✏ تعديل";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(23, 25);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 49);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "➕ إضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // colGrade
            // 
            this.colGrade.HeaderText = "التقدير";
            this.colGrade.Name = "colGrade";
            this.colGrade.ReadOnly = true;
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
            // colID
            // 
            this.colID.HeaderText = "الرقم الجامعي";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
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
            this.colID,
            this.colName,
            this.colMajor,
            this.colLevel,
            this.colPhone,
            this.colGrade});
            this.dataGradeViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGradeViewStudents.Location = new System.Drawing.Point(0, 196);
            this.dataGradeViewStudents.Margin = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.dataGradeViewStudents.Name = "dataGradeViewStudents";
            this.dataGradeViewStudents.ReadOnly = true;
            this.dataGradeViewStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGradeViewStudents.RowHeadersVisible = false;
            this.dataGradeViewStudents.RowTemplate.Height = 35;
            this.dataGradeViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGradeViewStudents.Size = new System.Drawing.Size(916, 528);
            this.dataGradeViewStudents.TabIndex = 3;
            // 
            // UserControlStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGradeViewStudents);
            this.Controls.Add(this.panalActions);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UserControlStudent";
            this.Size = new System.Drawing.Size(916, 724);
            this.pnlHeader.ResumeLayout(false);
            this.panalActions.ResumeLayout(false);
            this.panalActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGradeViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panalActions;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridView dataGradeViewStudents;
    }
}
