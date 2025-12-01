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
            var id = textBoxIdStudent.Text;
            var name = textBoxNameStudent.Text;
            var major = comboBoxDepartment.Text;
            var level = comboBoxLevel.Text;
            var phone = textBoxPhoneStudent.Text;
            var status = textBoxState.Text;
            Database.execute($"INSERT INTO students VALUES ({id}, '{name}', '{major}', {level}, '{phone}', '{status}')");
            textBoxIdStudent.Clear();
            textBoxNameStudent.Clear();
            textBoxPhoneStudent.Clear();
            textBoxState.Clear();
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
