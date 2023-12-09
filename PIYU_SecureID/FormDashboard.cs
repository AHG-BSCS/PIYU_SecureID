using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PIYU_SecureID
{
    public partial class FormDashboard : Form
    {
        private Point mouseDownLocation;
        public FormDashboard()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        void UpdateDateTime()
        {
            labelDateTime.Text = DateTime.Now.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRestoreDownMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownLocation = e.Location;
        }

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int deltaX = e.X - mouseDownLocation.X;
                int deltaY = e.Y - mouseDownLocation.Y;

                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownLocation = Point.Empty;
        }

        private void labelInstitution_MouseUp(object sender, MouseEventArgs e)
        {
            panelTitleBar_MouseDown(sender, e);
        }

        private void labelInstitution_MouseMove(object sender, MouseEventArgs e)
        {
            panelTitleBar_MouseMove(sender, e);
        }

        private void labelInstitution_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownLocation = e.Location;
        }
    }
}
