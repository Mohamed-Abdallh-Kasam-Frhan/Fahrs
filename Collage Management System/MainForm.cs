using Collage_Management_System;
using System;
using System.Windows.Forms;
using Collage_Management_System.userControlsTeacher;
using Collage_Management_System.UserControlsStudent;
using Collage_Management_System.usercontrolCourse;
//using Fahrs;
using System.Data;
using System.Drawing;

namespace Fahrs
{
    public partial class MainForm : Form
    {
        public static DataTable searchData = new DataTable();
        private UserControl createEntity, updateEntity, deleteEntity;
        private UserControl content;
        private string currentTableName;

        public MainForm()
        {
            InitializeComponent();
            btnSwitchToStudentsPage(null, null);
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int roundDegree = 6;
            UIHelper.MakeButtonsRounded(this, roundDegree);
            UIHelper.MakeTextBoxRounded(this, roundDegree);
            UIHelper.ApplyRoundedRegion(content, roundDegree);
        }
        

        public void switchControl(UserControl userControl, Panel panel)
        {
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
            UIHelper.ApplyRoundedRegion(userControl, 4);
            UIHelper.MakeButtonsRounded(userControl, 4);
        }

        public void switchContent(UserControl us)
        {
            content = us;
            switchControl(us, panelMainContent);
        }

        public void switchInputForm(UserControl us)
        {
            switchControl(us, panelshow);
        }

        public void switchPage(
            string title,
            string tbName,
            UserControl content,
            UserControl create,
            UserControl update,
            UserControl delete,
            bool selectMajor,
            bool payment
        ) {
            lblTitle.Text = title;
            currentTableName = tbName;
            switchContent(content);
            createEntity = create;
            updateEntity = update;
            deleteEntity = delete;
            switchInputForm(create);
            panelSelectLevelAndMaijor.Visible = selectMajor;
            buttonPayment.Visible = payment;
        }

        private void btnSwitchToStudentsPage(object sender, EventArgs e)
        {
            switchPage(
                "👨‍🎓  إدارة الطلاب",
                "students",
                new UserControlStudent(),
                new UserControlCreate(),
                new UserControlUpdate(), 
                new UserControlDelete(), true, true);
        }

        private void btnSwitchToTeachersPage(object sender, EventArgs e)
        {
            switchPage(
                " 👨‍🎓  إدارة المدرسين", 
                "teachers",
                new UserControlTeacher(), 
                new UserControlCreateTecher(),
                new UserControlUpdateTeacher(),
                new UserControlDeleteTeachercs(), false, false );
        }

        private void btnSwitchToCourcesPage(object sender, EventArgs e)
        {
            switchPage(
                "📚  إدارة المقررات", 
                "cources",
                new ucCourses(),
                new UserControlAddCourse(), 
                new UserControlUpdateCourse(),
                new UserControlDeleteCourse(), false, false);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            switchInputForm(deleteEntity);
        }
       
        private void btnEdit_Click(object sender, EventArgs e)
        {
            switchInputForm(updateEntity);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switchInputForm(createEntity);
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnLogout(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل أنت متأكد من تسجيل الخروج؟", "تسجيل الخروج",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                loginForm loginForm = new loginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var nameToSearch = txtSearch.Text;
            if(string.IsNullOrEmpty(nameToSearch))
            {
                switchContent(content);
                return;
            }

            string sql = $"SELECT * FROM {currentTableName} WHERE name LIKE '%{nameToSearch}%'";
            if(currentTableName == "students")
            {
                var major = cmbmajors.SelectedText;
                var level = cmbLevels.SelectedText;
                if(!string.IsNullOrEmpty(major))
                {
                    sql += $" AND major = '{major}'";
                }
                if(!string.IsNullOrEmpty(level))
                {
                    sql += $" AND level = {Convert.ToInt32(level)}";
                }
            }
            MessageBox.Show(sql);
            var result = Database.query(sql);

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("No Items Found.");
                switchContent(content);
                return;
            }

            switchContent(new SearchResult(result));
        }
    }
}

       
    

