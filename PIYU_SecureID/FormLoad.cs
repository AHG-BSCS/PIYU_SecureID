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
        private string secureID = "SecureID";
        public FormLoad()
        {
            InitializeComponent();
            LoadAsync();
        }

        private async void LoadAsync()
        {
            for (int i = 300; i >= 200; i--)
            {
                pictureBoxLogo.Location = new Point(i, 115);
                await Task.Delay(1);
                Application.DoEvents();
            }
            labelName.Text = "";
            foreach (char c in secureID)
            {
                labelName.Text += c;
                await Task.Delay(200);
                Application.DoEvents();
            }
            Thread.Sleep(5000);
            this.Hide();
            FormAuthentication auth = new FormAuthentication();
            auth.Show();
        }
    }
}
