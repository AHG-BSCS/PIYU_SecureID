using System;
using System.Drawing.Drawing2D;
using PIYU_SecureID.Classes;

namespace PIYU_SecureID
{
    public partial class FormDashboard : Form
    {
        private int count;
        private Point mouseDownLocation;
        private Button previousActiveBtn;
        private UserControl activeTab;

        private FormAuthentication authentication;
        private ControlCreateId createId;
        private ControlCheckId checkId;
        private ControlVerifyId verifyId;
        private ControlSettings settings;
        private ClassInformation info;


        public FormDashboard(FormAuthentication auth)
        {
            InitializeComponent();

            this.authentication = auth;
            this.activeTab = new UserControl();
            this.createId = new ControlCreateId();
            this.checkId = new ControlCheckId();
            this.verifyId = new ControlVerifyId();
            this.settings = new ControlSettings();
            this.info = new ClassInformation();
            this.previousActiveBtn = new Button();

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            DesignHelper.PaintRoundBorder(this);
            btnCreateId.PerformClick();
            UpdateTrasactionsCount();
            createId.OnCreateIDClicked += UpdateTrasactionsCount;
        }

        private void ShowTab(UserControl newForm)
        {
            // Check first to prevent spamming
            if (!newForm.Equals(activeTab))
            {
                activeTab.Hide();
                pnlActiveTab.Controls.Clear();
                activeTab = newForm;
                activeTab.Show();

                newForm.Dock = DockStyle.Fill;
                pnlActiveTab.Controls.Add(newForm);
                pnlActiveTab.Focus();
            }
        }

        private void HighlightTab(Button button)
        {
            if (!previousActiveBtn.Equals(button))
            {
                button.BackColor = DesignHelper.COLOR_WHITE;
                button.ForeColor = DesignHelper.COLOR_BLUE;
                previousActiveBtn.BackColor = DesignHelper.COLOR_BLUE;
                previousActiveBtn.ForeColor = DesignHelper.COLOR_WHITE;
                previousActiveBtn = button;
            }
        }

        public void UpdateTrasactionsCount()
        {
            lblTransactionCounter.Text = info.LoadTotalTransaction().ToString();
            lblVerifiedIdCounter.Text = info.LoadTotalId().ToString();
        }

        private void btnCreateId_Click(object sender, EventArgs e)
        {
            ShowTab(createId);
            HighlightTab(btnCreateId);
        }

        private void btnCheckId_Click(object sender, EventArgs e)
        {
            ShowTab(checkId);
            HighlightTab(btnCheckId);
        }

        private void btnVerifyId_Click(object sender, EventArgs e)
        {
            ShowTab(verifyId);
            HighlightTab(btnVerifyId);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowTab(settings);
            HighlightTab(btnSettings);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            authentication.Show();
            this.Close();
        }

        private void lblAppName_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int deltaX = e.X - mouseDownLocation.X;
                int deltaY = e.Y - mouseDownLocation.Y;

                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void lblAppName_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownLocation = e.Location;
        }

        private void lblAppName_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownLocation = Point.Empty;
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblLiveDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            lblLiveTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizeMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                DesignHelper.PaintRoundBorder(this);
                btnMinimizeMaximize.Image = Properties.Resources.icons_square;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.Region = null;
                btnMinimizeMaximize.Image = Properties.Resources.icons_restore_down;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void picBoxAppLogo_Click(object sender, EventArgs e)
        {
            count++;

            if (count == 10)
            {
                FlaffyBird f = new FlaffyBird();
                f.ShowDialog();
                count = 0;
            }
        }
    }
}
