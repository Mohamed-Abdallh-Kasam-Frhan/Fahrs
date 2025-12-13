using Collage_Management_System;
using Collage_Management_System.usercontrolCourse;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Fahrs
{
    public partial class ucCourses : UserControl
    {
        public ucCourses()
        {
            InitializeComponent();
            LoadCourses();
        }

        public void LoadCourses()
        {
            dgvCourses.Columns.Clear();
            dgvCourses.DataSource = Database.query("SELECT * FROM cources");

            dgvCourses.Columns["name"].HeaderText = "الاسم";
            dgvCourses.Columns["department"].HeaderText = "التخصص";
            dgvCourses.Columns["teacher"].HeaderText = "استاذ المقرر";
            dgvCourses.Columns["level"].HeaderText = "المستوى";
            dgvCourses.Columns["hour"].HeaderText = "الساعات المعتمدة";

            // Add Edit button column
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.Name = "Edit";
            editButton.HeaderText = "تعديل";
            editButton.Text = "✏️";
            editButton.UseColumnTextForButtonValue = true;
            dgvCourses.Columns.Add(editButton);

            // Add Delete button column
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "حذف";
            deleteButton.Text = "🗑️";
            deleteButton.UseColumnTextForButtonValue = true;
            dgvCourses.Columns.Add(deleteButton);

            dgvCourses.CellClick += DgvCourses_CellClick;
        }

        private void DgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCourses.Rows[e.RowIndex];

            if (e.ColumnIndex == dgvCourses.Columns["Edit"].Index)
            {
                // Get course data
                string name = row.Cells["name"].Value.ToString();
                string department = row.Cells["department"].Value.ToString();
                string level = row.Cells["level"].Value.ToString();
                string teacher = row.Cells["teacher"].Value.ToString();
                string hour = row.Cells["hour"].Value.ToString();

                // Find MainForm and switch to update form with pre-filled data
                var mainForm = this.FindForm() as Fahrs.MainForm;
                if (mainForm != null)
                {
                    var updateControl = new usercontrolCourse.UserControlUpdateCourse();
                    updateControl.SetCourseData(name, department, level, teacher, hour);
                    mainForm.switchInputForm(updateControl);
                }
            }
            else if (e.ColumnIndex == dgvCourses.Columns["Delete"].Index)
            {
                string name = row.Cells["name"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"هل أنت متأكد من حذف المقرر '{name}'؟",
                    "تأكيد الحذف",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign
                );

                if (result == DialogResult.Yes)
                {
                    Database.execute($"DELETE FROM cources WHERE name = '{name}'");
                    MessageBox.Show("✔️ تم حذف المقرر بنجاح", "نجح", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    LoadCourses();
                }
            }
        }

         

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
             
        }

        private void panelShowUsCourse_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
