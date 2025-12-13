using System;
using System.Data;
using System.Windows.Forms;

namespace Collage_Management_System.usercontrolCourse
{
    public partial class UserControlUpdateCourse : UserControl
    {
        public UserControlUpdateCourse(string name)
        {
            InitializeComponent();
            var majors = Database.query("SELECT * FROM majors");
            comboBoxDepartment.DataSource = majors;
            comboBoxDepartment.ValueMember = "id";
            comboBoxDepartment.DisplayMember = "name";
            getCourceInformation(name);


            loadCourses();
        }
        public UserControlUpdateCourse()
        {
            InitializeComponent();
            var majors = Database.query("SELECT * FROM majors");
            comboBoxDepartment.DataSource = majors;
            comboBoxDepartment.ValueMember = "id";
            comboBoxDepartment.DisplayMember = "name";

            loadCourses();
        }

        public void SetCourseData(string name, string department, string level, string teacher, string hour)
        {
            textBoxNameCourse.Text = name;
            comboBoxDepartment.Text = department;
            comboBoxLevel.Text = level;
            textBoxTeacher.Text = teacher;
            textBoxHour.Text = hour;
            comboBoxSelectCourceName.Text = name;
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

            // Refresh the course grid
            var mainForm = this.FindForm() as Fahrs.MainForm;
            if (mainForm != null)
            {
                var courseControl = mainForm.Controls.Find("panelMainContent", true).FirstOrDefault()?.Controls.OfType<ucCourses>().FirstOrDefault();
                courseControl?.LoadCourses();
            }
        }

        private void getCourceInformation(string selectedCourse)
        {
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
            getCourceInformation(comboBoxSelectCourceName.Text.Trim());
        }
    }
}
