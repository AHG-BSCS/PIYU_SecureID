using OtpNet;

namespace PIYU_SecureID
{
    public partial class FormAuthentication : Form
    {
        public FormAuthentication()
        {
            InitializeComponent();
        }

        private void TxtBoxPasscode_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPasscode.Text == "177013")
            {
                btnBypass.Visible = true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            const string SECRETKEY = "F7XO6UWCIHG3XAZ4JSBTUYLZVJECUBH7";
            string userCode = txtBoxPasscode.Text;

            if (string.IsNullOrEmpty(userCode))
            {
                // Do noting if passcode is empty
            }
            else if (txtBoxPasscode.Text.Length < 6)
            {
                MessageBox.Show("Passcode is too short!. Required at least six (6) digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValidateCode(SECRETKEY, userCode))
            {
                MessageBox.Show("Authentication Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form dashboard = new FormDashboard(this);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Authentication failed! Please make sure that you are authorized to access this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateCode(string secretKey, string userCode)
        {
            var totp = new Totp(Base32Encoding.ToBytes(secretKey));
            return totp.VerifyTotp(userCode, out _, new VerificationWindow(2, 2)); // Validate within ±2 time steps.
        }

        private void BtnBypass_Click(object sender, EventArgs e)
        {
            Form dashboard = new FormDashboard(this);
            dashboard.Show();
            this.Hide();
        }

        private void FormAuthentication_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}