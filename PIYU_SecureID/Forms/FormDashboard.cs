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
        private ControlDashboard dashboard = new ControlDashboard();
        private ControlCreateId create = new ControlCreateId();
        private ControlCheckId check = new ControlCheckId();
        private ControlVerifyId verify = new ControlVerifyId();
        private ControlSettings settings = new ControlSettings();
        private ClassInformation info = new ClassInformation();
        private Point mouseDownLocation;
        private FormAuthentication auth;
        private static string active = "";
        public FormDashboard(FormAuthentication auth)
        {
            InitializeComponent();

            this.auth = auth;

            UpdateActiveSelection("dashboard");
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
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

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            UpdateActiveSelection("dashboard");
        }

        private void buttonCreateId_Click(object sender, EventArgs e)
        {
            UpdateActiveSelection("create");
        }

        private void buttonCheckId_Click(object sender, EventArgs e)
        {
            UpdateActiveSelection("check");
        }

        private void buttonVerifyId_Click(object sender, EventArgs e)
        {
            UpdateActiveSelection("verify");
        }
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            UpdateActiveSelection("settings");
        }

        private void NavColorRefresh()
        {
            buttonDashboard.BackColor = Color.FromArgb(60, 95, 106);
            buttonCreateId.BackColor = Color.FromArgb(60, 95, 106);
            buttonCheckId.BackColor = Color.FromArgb(60, 95, 106);
            buttonVerifyId.BackColor = Color.FromArgb(60, 95, 106);
            buttonSettings.BackColor = Color.FromArgb(60, 95, 106);
            buttonDashboard.ForeColor = Color.White;
            buttonCreateId.ForeColor = Color.White;
            buttonCheckId.ForeColor = Color.White;
            buttonVerifyId.ForeColor = Color.White;
            buttonSettings.ForeColor = Color.White;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            auth.Show();
            auth.txtBoxPasscode.Text = "";
            if (auth.btnBypass.Visible)
                auth.btnBypass.Visible = false;
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

        private void labelInstitution_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int deltaX = e.X - mouseDownLocation.X;
                int deltaY = e.Y - mouseDownLocation.Y;

                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void labelInstitution_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownLocation = e.Location;
        }

        private void labelInstitution_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownLocation = Point.Empty;
        }

        private void UpdateDateTime()
        {
            labelDateTime.Text = DateTime.Now.ToString();
        }

        private void UpdateActiveSelection(string newActive)
        {
            if (active != "dashboard" && newActive == "dashboard")
            {
                NavColorRefresh();
                buttonDashboard.BackColor = Color.White;
                buttonDashboard.ForeColor = Color.FromArgb(53, 69, 93);
                active = "dashboard";
                dashboard.labelTotalTransaction.Text = "Total Transactions: " + info.LoadTotalTransaction().ToString();
                dashboard.Dock = DockStyle.Fill;
                panelActive.Controls.Clear();
                panelActive.Controls.Add(dashboard);
            }
            else if (active != "create" && newActive == "create")
            {
                NavColorRefresh();
                buttonCreateId.BackColor = Color.White;
                buttonCreateId.ForeColor = Color.FromArgb(53, 69, 93);
                active = "create";
                create.Dock = DockStyle.Fill;
                panelActive.Controls.Clear();
                panelActive.Controls.Add(create);
            }
            else if (active != "check" && newActive == "check")
            {
                NavColorRefresh();
                buttonCheckId.BackColor = Color.White;
                buttonCheckId.ForeColor = Color.FromArgb(53, 69, 93);
                active = "check";
                check.Dock = DockStyle.Fill;
                panelActive.Controls.Clear();
                panelActive.Controls.Add(check);
            }
            else if (active != "verify" && newActive == "verify")
            {
                NavColorRefresh();
                buttonVerifyId.BackColor = Color.White;
                buttonVerifyId.ForeColor = Color.FromArgb(53, 69, 93);
                active = "verify";
                verify.Dock = DockStyle.Fill;
                panelActive.Controls.Clear();
                panelActive.Controls.Add(verify);
            }
            else if (active != "settings" && newActive == "settings")
            {
                NavColorRefresh();
                buttonSettings.BackColor = Color.White;
                buttonSettings.ForeColor = Color.FromArgb(53, 69, 93);
                active = "settings";
                settings.Dock = DockStyle.Fill;
                panelActive.Controls.Clear();
                panelActive.Controls.Add(settings);
            }
        }
    }
}
