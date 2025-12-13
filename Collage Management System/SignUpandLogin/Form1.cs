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
            UIHelper.MakeButtonsRounded(this, 4);
            UIHelper.MakeTextBoxRounded(this, 4);

            // new Database().initDatabase();
           
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateAccounPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPassLogin.Text == "123" && textBoxUserNameLogin.Text == "moh")
            {
                new MainForm().Show();
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
