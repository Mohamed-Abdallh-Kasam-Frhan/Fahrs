using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collage_Management_System.UserControlsStudent
{
    public partial class UserControlDelete : UserControl
    {
        public UserControlDelete()
        {
            InitializeComponent();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBoxDeleteStudent.Text.Trim(), out int id))
            {
                MessageBox.Show("ادخل ايدي صحيح");
                return;
            }

            Database.execute($"DELETE FROM students WHERE id = {id}");
            MessageBox.Show("تم حذف الطالب بنجاح ");
        }
    }
}
