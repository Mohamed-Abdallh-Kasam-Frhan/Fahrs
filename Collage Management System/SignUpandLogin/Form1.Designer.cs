namespace Collage_Management_System
{
    partial class loginForm
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassLogin = new System.Windows.Forms.TextBox();
            this.textBoxUserNameLogin = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CreateAccounPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCnfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.ComboxDebartment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.loginPanel.SuspendLayout();
            this.CreateAccounPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.CreateAccounPanel);
            this.loginPanel.Controls.Add(this.linkLabel1);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.label4);
            this.loginPanel.Controls.Add(this.buttonLogin);
            this.loginPanel.Controls.Add(this.textBoxPassLogin);
            this.loginPanel.Controls.Add(this.textBoxUserNameLogin);
            this.loginPanel.Location = new System.Drawing.Point(2, 1);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(437, 559);
            this.loginPanel.TabIndex = 0;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(329, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "كلمة المرور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(302, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "اسم المستخدم";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Teal;
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogin.Location = new System.Drawing.Point(26, 380);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(385, 46);
            this.buttonLogin.TabIndex = 19;
            this.buttonLogin.Text = "تسجيل الدخول";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // textBoxPassLogin
            // 
            this.textBoxPassLogin.Location = new System.Drawing.Point(25, 225);
            this.textBoxPassLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassLogin.Multiline = true;
            this.textBoxPassLogin.Name = "textBoxPassLogin";
            this.textBoxPassLogin.PasswordChar = '*';
            this.textBoxPassLogin.Size = new System.Drawing.Size(385, 32);
            this.textBoxPassLogin.TabIndex = 18;
            // 
            // textBoxUserNameLogin
            // 
            this.textBoxUserNameLogin.Location = new System.Drawing.Point(25, 151);
            this.textBoxUserNameLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserNameLogin.Multiline = true;
            this.textBoxUserNameLogin.Name = "textBoxUserNameLogin";
            this.textBoxUserNameLogin.Size = new System.Drawing.Size(385, 34);
            this.textBoxUserNameLogin.TabIndex = 17;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(146, 472);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 17);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "إنشاء حساب جديد";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // CreateAccounPanel
            // 
            this.CreateAccounPanel.Controls.Add(this.linkLabel2);
            this.CreateAccounPanel.Controls.Add(this.label7);
            this.CreateAccounPanel.Controls.Add(this.label3);
            this.CreateAccounPanel.Controls.Add(this.label9);
            this.CreateAccounPanel.Controls.Add(this.textBoxCnfirmPassword);
            this.CreateAccounPanel.Controls.Add(this.textBoxPassWord);
            this.CreateAccounPanel.Controls.Add(this.textBoxEmail);
            this.CreateAccounPanel.Controls.Add(this.textBoxUserName);
            this.CreateAccounPanel.Controls.Add(this.button2);
            this.CreateAccounPanel.Controls.Add(this.comboBoxLevel);
            this.CreateAccounPanel.Controls.Add(this.ComboxDebartment);
            this.CreateAccounPanel.Controls.Add(this.label8);
            this.CreateAccounPanel.Controls.Add(this.label5);
            this.CreateAccounPanel.Controls.Add(this.label2);
            this.CreateAccounPanel.Location = new System.Drawing.Point(3, 0);
            this.CreateAccounPanel.Name = "CreateAccounPanel";
            this.CreateAccounPanel.Size = new System.Drawing.Size(431, 556);
            this.CreateAccounPanel.TabIndex = 23;
            this.CreateAccounPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CreateAccounPanel_Paint_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(325, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "كلمة المرور";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(298, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "البريد الاكتروني";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(290, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "تأكيد كلمة المرور";
            // 
            // textBoxCnfirmPassword
            // 
            this.textBoxCnfirmPassword.Location = new System.Drawing.Point(21, 381);
            this.textBoxCnfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCnfirmPassword.Multiline = true;
            this.textBoxCnfirmPassword.Name = "textBoxCnfirmPassword";
            this.textBoxCnfirmPassword.PasswordChar = '*';
            this.textBoxCnfirmPassword.Size = new System.Drawing.Size(385, 34);
            this.textBoxCnfirmPassword.TabIndex = 40;
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Location = new System.Drawing.Point(21, 287);
            this.textBoxPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassWord.Multiline = true;
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.Size = new System.Drawing.Size(385, 34);
            this.textBoxPassWord.TabIndex = 39;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(21, 218);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(385, 31);
            this.textBoxEmail.TabIndex = 38;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(21, 141);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserName.Multiline = true;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(385, 34);
            this.textBoxUserName.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(22, 435);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(385, 46);
            this.button2.TabIndex = 34;
            this.button2.Text = "إنشاء حساب";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Location = new System.Drawing.Point(25, 72);
            this.comboBoxLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(95, 24);
            this.comboBoxLevel.TabIndex = 33;
            // 
            // ComboxDebartment
            // 
            this.ComboxDebartment.FormattingEnabled = true;
            this.ComboxDebartment.Location = new System.Drawing.Point(214, 72);
            this.ComboxDebartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboxDebartment.Name = "ComboxDebartment";
            this.ComboxDebartment.Size = new System.Drawing.Size(121, 24);
            this.ComboxDebartment.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(126, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "المستوى";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(342, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "التخصص";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(298, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "اسم المستخدم";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(163, 504);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(95, 17);
            this.linkLabel2.TabIndex = 42;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "تسجيل الدخول";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 561);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.CreateAccounPanel.ResumeLayout(false);
            this.CreateAccounPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassLogin;
        private System.Windows.Forms.TextBox textBoxUserNameLogin;
        private System.Windows.Forms.Panel CreateAccounPanel;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCnfirmPassword;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.ComboBox ComboxDebartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;



    }
}

