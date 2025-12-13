using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Collage_Management_System.UserControlsStudent
{
    public partial class UserControlCreate : UserControl
    {
        public UserControlCreate()
        {
            InitializeComponent();
            var majors = Database.query("SELECT * FROM majors");
            comboBoxDepartment.DataSource = majors;
            comboBoxDepartment.DisplayMember = "name";
            comboBoxDepartment.ValueMember = "id";
            comboBoxLevel.Items.Add(1);
            comboBoxLevel.Items.Add(2);
            comboBoxLevel.Items.Add(3);
            comboBoxLevel.Items.Add(4);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string idStr = textBoxIdStudent.Text.Trim();
            string name = textBoxNameStudent.Text.Trim();
            string major = comboBoxDepartment.Text.Trim();
            string levelStr = comboBoxLevel.Text.Trim();
            string phone = textBoxPhoneStudent.Text.Trim();
            string status = textBoxState.Text.Trim();
            int reremainingMoney = Convert.ToInt16(textBoxremainingMoney.Text.Trim());

            if (!int.TryParse(idStr, out int id) || id <= 0)
            {
                MessageBox.Show("❌ الرجاء إدخال رقم ID صحيح (رقم موجب فقط).");
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("❌ الرجاء إدخال اسم الطالب.");
                return;
            }

            if (string.IsNullOrEmpty(major))
            {
                MessageBox.Show("❌ الرجاء اختيار التخصص.");
                return;
            }

            if (!int.TryParse(levelStr, out int level) || level <= 0)
            {
                MessageBox.Show("❌ الرجاء اختيار مستوى صحيح (رقم فقط).");
                return;
            }

            if (string.IsNullOrEmpty(phone) || phone.Length < 7)
            {
                MessageBox.Show("❌ الرجاء إدخال رقم هاتف صحيح.");
                return;
            }

            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("❌ الرجاء إدخال حالة الطالب (فعال / خريج / منسحب...).");
                return;
            }

            Database.execute(
                $"INSERT INTO students VALUES ({id}, '{name}', '{major}', {level}, '{phone}', '{status}', {reremainingMoney})"
            );

            MessageBox.Show("✔️ تم إضافة الطالب بنجاح.");

            textBoxIdStudent.Clear();
            textBoxNameStudent.Clear();
            textBoxPhoneStudent.Clear();
            textBoxState.Clear();
            comboBoxDepartment.SelectedIndex = -1;
            comboBoxLevel.SelectedIndex = -1;
        }


        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
