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
using AForge.Video;
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
        private ControlSettings settings = new ControlSettings();
        private ClassInformation info = new ClassInformation();
        public FormDashboard(FormAuthentication auth)
        {
            InitializeComponent();

            this.auth = auth;

            buttonDashboard.BackColor = Color.FromArgb(53, 69, 93);
            dashboard.labelTotalTransaction.Text = "Total Transactions: " + info.LoadTotalTransaction().ToString();
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
            Application.Exit();
        }

        private void buttonRestoreDownMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                buttonRestoreDownMaximize.Image = Properties.Resources.icons_square;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                buttonRestoreDownMaximize.Image = Properties.Resources.icons_restore_down;
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
                NavColorRefresh();
                buttonCreateId.BackColor = Color.FromArgb(53, 69, 93);
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
                NavColorRefresh();
                buttonCheckId.BackColor = Color.FromArgb(53, 69, 93);
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
                NavColorRefresh();
                buttonVerifyId.BackColor = Color.FromArgb(53, 69, 93);
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
                NavColorRefresh();
                buttonDashboard.BackColor = Color.FromArgb(53, 69, 93);
                active = "dashboard";
                dashboard.labelTotalTransaction.Text = "Total Transactions: " + info.LoadTotalTransaction().ToString();
                dashboard.Dock = DockStyle.Fill;
                panelActive.Controls.Clear();
                panelActive.Controls.Add(dashboard);
            }
        }

        private void NavColorRefresh()
        {
            buttonDashboard.BackColor = Color.FromArgb(60, 95, 106);
            buttonCreateId.BackColor = Color.FromArgb(60, 95, 106);
            buttonCheckId.BackColor = Color.FromArgb(60, 95, 106);
            buttonVerifyId.BackColor = Color.FromArgb(60, 95, 106);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            NavColorRefresh();
            buttonLogout.BackColor = Color.FromArgb(53, 69, 93);
            auth.Show();
            auth.textBox1.Text = "";
            if (auth.button2.Visible)
                auth.button2.Visible = false;
            this.Close();
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Transparent;
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Red;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (active != "settings")
            {
                NavColorRefresh();
                buttonDashboard.BackColor = Color.FromArgb(53, 69, 93);
                active = "settings";
                dashboard.Dock = DockStyle.Fill;
                panelActive.Controls.Clear();
                panelActive.Controls.Add(settings);
            }
        }
    }
}
