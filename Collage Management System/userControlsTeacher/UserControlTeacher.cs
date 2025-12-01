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
            dataGradeViewTeachers.Columns.Clear();
            dataGradeViewTeachers.DataSource = Database.query("SELECT * FROM teachers");
            dataGradeViewTeachers.Columns["id"].HeaderText = "الرقم الوظيفي";
            dataGradeViewTeachers.Columns["name"].HeaderText = "الاسم";
            dataGradeViewTeachers.Columns["phone"].HeaderText = "رقم الهاتف";
            dataGradeViewTeachers.Columns["subject"].HeaderText = "المقرر";
            dataGradeViewTeachers.Columns["degree"].HeaderText = "الدرجة الوظيفية";
            dataGradeViewTeachers.Columns["salary"].HeaderText = "الراتب";
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
