using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class MainForm : Form
    {
        private const int cGrip = 16; // Resize window
        private const int cCaption = 32;
        bool mouseDown; // Drag window
        private Point offset;

        protected override void WndProc(ref Message m) // Make window resizable
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        public MainForm() // Constuctor
        {
            InitializeComponent();
            // Make window resizable
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            // Set navigation line to start window
            PnlNav.Left = dashboardBtn.Left;
            navi_Click(dashboardBtn);
        }

        // Navigation button functions
        private void navi_Click(Button btn)
        {
            PnlNav.Height = btn.Height;
            PnlNav.Top = btn.Top;
            btn.BackColor = Color.FromArgb(50, 5, 5);
        }

        private void navi_Leave(Button btn)
        {
            btn.BackColor = Color.FromArgb(15, 5, 5);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            navi_Click(dashboardBtn);
        }
        private void dashboardBtn_Leave(object sender, EventArgs e)
        {
            navi_Leave(dashboardBtn);
        }

        private void analyticsBtn_Click(object sender, EventArgs e)
        {
            navi_Click(analyticsBtn);
        }

        private void analyticsBtn_Leave(object sender, EventArgs e)
        {
            navi_Leave(analyticsBtn);
        }

        private void calenderBtn_Click(object sender, EventArgs e)
        {
            navi_Click(calenderBtn);
        }

        private void calenderBtn_Leave(object sender, EventArgs e)
        {
            navi_Leave(calenderBtn);
        }

        private void contactBtn_Click(object sender, EventArgs e)
        {
            navi_Click(contactBtn);
        }

        private void contactBtn_Leave(object sender, EventArgs e)
        {
            navi_Leave(contactBtn);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            navi_Click(settingsBtn);
        }

        private void settingsBtn_Leave(object sender, EventArgs e)
        {
            navi_Leave(settingsBtn);
        }

        // Window control buttons
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Move window functions
        private void mouseDown_Event(object sender, MouseEventArgs e)
        {

            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
