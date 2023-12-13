using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIYU_SecureID
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
            StartupAnimation();
        }

        private async void StartupAnimation()
        {
            string applicationName = "SecureID";
            lblApplicationName.Text = string.Empty;

            for (int i = 318; i >= 218; i--)
            {
                picBoxApplicationLogo.Location = new Point(i, 115);
                await Task.Delay(1);
                Application.DoEvents();
            }

            foreach (char c in applicationName)
            {
                lblApplicationName.Text += c;
                await Task.Delay(100);
                Application.DoEvents();
            }

            Thread.Sleep(1000);
            showNewForm(new FormAuthentication());
        }

        private void showNewForm(Form form)
        {
            this.Hide();
            form.Show();
        }
    }
}
