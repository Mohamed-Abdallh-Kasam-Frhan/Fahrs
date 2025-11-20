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
            // Database.execute("CREATE TABLE users(id integer primary key, name varchar(255), major varchar(255), level integer, phone varchar(255), status varchar(50) );");
            // Database.execute("INSERT INTO users values (1, 'Asem', 'SE', 3, '1234', 'Active')");
            // Database.execute("INSERT INTO users values (2, 'Ali', 'SE', 3, '5433', 'Active')");
            // Database.execute("INSERT INTO users values (3, 'Khalid', 'IT', 4, '574839', 'InActive')");
            // Database.execute("INSERT INTO users values (4, 'Said', 'SE', 3, '8393', 'Active')");
            dataGradeViewStudents.Columns.Clear();
            dataGradeViewStudents.DataSource = Database.query("SELECT * FROM users");

            dataGradeViewStudents.Columns["id"].HeaderText = "الرقم الأكاديمي";
            dataGradeViewStudents.Columns["name"].HeaderText = "الاسم الكامل";
            dataGradeViewStudents.Columns["major"].HeaderText = "التخصص";
            dataGradeViewStudents.Columns["level"].HeaderText = "المستوى";
            dataGradeViewStudents.Columns["phone"].HeaderText = "رقم الهاتف";
            dataGradeViewStudents.Columns["status"].HeaderText = "الحالة";

        }

        private void dataGradeViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlStudent_Load(object sender, EventArgs e)
        {

        } 
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGradeViewStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
