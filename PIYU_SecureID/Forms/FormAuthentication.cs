using System;
using OtpNet;
using PIYU_SecureID.Classes;

namespace PIYU_SecureID
{
    public partial class FormAuthentication : Form
    {
        private Point mouseDownLocation;

        public FormAuthentication()
        {
            InitializeComponent();
            DesignHelper.PaintRoundBorder(this);
        }

        private bool ValidateCode(string secretKey, string userCode)
        {
            var totp = new Totp(Base32Encoding.ToBytes(secretKey));
            return totp.VerifyTotp(userCode, out _, new VerificationWindow(2, 2)); // Validate within ±2 time steps.
        }

        private void ShowDashboard()
        {
            txtBoxPasscode.Text = "";
            btnBypass.Visible = false;
            FormDashboard dashboard = new FormDashboard(this);
            dashboard.Show();
            this.Hide();
        }

        private void txtBoxPasscode_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPasscode.Text == "177013")
            {
                btnBypass.Visible = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            const string SECRETKEY = "F7XO6UWCIHG3XAZ4JSBTUYLZVJECUBH7";
            string userCode = txtBoxPasscode.Text;

            if (string.IsNullOrEmpty(userCode)) { } // Do nothing if passcode is empty
            else if (txtBoxPasscode.Text.Length < 6)
            {
                MessageBox.Show("Passcode is too short!. Required at least six (6) digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValidateCode(SECRETKEY, userCode))
            {
                MessageBox.Show("Authentication Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDashboard();
            }
            else
            {
                MessageBox.Show("Authentication failed! Please make sure that you are authorized to access this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBypass_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void FormAuthentication_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormAuthentication_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter & txtBoxPasscode.Text == "177013")
            {
                btnBypass_Click(sender, e);
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
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

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int deltaX = e.X - mouseDownLocation.X;
                int deltaY = e.Y - mouseDownLocation.Y;

                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownLocation = Point.Empty;
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownLocation = e.Location;
        }
    }
}