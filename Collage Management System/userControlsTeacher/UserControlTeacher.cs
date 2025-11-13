using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collage_Management_System
{
    public partial class UserControlTeacher : UserControl
    {
        public UserControlTeacher()
        {
            InitializeComponent();
            showUserControl(new userControlsTeacher.UserControlCreateTecher());
        }

        private void dataGradeViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void showUserControl(UserControl us)
        {
            //      panelMainContent.Controls.Clear();
            us.Dock = DockStyle.Fill;
            panelAdd_Updae_delete_Techear.Controls.Clear();
            panelAdd_Updae_delete_Techear.Controls.Add(us);
        }


        private void panelAdd_Updae_delete_Techear_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            showUserControl(new userControlsTeacher.UserControlCreateTecher());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            showUserControl(new userControlsTeacher.UserControlUpdateTeacher());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            showUserControl(new userControlsTeacher.UserControlDeleteTeachercs());
        }
    }
}
