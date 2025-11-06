using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collage_Management_System
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            ChangePanelToLoginMode();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePanelToCreateMode();
        }


        private void ChangePanelToCreateMode()
        {
            loginPanel.Visible = true;
            CreateAccounPanel.Visible = true;
            this.Text = "إنشاء حساب";
        }


        private void ChangePanelToLoginMode()
        {
            CreateAccounPanel.Visible = false;
            loginPanel.Visible = true;
            this.Text = "تسجيل الدحول";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUserNameLogin.Text == "moh" && textBoxPassLogin.Text == "123")
            {
                mainForm mainFormShow = new mainForm();
                mainFormShow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("خطأ في إسم المستخدم او كلمة المرور ", "خطأ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePanelToLoginMode();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePanelToLoginMode();
        }
    }
}
