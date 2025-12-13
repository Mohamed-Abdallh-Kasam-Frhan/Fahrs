using System;
using System.Data;
using System.Windows.Forms;

namespace Collage_Management_System.UserControlsStudent
{
    public partial class UserControPayment : UserControl
    {
        private double currentRemining;
        public UserControPayment()
        {
            InitializeComponent();
            var students = Database.query("SELECT * FROM students");
            comboBoxStudent.DataSource = students;
            comboBoxStudent.ValueMember = "id";
            comboBoxStudent.DisplayMember = "name";
        }

        private void getStudentInformation()
        {
            string selectedStudent = comboBoxStudent.Text.Trim();

            DataTable dt = Database.query($"SELECT * FROM students WHERE name='{selectedStudent}'");

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                reminingMoney.Text = "المبلغ المتبقي: " + row["remainingMoney"].ToString();
                currentRemining = Convert.ToDouble(row["remainingMoney"]);
            }
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            double newRemining = Convert.ToDouble(textBoxPayment.Text.Trim());
            if(newRemining <= 0)
            {
                MessageBox.Show("يجب ان يكون مبلغ التسديد موجباً");
                return;
            }
            Database.execute($"UPDATE students SET remainingMoney = {currentRemining - newRemining} WHERE name = '{comboBoxStudent.Text.Trim()}'");
            textBoxPayment.Clear();
            MessageBox.Show($"تم تسديد مبلغ {newRemining} بنجاح");
            reminingMoney.Text = "المبلغ المتبقي: " + (currentRemining - newRemining);
        }

        private void comboBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            getStudentInformation();
        }
    }
}
