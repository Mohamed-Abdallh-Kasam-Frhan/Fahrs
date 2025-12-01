using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Collage_Management_System;
 
using Fahrs;
 

namespace Collage_Management_System
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            ChangePanelToLoginMode();
            //new Database().initDatabase();
           
        }
         

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePanelToLoginMode();
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
                Fahrs.frmMainDashboard mainFormShow = new Fahrs.frmMainDashboard();
                mainFormShow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("خطأ في إسم المستخدم او كلمة المرور ", "خطأ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

       


        private void ComboxDebartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CreateAccounPanel_Paint(object sender, PaintEventArgs e)
        {



        }



        
     
     
        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePanelToCreateMode();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             ChangePanelToLoginMode();
        }

        private void CreateAccounPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            frmMainDashboard mainForm = new frmMainDashboard();
            if (textBoxPassLogin.Text == "123" && textBoxUserNameLogin.Text == "moh")
            {
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("إسم المستخدم اوكلمة المرور خطأ","خطأ",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error 
                    );

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
