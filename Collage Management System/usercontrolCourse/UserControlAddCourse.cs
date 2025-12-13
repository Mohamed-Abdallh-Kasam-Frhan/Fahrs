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
    public partial class UserControlAddCourse : UserControl
    {
        public UserControlAddCourse()
        {
            InitializeComponent();
            var majors = Database.query("SELECT name FROM majors");
            comboBoxDepartment.DataSource = majors;
            comboBoxDepartment.ValueMember = "name";
            comboBoxDepartment.DisplayMember = "name";
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string name = textBoxNameCourse.Text.Trim();
            object dep = comboBoxDepartment.Text.Trim();
            object level = comboBoxLevel.Text.Trim();
            string teacher = textBoxTeacher.Text.Trim();
            string hourStr = textBoxHour.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("❌ الرجاء إدخال اسم المقرر.");
                return;
            }

            if (dep == null)
            {
                MessageBox.Show("❌ الرجاء اختيار القسم.");
                return;
            }

            if (level == null)
            {
                MessageBox.Show("❌ الرجاء اختيار المستوى.");
                return;
            }

            if (string.IsNullOrEmpty(teacher))
            {
                MessageBox.Show("❌ الرجاء إدخال اسم المدرّس.");
                return;
            }

            if (!int.TryParse(hourStr, out int hours) || hours <= 0)
            {
                MessageBox.Show("❌ الرجاء إدخال عدد ساعات صحيح (رقم موجب).");
                return;
            }

            Database.execute(
                $"INSERT INTO cources VALUES ('{name}', '{dep}', '{level}', '{teacher}', {hours})"
            );

            MessageBox.Show("✔️ تم إضافة المقرر بنجاح.");

            textBoxNameCourse.Clear();
            textBoxTeacher.Clear();
            textBoxHour.Clear();
            comboBoxDepartment.SelectedIndex = -1;
            comboBoxLevel.SelectedIndex = -1;
        }

    }
}
