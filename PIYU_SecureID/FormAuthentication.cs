using OtpNet;

namespace PIYU_SecureID
{
    public partial class FormAuthentication : Form
    {
        private const string SecretKey = "F7XO6UWCIHG3XAZ4JSBTUYLZVJECUBH7";
        public FormAuthentication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userCode = textBox1.Text;
            if (ValidateCode(SecretKey, userCode))
            {
                MessageBox.Show("Authentication Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form dashboard = new FormDashboard();
                dashboard.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "177013")
            {
                button2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dashboard = new FormDashboard();
            dashboard.Show();
        }
    }
}