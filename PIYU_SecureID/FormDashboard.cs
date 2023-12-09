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
        private static string active = "dashboard";
        private FormAuthentication auth;
        private ControlDashboard dashboard = new ControlDashboard();
        private ControlCreateId create = new ControlCreateId();
        private ControlCheckId check = new ControlCheckId();
        private ControlVerifyId verify = new ControlVerifyId();
        public FormDashboard(FormAuthentication auth)
        {
            InitializeComponent();

            this.auth = auth;

            ControlDashboard dashboard = new ControlDashboard();
            dashboard.Dock = DockStyle.Fill;
            panelActive.Controls.Add(dashboard);
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
            auth.Close();
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

        private void pictureBoxLogo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownLocation = e.Location;
        }

        private void pictureBoxLogo_MouseMove(object sender, MouseEventArgs e)
        {
            panelTitleBar_MouseMove(sender, e);
        }

        private void pictureBoxLogo_MouseUp(object sender, MouseEventArgs e)
        {
            panelTitleBar_MouseDown(sender, e);
        }

        private void buttonCreateId_Click(object sender, EventArgs e)
        {
            if (active != "create")
            {
                active = "create";
                create.Dock = DockStyle.Fill;
                panelActive.Controls.Clear();
                panelActive.Controls.Add(create);
            }
        }

        private void buttonCheckId_Click(object sender, EventArgs e)
        {
            if (active != "check")
            {
                active = "check";
                check.Dock = DockStyle.Fill;
                panelActive.Controls.Clear();
                panelActive.Controls.Add(check);
            }
        }

        private void buttonVerifyId_Click(object sender, EventArgs e)
        {
            if (active != "verify")
            {
                active = "verify";
                verify.Dock = DockStyle.Fill;
                panelActive.Controls.Clear();
                panelActive.Controls.Add(verify);
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            if (active != "dashboard")
            {
                active = "dashboard";
                dashboard.Dock = DockStyle.Fill;
                panelActive.Controls.Clear();
                panelActive.Controls.Add(dashboard);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            auth.Show();
            auth.textBox1.Text = "";
            if (auth.button2.Visible)
                auth.button2.Visible = false;
            this.Close();
        }
    }
}
