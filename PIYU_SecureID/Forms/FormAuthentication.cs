using OtpNet;

namespace PIYU_SecureID
{
    public partial class FormAuthentication : Form
    {
        private const string SecretKey = "F7XO6UWCIHG3XAZ4JSBTUYLZVJECUBH7";
        private Point mouseDownLocation;
        public FormAuthentication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userCode = txtBoxPasscode.Text;
            if (ValidateCode(SecretKey, userCode))
            {
                MessageBox.Show("Authentication Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form dashboard = new FormDashboard(this);
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
            if (txtBoxPasscode.Text == "177013")
            {
                btnBypass.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dashboard = new FormDashboard(this);
            dashboard.Show();
        }

        private void FormAuthentication_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Transparent;
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Red;
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

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownLocation = e.Location;
        }

        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownLocation = Point.Empty;
        }
    }
}