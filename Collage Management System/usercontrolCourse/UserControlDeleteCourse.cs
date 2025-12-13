using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collage_Management_System.usercontrolCourse
{
    public partial class UserControlDeleteCourse : UserControl
    {
        public UserControlDeleteCourse()
        {
            InitializeComponent();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            string name = textBoxDeleteCourse.Text.Trim();

            Database.execute($"DELETE FROM cources WHERE name = '{name}'");
            MessageBox.Show("تم حذف المقرر بنجاح ");
        }
    }
}
