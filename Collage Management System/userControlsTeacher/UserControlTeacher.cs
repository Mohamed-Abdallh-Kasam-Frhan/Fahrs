using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collage_Management_System
{
    public partial class UserControlTeacher : UserControl
    {
        public UserControlTeacher()
        {
            InitializeComponent();
            LoadTeachers();
        }

        public void LoadTeachers()
        {
            dataGradeViewTeachers.Columns.Clear();
            dataGradeViewTeachers.DataSource = Database.query("SELECT * FROM teachers");
            dataGradeViewTeachers.Columns["id"].HeaderText = "الرقم الوظيفي";
            dataGradeViewTeachers.Columns["name"].HeaderText = "الاسم";
            dataGradeViewTeachers.Columns["phone"].HeaderText = "رقم الهاتف";
            dataGradeViewTeachers.Columns["subject"].HeaderText = "المقرر";
            dataGradeViewTeachers.Columns["degree"].HeaderText = "الدرجة الوظيفية";
            dataGradeViewTeachers.Columns["salary"].HeaderText = "الراتب";

            // Add Edit button column
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.Name = "Edit";
            editButton.HeaderText = "تعديل";
            editButton.Text = "✏️";
            editButton.UseColumnTextForButtonValue = true;
            dataGradeViewTeachers.Columns.Add(editButton);

            // Add Delete button column
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "حذف";
            deleteButton.Text = "🗑️";
            deleteButton.UseColumnTextForButtonValue = true;
            dataGradeViewTeachers.Columns.Add(deleteButton);

            dataGradeViewTeachers.CellClick += DataGradeViewTeachers_CellClick;
        }

        private void DataGradeViewTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGradeViewTeachers.Rows[e.RowIndex];

            if (e.ColumnIndex == dataGradeViewTeachers.Columns["Edit"].Index)
            {
                // Get teacher data
                int id = Convert.ToInt32(row.Cells["id"].Value);
                string name = row.Cells["name"].Value.ToString();
                string phone = row.Cells["phone"].Value.ToString();
                string subject = row.Cells["subject"].Value.ToString();
                string degree = row.Cells["degree"].Value.ToString();
                string salary = row.Cells["salary"].Value.ToString();

                // Find MainForm and switch to update form with pre-filled data
                var mainForm = this.FindForm() as Fahrs.MainForm;
                if (mainForm != null)
                {
                    var updateControl = new userControlsTeacher.UserControlUpdateTeacher();
                    updateControl.SetTeacherData(id, name, phone, subject, degree, salary);
                    mainForm.switchInputForm(updateControl);
                }
            }
            else if (e.ColumnIndex == dataGradeViewTeachers.Columns["Delete"].Index)
            {
                int id = Convert.ToInt32(row.Cells["id"].Value);
                string name = row.Cells["name"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"هل أنت متأكد من حذف المدرس '{name}'؟",
                    "تأكيد الحذف",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign
                );

                if (result == DialogResult.Yes)
                {
                    Database.execute($"DELETE FROM teachers WHERE id = {id}");
                    MessageBox.Show("✔️ تم حذف المدرس بنجاح", "نجح", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    LoadTeachers();
                }
            }
        }

        private void dataGradeViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

 


        private void panelAdd_Updae_delete_Techear_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void dataGradeViewStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
