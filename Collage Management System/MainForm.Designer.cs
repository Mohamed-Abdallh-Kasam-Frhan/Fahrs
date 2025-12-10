using System.Drawing;

namespace Fahrs
{
    partial class MainForm
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
            this.panelMainContentContainer = new System.Windows.Forms.Panel();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panelSelectLevelAndMaijor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLevels = new System.Windows.Forms.ComboBox();
            this.cmbmajors = new System.Windows.Forms.ComboBox();
            this.labelSelectLevel = new System.Windows.Forms.Label();
            this.panelheader = new System.Windows.Forms.Panel();
            this.panelshow = new System.Windows.Forms.Panel();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.panelMainContentContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.panelSelectLevelAndMaijor.SuspendLayout();
            this.panelheader.SuspendLayout();
            this.Wrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainContentContainer
            // 
            this.panelMainContentContainer.BackColor = System.Drawing.SystemColors.Control;
            this.panelMainContentContainer.Controls.Add(this.panelMainContent);
            this.panelMainContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContentContainer.Location = new System.Drawing.Point(300, 97);
            this.panelMainContentContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelMainContentContainer.Name = "panelMainContentContainer";
            this.panelMainContentContainer.Padding = new System.Windows.Forms.Padding(4);
            this.panelMainContentContainer.Size = new System.Drawing.Size(905, 787);
            this.panelMainContentContainer.TabIndex = 2;
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.SystemColors.Control;
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(4, 4);
            this.panelMainContent.Margin = new System.Windows.Forms.Padding(4);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(4);
            this.panelMainContent.Size = new System.Drawing.Size(897, 779);
            this.panelMainContent.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1205, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 787);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 752);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(291, 35);
            this.button6.TabIndex = 20;
            this.button6.Text = "خروج";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnLogout);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DimGray;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(21, 248);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(290, 56);
            this.button5.TabIndex = 19;
            this.button5.Text = "الاعدادات";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(21, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(315, 59);
            this.button2.TabIndex = 16;
            this.button2.Text = "إدارة المقررات";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnSwitchToCourcesPage);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(21, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 62);
            this.button1.TabIndex = 15;
            this.button1.Text = "إدارة المدرسين";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSwitchToTeachersPage);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.DimGray;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.Location = new System.Drawing.Point(21, 35);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(306, 60);
            this.button10.TabIndex = 14;
            this.button10.Text = "إدارة الطلاب";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.btnSwitchToStudentsPage);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1201, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(291, 93);
            this.label1.TabIndex = 1;
            this.label1.Text = "🎓\r\nنظام إدارة الكلية";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.btnDelete);
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.buttonPayment);
            this.pnlHeader.Controls.Add(this.btnAdd);
            this.pnlHeader.Controls.Add(this.btnEdit);
            this.pnlHeader.Location = new System.Drawing.Point(-2, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(35, 25, 35, 25);
            this.pnlHeader.Size = new System.Drawing.Size(1207, 60);
            this.pnlHeader.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Location = new System.Drawing.Point(15, 15);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = " حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1106, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "🔍 بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(829, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(271, 34);
            this.txtSearch.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(356, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(355, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "👨‍🎓  إدارة الطلاب";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.Teal;
            this.buttonPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPayment.FlatAppearance.BorderSize = 0;
            this.buttonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonPayment.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonPayment.Location = new System.Drawing.Point(276, 15);
            this.buttonPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(74, 31);
            this.buttonPayment.TabIndex = 5;
            this.buttonPayment.Text = "تسديد";
            this.buttonPayment.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.Location = new System.Drawing.Point(95, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = " إضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightGray;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.Location = new System.Drawing.Point(175, 15);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 31);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = " تعديل";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panelSelectLevelAndMaijor
            // 
            this.panelSelectLevelAndMaijor.Controls.Add(this.label2);
            this.panelSelectLevelAndMaijor.Controls.Add(this.cmbLevels);
            this.panelSelectLevelAndMaijor.Controls.Add(this.cmbmajors);
            this.panelSelectLevelAndMaijor.Controls.Add(this.labelSelectLevel);
            this.panelSelectLevelAndMaijor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSelectLevelAndMaijor.Location = new System.Drawing.Point(0, 56);
            this.panelSelectLevelAndMaijor.Name = "panelSelectLevelAndMaijor";
            this.panelSelectLevelAndMaijor.Size = new System.Drawing.Size(1201, 37);
            this.panelSelectLevelAndMaijor.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(827, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "تحديد التخصص";
            // 
            // cmbLevels
            // 
            this.cmbLevels.FormattingEnabled = true;
            this.cmbLevels.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbLevels.Location = new System.Drawing.Point(940, 4);
            this.cmbLevels.Name = "cmbLevels";
            this.cmbLevels.Size = new System.Drawing.Size(121, 24);
            this.cmbLevels.TabIndex = 5;
            // 
            // cmbmajors
            // 
            this.cmbmajors.FormattingEnabled = true;
            this.cmbmajors.Items.AddRange(new object[] {
            "SE",
            "IT",
            "CND",
            "AI"});
            this.cmbmajors.Location = new System.Drawing.Point(700, 5);
            this.cmbmajors.Name = "cmbmajors";
            this.cmbmajors.Size = new System.Drawing.Size(121, 24);
            this.cmbmajors.TabIndex = 7;
            // 
            // labelSelectLevel
            // 
            this.labelSelectLevel.AutoSize = true;
            this.labelSelectLevel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectLevel.ForeColor = System.Drawing.Color.Teal;
            this.labelSelectLevel.Location = new System.Drawing.Point(1067, 5);
            this.labelSelectLevel.Name = "labelSelectLevel";
            this.labelSelectLevel.Size = new System.Drawing.Size(100, 16);
            this.labelSelectLevel.TabIndex = 6;
            this.labelSelectLevel.Text = "تحديد المستوى";
            // 
            // panelheader
            // 
            this.panelheader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelheader.Controls.Add(this.panelSelectLevelAndMaijor);
            this.panelheader.Controls.Add(this.label1);
            this.panelheader.Controls.Add(this.pnlHeader);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1496, 97);
            this.panelheader.TabIndex = 3;
            // 
            // panelshow
            // 
            this.panelshow.BackColor = System.Drawing.SystemColors.Control;
            this.panelshow.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelshow.Location = new System.Drawing.Point(0, 97);
            this.panelshow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelshow.Name = "panelshow";
            this.panelshow.Size = new System.Drawing.Size(300, 787);
            this.panelshow.TabIndex = 4;
            // 
            // Wrapper
            // 
            this.Wrapper.Controls.Add(this.panelMainContentContainer);
            this.Wrapper.Controls.Add(this.panel1);
            this.Wrapper.Controls.Add(this.panelshow);
            this.Wrapper.Controls.Add(this.panelheader);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(0, 0);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1496, 884);
            this.Wrapper.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1496, 884);
            this.Controls.Add(this.Wrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام إدارة الكلية - اللوحة الرئيسية";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.panelMainContentContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panelSelectLevelAndMaijor.ResumeLayout(false);
            this.panelSelectLevelAndMaijor.PerformLayout();
            this.panelheader.ResumeLayout(false);
            this.Wrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainContentContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel panelshow;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Panel panelSelectLevelAndMaijor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLevels;
        private System.Windows.Forms.ComboBox cmbmajors;
        private System.Windows.Forms.Label labelSelectLevel;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.Panel Wrapper;
    }
}
