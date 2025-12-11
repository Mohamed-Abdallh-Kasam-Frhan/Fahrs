using System;
using System.Data;
using System.Windows.Forms;

namespace Collage_Management_System.usercontrolCourse
{
    public partial class UserControlUpdateCourse : UserControl
    {
        public UserControlUpdateCourse()
        {
            InitializeComponent();
            var majors = Database.query("SELECT * FROM majors");
            comboBoxDepartment.DataSource = majors;
            comboBoxDepartment.ValueMember = "id";
            comboBoxDepartment.DisplayMember = "name";

            loadCourses();
        }

        // 📌 زر تعديل بيانات المقرر
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = textBoxNameCourse.Text.Trim();
            string dept = comboBoxDepartment.Text.Trim();
            string level = comboBoxLevel.Text.Trim();
            string teacher = textBoxTeacher.Text.Trim();
            string hour = textBoxHour.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("❌ يجب إدخال اسم المقرر للتعديل.");
                return;
            }

            if (string.IsNullOrEmpty(dept) || string.IsNullOrEmpty(level) ||
                string.IsNullOrEmpty(teacher) || string.IsNullOrEmpty(hour))
            {
                MessageBox.Show("❌ يرجى تعبئة جميع الحقول.");
                return;
            }

            Database.execute(
                $"UPDATE cources SET department='{dept}', level='{level}', teacher='{teacher}', hour='{hour}' WHERE name='{name}'"
            );

            MessageBox.Show("✔️ تم تعديل بيانات المقرر بنجاح.");
        }

        private void getCourceInformation()
        {
            string selectedCourse = comboBoxSelectCourceName.Text.Trim();

            DataTable dt = Database.query($"SELECT * FROM cources WHERE name='{selectedCourse}'");

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                textBoxNameCourse.Text = row["name"].ToString();
                comboBoxDepartment.Text = row["department"].ToString();
                comboBoxLevel.Text = row["level"].ToString();
                textBoxTeacher.Text = row["teacher"].ToString();
                textBoxHour.Text = row["hour"].ToString();
            }else
            {
                MessageBox.Show("No cource information found");
            }
        }

        // 📌 تحميل كل المقررات داخل ComboBox
        private void loadCourses()
        {
            comboBoxSelectCourceName.Items.Clear();

            DataTable dt = Database.query("SELECT name FROM cources");

            foreach (DataRow row in dt.Rows)
            {
                comboBoxSelectCourceName.Items.Add(row["name"].ToString());
            }
        }

        private void comboBoxSelectCourceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCourceInformation();
        }
    }
}
