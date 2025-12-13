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
    public partial class UserControlStudent : UserControl
    {
        public UserControlStudent()
        {
            InitializeComponent();
            LoadStudents();
        }

        public void LoadStudents()
        {
            dataGradeViewStudents.Columns.Clear();
            dataGradeViewStudents.DataSource = Database.query("SELECT * FROM students");

            dataGradeViewStudents.Columns["id"].HeaderText = "الرقم الأكاديمي";
            dataGradeViewStudents.Columns["name"].HeaderText = "الاسم الكامل";
            dataGradeViewStudents.Columns["major"].HeaderText = "التخصص";
            dataGradeViewStudents.Columns["level"].HeaderText = "المستوى";
            dataGradeViewStudents.Columns["phone"].HeaderText = "رقم الهاتف";
            dataGradeViewStudents.Columns["status"].HeaderText = "الحالة";
            dataGradeViewStudents.Columns["remainingMoney"].HeaderText = "المبلغ المتبقي";

            // Add Edit button column
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.Name = "Edit";
            editButton.HeaderText = "تعديل";
            editButton.Text = "✏️";
            editButton.UseColumnTextForButtonValue = true;
            dataGradeViewStudents.Columns.Add(editButton);

            // Add Delete button column
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "حذف";
            deleteButton.Text = "🗑️";
            deleteButton.UseColumnTextForButtonValue = true;
            dataGradeViewStudents.Columns.Add(deleteButton);

            dataGradeViewStudents.CellClick += DataGradeViewStudents_CellClick;
        }

        private void DataGradeViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGradeViewStudents.Rows[e.RowIndex];

            if (e.ColumnIndex == dataGradeViewStudents.Columns["Edit"].Index)
            {
                // Get student data
                int id = Convert.ToInt32(row.Cells["id"].Value);
                string name = row.Cells["name"].Value.ToString();
                string major = row.Cells["major"].Value.ToString();
                int level = Convert.ToInt32(row.Cells["level"].Value);
                string phone = row.Cells["phone"].Value.ToString();
                string status = row.Cells["status"].Value.ToString();

                // Find MainForm and switch to update form with pre-filled data
                var mainForm = this.FindForm() as Fahrs.MainForm;
                if (mainForm != null)
                {
                    var updateControl = new UserControlsStudent.UserControlUpdate();
                    updateControl.SetStudentData(id, name, major, level, phone, status);
                    mainForm.switchInputForm(updateControl);
                }
            }
            else if (e.ColumnIndex == dataGradeViewStudents.Columns["Delete"].Index)
            {
                int id = Convert.ToInt32(row.Cells["id"].Value);
                string name = row.Cells["name"].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"هل أنت متأكد من حذف الطالب '{name}'؟",
                    "تأكيد الحذف",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign
                );

                if (result == DialogResult.Yes)
                {
                    Database.execute($"DELETE FROM students WHERE id = {id}");
                    MessageBox.Show("✔️ تم حذف الطالب بنجاح", "نجح", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    LoadStudents();
                }
            }
        }
    }
}
