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
            this.CreateAccounPanel = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCnfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelRememberPass = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassLogin = new System.Windows.Forms.TextBox();
            this.textBoxUserNameLogin = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            this.CreateAccounPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.CreateAccounPanel);
            this.loginPanel.Controls.Add(this.linkLabelRememberPass);
            this.loginPanel.Controls.Add(this.linkLabel1);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.label4);
            this.loginPanel.Controls.Add(this.buttonLogin);
            this.loginPanel.Controls.Add(this.textBoxPassLogin);
            this.loginPanel.Controls.Add(this.textBoxUserNameLogin);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(564, 659);
            this.loginPanel.TabIndex = 0;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
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
            this.CreateAccounPanel.Controls.Add(this.label2);
            this.CreateAccounPanel.Location = new System.Drawing.Point(4, 4);
            this.CreateAccounPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateAccounPanel.Name = "CreateAccounPanel";
            this.CreateAccounPanel.Size = new System.Drawing.Size(564, 659);
            this.CreateAccounPanel.TabIndex = 24;
            this.CreateAccounPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CreateAccounPanel_Paint_2);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(55, 598);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(110, 19);
            this.linkLabel2.TabIndex = 42;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "تسجيل الدخول";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(418, 285);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "كلمة المرور";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(383, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "البريد الاكتروني";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(373, 395);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 19);
            this.label9.TabIndex = 41;
            this.label9.Text = "تأكيد كلمة المرور";
            // 
            // textBoxCnfirmPassword
            // 
            this.textBoxCnfirmPassword.Location = new System.Drawing.Point(27, 430);
            this.textBoxCnfirmPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxCnfirmPassword.Multiline = true;
            this.textBoxCnfirmPassword.Name = "textBoxCnfirmPassword";
            this.textBoxCnfirmPassword.PasswordChar = '*';
            this.textBoxCnfirmPassword.Size = new System.Drawing.Size(494, 40);
            this.textBoxCnfirmPassword.TabIndex = 40;
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.Location = new System.Drawing.Point(27, 323);
            this.textBoxPassWord.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxPassWord.Multiline = true;
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.Size = new System.Drawing.Size(494, 40);
            this.textBoxPassWord.TabIndex = 39;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(27, 226);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(494, 36);
            this.textBoxEmail.TabIndex = 38;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(28, 114);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxUserName.Multiline = true;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(494, 40);
            this.textBoxUserName.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.button2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(28, 517);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(495, 55);
            this.button2.TabIndex = 34;
            this.button2.Text = "إنشاء حساب";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(383, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "اسم المستخدم";
            // 
            // linkLabelRememberPass
            // 
            this.linkLabelRememberPass.AutoSize = true;
            this.linkLabelRememberPass.Location = new System.Drawing.Point(329, 598);
            this.linkLabelRememberPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelRememberPass.Name = "linkLabelRememberPass";
            this.linkLabelRememberPass.Size = new System.Drawing.Size(141, 19);
            this.linkLabelRememberPass.TabIndex = 23;
            this.linkLabelRememberPass.TabStop = true;
            this.linkLabelRememberPass.Text = "نسيت كلمة المرور؟";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(30, 598);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 19);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "إنشاء حساب جديد";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(423, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "كلمة المرور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(388, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "اسم المستخدم";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogin.Location = new System.Drawing.Point(27, 514);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(495, 55);
            this.buttonLogin.TabIndex = 19;
            this.buttonLogin.Text = "تسجيل الدخول";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassLogin
            // 
            this.textBoxPassLogin.Location = new System.Drawing.Point(32, 267);
            this.textBoxPassLogin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxPassLogin.Multiline = true;
            this.textBoxPassLogin.Name = "textBoxPassLogin";
            this.textBoxPassLogin.PasswordChar = '*';
            this.textBoxPassLogin.Size = new System.Drawing.Size(494, 37);
            this.textBoxPassLogin.TabIndex = 18;
            // 
            // textBoxUserNameLogin
            // 
            this.textBoxUserNameLogin.Location = new System.Drawing.Point(32, 179);
            this.textBoxUserNameLogin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxUserNameLogin.Multiline = true;
            this.textBoxUserNameLogin.Name = "textBoxUserNameLogin";
            this.textBoxUserNameLogin.Size = new System.Drawing.Size(494, 40);
            this.textBoxUserNameLogin.TabIndex = 17;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 659);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelRememberPass;



    }
}

