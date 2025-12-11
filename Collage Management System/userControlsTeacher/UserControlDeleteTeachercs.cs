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
    public partial class UserControlDeleteTeachercs : UserControl
    {
        public UserControlDeleteTeachercs()
        {
            InitializeComponent();
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDeleteTeacher.Text.Trim(), out int id))
            {
                MessageBox.Show("ادخل ايدي صحيح");
                return;
            }

            Database.execute($"DELETE FROM teachers WHERE id = {id}");
            MessageBox.Show("تم حذف الاستاذ بنجاح ");
        }
    }
}
