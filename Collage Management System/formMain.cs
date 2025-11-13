using Collage_Management_System;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Fahrs
{
    public partial class frmMainDashboard : Form
    {
    //    private Panel selectedMenuPanel = null;
       
        public frmMainDashboard()
        {
            InitializeComponent();
            showUserControl(new UserControlStudent());
        }

     
     

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

       

        private void panelMainContent_Paint(object sender, EventArgs e)
        {

         
        }


        public void showUserControl(UserControl us)
        {
      //      panelMainContent.Controls.Clear();
            us.Dock = DockStyle.Fill;
            panelMainContent.Controls.Clear();
            panelMainContent.Controls.Add(us);
        }

 

       


        private void button10_Click(object sender, EventArgs e)
        {
            showUserControl(new UserControlStudent());
        }
        


        private void button6_Click(object sender, EventArgs e)
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            showUserControl(new UserControlTeacher());
        }

       
    }
}
