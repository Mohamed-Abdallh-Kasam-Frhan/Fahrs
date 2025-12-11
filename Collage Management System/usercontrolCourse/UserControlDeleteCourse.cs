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
            if (!int.TryParse(textBoxDeleteCourse.Text.Trim(), out int id))
            {
                MessageBox.Show("ادخل ايدي صحيح");
                return;
            }

            Database.execute($"DELETE FROM cources WHERE id = {id}");
            MessageBox.Show("تم حذف المقرر بنجاح ");
        }
    }
}
