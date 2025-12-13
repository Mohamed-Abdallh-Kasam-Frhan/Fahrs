using Collage_Management_System;
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
            dgvCourses.Columns.Clear();
            dgvCourses.DataSource = Database.query("SELECT * FROM cources");

            dgvCourses.Columns["name"].HeaderText = "الاسم";
            dgvCourses.Columns["department"].HeaderText = "التخصص";
            dgvCourses.Columns["teacher"].HeaderText = "استاذ المقرر";
            dgvCourses.Columns["level"].HeaderText = "المستوى";
            dgvCourses.Columns["hour"].HeaderText = "الساعات المعتمدة";
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

        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
