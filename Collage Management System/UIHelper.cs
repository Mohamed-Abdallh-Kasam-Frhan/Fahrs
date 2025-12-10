using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Collage_Management_System
{
    public static class UIHelper
    {
        public static void MakeButtonsRounded(Control parent, int round)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Resize += (s, e) => ApplyRoundedRegion(btn, round);
                    ApplyRoundedRegion(btn, round -2);
                }
                if (ctrl.HasChildren)
                    MakeButtonsRounded(ctrl, round);
            }
        }

        private static void RoundButtonPaint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rect = btn.ClientRectangle;
            int radius = 20;
            int r = radius;

            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
                path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
                path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
                path.CloseFigure();

                using (Brush brush = new SolidBrush(btn.BackColor))
                    e.Graphics.FillPath(brush, path);

                using (var pen = new Pen(btn.ForeColor))
                    e.Graphics.DrawPath(pen, path);

                TextRenderer.DrawText(
                    e.Graphics,
                    btn.Text,
                    btn.Font,
                    rect,
                    btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private static void ApplyRoundedRegion(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int r = radius * 2;
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);

            btn.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                    e.Graphics.FillPath(brush, path);

                TextRenderer.DrawText(
                    e.Graphics,
                    btn.Text,
                    btn.Font,
                    btn.ClientRectangle,
                    btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            };
        }

        public static void ApplyRoundedRegion(Control ctrl, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle rect = new Rectangle(0, 0, ctrl.Width, ctrl.Height);

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            ctrl.Region = new Region(path);
        }


        public static void MakeTextBoxRounded(Control parent, int radius)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.BorderStyle = BorderStyle.None; // إزالة الحواف العادية

                    // عند تغيير الحجم، نقوم بتطبيق الحواف الدائرية
                    txt.Resize += (s, e) => ApplyRoundedRegionToTextBox(txt, radius);

                    ApplyRoundedRegionToTextBox(txt, radius);
                }

                // تكرار داخل العناصر الفرعية
                if (ctrl.HasChildren)
                    MakeTextBoxRounded(ctrl, radius);
            }
        }

        private static void ApplyRoundedRegionToTextBox(TextBox txt, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle rect = new Rectangle(0, 0, txt.Width, txt.Height);

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            txt.Region = new Region(path);
        }

    }


}


