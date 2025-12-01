using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collage_Management_System.userControlsTeacher
{
    public partial class UserControlCreateTecher : UserControl
    {
        public UserControlCreateTecher()
        {
            InitializeComponent();
        }
        
        private void UserControlCreateTecher_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            var id = textBoxIdTeacher.Text;
            var name = textBoxNameTeacher.Text;
            var phone = textBoxPhoneTeacher.Text;
            var cource = textBoxCourse.Text;
            var jobGrade = textBoxJopGrade.Text;
            var salary = textBoxSalary.Text;

            Database.execute($"INSERT INTO teachers VALUES ({id}, '{name}', '{phone}', '{cource}', '{jobGrade}', '{salary}')");
        }
    }
}
