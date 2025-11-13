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
            init();
        }

        Dictionary<string, int> majors = new Dictionary<string, int>();

        private void init()
            
        {

      
            if(majors.Count == 0)
            {
                majors.Add("هندسة البرمجيات", 4);
                majors.Add("تقنية معلومات", 4);
                majors.Add("شبكات وامن سيبراني", 4);
                majors.Add("اتصالات", 5);
                majors.Add("ميكاترونكس", 5);
                majors.Add("ذكاء اصطناعي", 4);
                majors.Add("طاقة متجددة", 4);
                 ComboxDebartment.Items.AddRange(majors.Keys.ToArray());
            }
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
                Fahrs.frmMainDashboard mainFormShow = new Fahrs.frmMainDashboard();
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
 

        private void ComboxDebartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            var key = ComboxDebartment.SelectedItem.ToString();
            int levels = majors[key];
            List<string> list = new List<string>();
            var LevelsNames = new string[] {"اول", "ثاني", "ثالث", "رابع", "خامس"};
            for(int i = 0; i < levels; i++)
            {
                list.Add(LevelsNames[i]);
            }
            comboBoxLevel.Items.Clear();
            comboBoxLevel.Items.AddRange(list.ToArray());
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

 

    }
}
