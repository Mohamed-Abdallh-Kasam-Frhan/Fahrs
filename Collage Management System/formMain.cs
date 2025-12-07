using Collage_Management_System;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Collage_Management_System.userControlsTeacher;
using Collage_Management_System.UserControlsStudent;
using Collage_Management_System.usercontrolCourse;
//using Fahrs;
 using System.Collections.Generic;
namespace Fahrs
{
    public partial class frmMainDashboard : Form
    {
    //    private Panel selectedMenuPanel = null;
        private int EntityNumber;
       
        public frmMainDashboard()
        {
            InitializeComponent();
            new Database().initDatabase();
            showUserControl(new UserControlStudent());
            showUserUp_De_Ad(new UserControlCreate());
        }

     
     

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

       

        private void panelMainContent_Paint(object sender, EventArgs e)
        {

         
        }


        public void showUserControl(UserControl us)
        {
      //      panelMainContent.Controls.Clear();
            us.Dock = DockStyle.Fill;
            panelMainContent.Controls.Clear();
            panelMainContent.Controls.Add(us);
        }


        public void showUserUp_De_Ad(UserControl us)
        {
            //      panelMainContent.Controls.Clear();
            us.Dock = DockStyle.Fill;
            panelshow.Controls.Clear();
            panelshow.Controls.Add(us);
        }

       


        private void button10_Click(object sender, EventArgs e)

        {
            lblTitle.Text = "👨‍🎓  إدارة الطلاب";
            showUserControl(new UserControlStudent());
            EntityNumber = 1;
            showUserUp_De_Ad(new UserControlCreate());
            panelSelectLevelAndMaijor.Visible = true;
            buttonPayment.Visible = true;
        }
        


        private void button6_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("هل أنت متأكد من تسجيل الخروج؟", "تسجيل الخروج",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                loginForm loginForm = new loginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)

        {
            lblTitle.Text = " 👨‍🎓  إدارة المدرسين";
            showUserControl(new UserControlTeacher());
            EntityNumber = 2;
            showUserUp_De_Ad(new UserControlCreateTecher());
            panelSelectLevelAndMaijor.Visible = false;
            buttonPayment.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)

        {
            lblTitle.Text = "📚  إدارة المقررات";
            showUserControl(new ucCourses());
            EntityNumber = 3;
            showUserUp_De_Ad(new UserControlAddCourse());
            panelSelectLevelAndMaijor.Visible = false;
            buttonPayment.Visible = false;
        }

        private void panelMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             

            switch (EntityNumber)
            {
                case 1:
                    showUserUp_De_Ad(new UserControlDelete());
                    break;
                case 2:
                    showUserUp_De_Ad(new  UserControlDeleteTeachercs());
                    break;
                case 3:
                    showUserUp_De_Ad(new UserControlDeleteCourse());
                    break;
                default :
                    showUserUp_De_Ad(new UserControlDelete());
                    break;
                    

            }
        } 

       
        private void btnEdit_Click(object sender, EventArgs e)
        {


            switch (EntityNumber)
            {
                case 1:
                    showUserUp_De_Ad(new UserControlUpdate());
                    break;
                case 2:
                    showUserUp_De_Ad(new UserControlUpdateTeacher());
                    break;
                case 3:
                    showUserUp_De_Ad(new UserControlUpdateCourse());
                    break;
                default :
                    showUserUp_De_Ad(new UserControlUpdate());
                    break;

            }
        }

        private void panelshow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            switch (EntityNumber)
            {
                case 1:
                    showUserUp_De_Ad(new UserControlCreate());
                    break;
                case 2:
                    showUserUp_De_Ad(new UserControlCreateTecher());
                    break;
                case 3:
                    showUserUp_De_Ad(new UserControlAddCourse());
                    break;
                default :
                    showUserUp_De_Ad(new UserControlCreate());
                    break;
            }
        }

        private void panalActions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSelectLevelAndMaijor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
        showUserUp_De_Ad(new UserControPayment());
        }

        private void frmMainDashboard_Load(object sender, EventArgs e)
        {
             
        }
    }
        }

       
    

