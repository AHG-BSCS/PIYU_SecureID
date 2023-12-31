﻿using System;

using PIYU_SecureID.Classes;

namespace PIYU_SecureID
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
            DesignHelper.PaintRoundBorder(this);
            StartupAnimation();
        }

        private async void StartupAnimation()
        {
            string appName = "SecureID";
            lblAppName.Text = string.Empty;

            for (int i = 262; i >= 162; i--)
            {
                picBoxAppLogo.Location = new Point(i, 120);
                await Task.Delay(1);
                Application.DoEvents();
            }

            foreach (char c in appName)
            {
                lblAppName.Text += c;
                await Task.Delay(100);
                Application.DoEvents();
            }

            Thread.Sleep(1000);
            ShowNewForm(new FormAuthentication());
        }

        private void ShowNewForm(Form newForm)
        {
            newForm.Show();
            this.Hide();
        }
    }
}
