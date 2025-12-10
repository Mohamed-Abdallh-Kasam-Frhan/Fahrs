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
            string inputId = textBoxIdTeacher.Text.Trim();
            string name = textBoxNameTeacher.Text.Trim();
            string phone = textBoxPhoneTeacher.Text.Trim();
            string course = textBoxCourse.Text.Trim();
            string jobGrade = textBoxJopGrade.Text.Trim();
            string salary = textBoxSalary.Text.Trim();

            if (!int.TryParse(inputId, out int id) || id <= 0)
            {
                MessageBox.Show("❌ الرجاء إدخال رقم ID صحيح (رقم موجب فقط).");
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("❌ الرجاء إدخال اسم المعلم.");
                return;
            }

            if (string.IsNullOrEmpty(phone) || phone.Length < 7)
            {
                MessageBox.Show("❌ الرجاء إدخال رقم هاتف صحيح.");
                return;
            }

            if (string.IsNullOrEmpty(course))
            {
                MessageBox.Show("❌ الرجاء إدخال اسم المقرر.");
                return;
            }

            if (string.IsNullOrEmpty(jobGrade))
            {
                MessageBox.Show("❌ الرجاء إدخال الدرجة الوظيفية.");
                return;
            }

            if (!decimal.TryParse(salary, out decimal salaryValue) || salaryValue <= 0)
            {
                MessageBox.Show("❌ الرجاء إدخال راتب صحيح (رقم موجب فقط).");
                return;
            }

            Database.execute(
                $"INSERT INTO teachers VALUES ({id}, '{name}', '{phone}', '{course}', '{jobGrade}', '{salaryValue}')"
            );

            MessageBox.Show("✔️ تم إضافة المعلم بنجاح.");
        }

    }
}
