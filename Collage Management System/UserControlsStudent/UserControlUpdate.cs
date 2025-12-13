using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Collage_Management_System.UserControlsStudent
{
    public partial class UserControlUpdate : UserControl
    {
        public UserControlUpdate()
        {
            InitializeComponent();

            var students = Database.query("SELECT * FROM students");
            comboBoxStudentName.DataSource = students;
            comboBoxStudentName.ValueMember = "id";
            comboBoxStudentName.DisplayMember = "name";
        }

        public void SetStudentData(int id, string name, string major, int level, string phone, string status)
        {
            textBoxIdStudent.Text = id.ToString();
            textBoxNameStudent.Text = name;
            comboBoxDepartment.Text = major;
            comboBoxLevel.Text = level.ToString();
            textBoxPhoneStudent.Text = phone;
            textBoxState.Text = status;
            comboBoxStudentName.Text = name;
        }

        private void getStudentInformation()
        {
            string selectedStudent = comboBoxStudentName.Text.Trim();

            DataTable dt = Database.query($"SELECT * FROM students WHERE name='{selectedStudent}'");

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                textBoxNameStudent.Text = row["name"].ToString();
                comboBoxDepartment.Text = row["major"].ToString();
                comboBoxLevel.Text = row["level"].ToString();
                textBoxPhoneStudent.Text = row["phone"].ToString();
                textBoxIdStudent.Text = row["id"].ToString();
                textBoxState.Text = row["status"].ToString();
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            string idStr = textBoxIdStudent.Text.Trim();
            string name = textBoxNameStudent.Text.Trim();
            string major = comboBoxDepartment.Text.Trim();
            string levelStr = comboBoxLevel.Text.Trim();
            string phone = textBoxPhoneStudent.Text.Trim();
            string status = textBoxState.Text.Trim();
            var level = int.Parse(levelStr);

            if (!int.TryParse(idStr, out int id))
            {
                MessageBox.Show("❌ الرجاء إدخال ID صحيح.");
                return;
            }

            // التحقق أن الطالب موجود
            var dt = Database.query($"SELECT * FROM students WHERE id = {id}");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("❌ لا يوجد طالب بهذا الـ ID.");
                return;
            }
            Database.execute(
                $"UPDATE students SET name='{name}', major='{major}', level={level}, phone='{phone}', status='{status}' WHERE id={id}"
            );

            MessageBox.Show("✔️ تم تحديث بيانات الطالب بنجاح.");

            // Refresh the student grid
            var mainForm = this.FindForm() as Fahrs.MainForm;
            if (mainForm != null)
            {
                var studentControl = mainForm.Controls.Find("panelMainContent", true).FirstOrDefault()?.Controls.OfType<UserControlStudent>().FirstOrDefault();
                studentControl?.LoadStudents();
            }
        }

        private void comboBoxStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            getStudentInformation();
        }
    }
}
