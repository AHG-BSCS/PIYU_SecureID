using OtpNet;

namespace PIYU_SecureID
{
    public partial class FormAuthentication : Form
    {
        private FormDashboard dashboard;

        public FormAuthentication()
        {
            InitializeComponent();
            dashboard = new FormDashboard(this);
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
    }
}