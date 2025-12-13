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
            dataGradeViewStudents.Columns.Clear();
            dataGradeViewStudents.DataSource = Database.query("SELECT * FROM students");
            
            dataGradeViewStudents.Columns["id"].HeaderText = "الرقم الأكاديمي";
            dataGradeViewStudents.Columns["name"].HeaderText = "الاسم الكامل";
            dataGradeViewStudents.Columns["major"].HeaderText = "التخصص";
            dataGradeViewStudents.Columns["level"].HeaderText = "المستوى";
            dataGradeViewStudents.Columns["phone"].HeaderText = "رقم الهاتف";
            dataGradeViewStudents.Columns["status"].HeaderText = "الحالة";
            dataGradeViewStudents.Columns["remainingMoney"].HeaderText = "المبلغ المتبقي";
        }
    }
}
