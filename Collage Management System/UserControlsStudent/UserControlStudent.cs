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
    public partial class UserControlStudent : UserControl
    {
        public UserControlStudent()
        {
            InitializeComponent();
            showUserControls(new UserControlsStudent.UserControlCreate());
        }

        private void dataGradeViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlStudent_Load(object sender, EventArgs e)
        {

        }
        private void showUserControls(UserControl Us)
        {
            panelshow.Controls.Clear();
            panelshow.Controls.Add(Us);
            Us.Dock = DockStyle.Fill;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
       showUserControls( new UserControlsStudent.UserControlDelete());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            showUserControls(new UserControlsStudent.UserControlUpdate());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            showUserControls(new UserControlsStudent.UserControlCreate());
        }
    }
}
