using Collage_Management_System.usercontrolCourse;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fahrs
{
    public partial class ucCourses : UserControl
    {
        public ucCourses()
        {
            InitializeComponent();
            showUserControl(new UserControlAddCourse());
        
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            showUserControl(new UserControlAddCourse());
        }



        public void showUserControl(UserControl us)
        {
           
            us.Dock = DockStyle.Fill;
            panelShowUsCourse.Controls.Clear();
            panelShowUsCourse.Controls.Add(us);
        }

 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            showUserControl(new UserControlUpdateCourse());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            showUserControl(new UserControlDeleteCourse());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
             
        }

        private void panelShowUsCourse_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
