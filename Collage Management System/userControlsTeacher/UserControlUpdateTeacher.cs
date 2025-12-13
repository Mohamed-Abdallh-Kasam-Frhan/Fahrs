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
    public partial class UserControlUpdateTeacher : UserControl
    {
        public UserControlUpdateTeacher()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            var courses = Database.query("SELECT name FROM cources");
            textBoxCourse.Items.Clear();

            foreach (DataRow row in courses.Rows)
            {
                textBoxCourse.Items.Add(row["name"].ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
            private void btnEditTeacher_Click(object sender, EventArgs e)
        {

            string idStr = textBoxTeacherUpdated.Text.Trim();
            string name = textBoxNameTeacher.Text.Trim();
            string phone = textBoxPhoneTeacher.Text.Trim();
            string subject = textBoxCourse.SelectedItem?.ToString() ?? "";
            string degree = textBoxJopGrade.Text.Trim();
            string salary = textBoxSalary.Text.Trim();

            if (!int.TryParse(idStr, out int id) || id <= 0)
            {
                MessageBox.Show("❌ الرجاء إدخال رقم ID صحيح.");
                return;
            }

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(degree) ||
                string.IsNullOrEmpty(salary))
            {
                MessageBox.Show("❌ يرجى تعبئة جميع الحقول.");
                return;
            }

            Database.execute(
                $"UPDATE teachers SET name='{name}', phone='{phone}', subject='{subject}', degree='{degree}', salary='{salary}' WHERE id={id}"
            );

            MessageBox.Show("✔️ تم تحديث بيانات الأستاذ بنجاح.");
        }
    }
}
