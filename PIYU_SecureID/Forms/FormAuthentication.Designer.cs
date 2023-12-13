﻿namespace PIYU_SecureID
{
    partial class FormAuthentication
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthentication));
            lblAppName = new Label();
            txtBoxPasscode = new TextBox();
            btnLogin = new Button();
            btnBypass = new Button();
            picBoxAppLogo = new PictureBox();
            lblDeveloper = new Label();
            pnlAppBanner = new Panel();
            panelTitleBar = new Panel();
            buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxAppLogo).BeginInit();
            pnlAppBanner.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Corbel", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppName.ForeColor = Color.FromArgb(250, 201, 48);
            lblAppName.Location = new Point(261, 34);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(163, 45);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "SecureID";
            // 
            // txtBoxPasscode
            // 
            txtBoxPasscode.Anchor = AnchorStyles.Bottom;
            txtBoxPasscode.BorderStyle = BorderStyle.None;
            txtBoxPasscode.Font = new Font("Corbel", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPasscode.Location = new Point(191, 193);
            txtBoxPasscode.Margin = new Padding(3, 2, 3, 2);
            txtBoxPasscode.MaxLength = 6;
            txtBoxPasscode.Name = "txtBoxPasscode";
            txtBoxPasscode.PasswordChar = '⚫';
            txtBoxPasscode.Size = new Size(202, 33);
            txtBoxPasscode.TabIndex = 1;
            txtBoxPasscode.TextAlign = HorizontalAlignment.Center;
            txtBoxPasscode.TextChanged += textBox1_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom;
            btnLogin.BackColor = Color.FromArgb(29, 146, 61);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(252, 242);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(80, 35);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // btnBypass
            // 
            btnBypass.Anchor = AnchorStyles.Bottom;
            btnBypass.BackColor = Color.FromArgb(250, 201, 48);
            btnBypass.FlatAppearance.BorderSize = 0;
            btnBypass.FlatStyle = FlatStyle.Flat;
            btnBypass.Font = new Font("Corbel", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBypass.Location = new Point(237, 293);
            btnBypass.Margin = new Padding(3, 2, 3, 2);
            btnBypass.Name = "btnBypass";
            btnBypass.Size = new Size(110, 25);
            btnBypass.TabIndex = 3;
            btnBypass.Text = "★ Debug Bypass";
            btnBypass.UseVisualStyleBackColor = false;
            btnBypass.Visible = false;
            btnBypass.Click += button2_Click;
            // 
            // picBoxAppLogo
            // 
            picBoxAppLogo.BackColor = Color.Transparent;
            picBoxAppLogo.Image = Properties.Resources.PIYU_SecureID;
            picBoxAppLogo.Location = new Point(161, 17);
            picBoxAppLogo.Margin = new Padding(3, 2, 3, 2);
            picBoxAppLogo.Name = "picBoxAppLogo";
            picBoxAppLogo.Size = new Size(100, 100);
            picBoxAppLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxAppLogo.TabIndex = 4;
            picBoxAppLogo.TabStop = false;
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Font = new Font("Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeveloper.ForeColor = Color.FromArgb(250, 201, 48);
            lblDeveloper.Location = new Point(268, 76);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(93, 15);
            lblDeveloper.TabIndex = 5;
            lblDeveloper.Text = "Al Hans Gaming";
            // 
            // pnlAppBanner
            // 
            pnlAppBanner.BackColor = Color.FromArgb(53, 69, 93);
            pnlAppBanner.Controls.Add(picBoxAppLogo);
            pnlAppBanner.Controls.Add(lblAppName);
            pnlAppBanner.Controls.Add(lblDeveloper);
            pnlAppBanner.Dock = DockStyle.Top;
            pnlAppBanner.Location = new Point(0, 35);
            pnlAppBanner.Name = "pnlAppBanner";
            pnlAppBanner.Size = new Size(584, 134);
            pnlAppBanner.TabIndex = 6;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(53, 69, 93);
            panelTitleBar.Controls.Add(buttonClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(584, 35);
            panelTitleBar.TabIndex = 10;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            panelTitleBar.MouseMove += panelTitleBar_MouseMove;
            panelTitleBar.MouseUp += panelTitleBar_MouseUp;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.Transparent;
            buttonClose.Dock = DockStyle.Right;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.ForeColor = Color.White;
            buttonClose.Image = Properties.Resources.icons_close;
            buttonClose.Location = new Point(534, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(50, 35);
            buttonClose.TabIndex = 8;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            buttonClose.MouseEnter += buttonClose_MouseEnter;
            buttonClose.MouseLeave += buttonClose_MouseLeave;
            // 
            // FormAuthentication
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 346);
            Controls.Add(pnlAppBanner);
            Controls.Add(txtBoxPasscode);
            Controls.Add(btnLogin);
            Controls.Add(btnBypass);
            Controls.Add(panelTitleBar);
            Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAuthentication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            FormClosed += FormAuthentication_FormClosed;
            ((System.ComponentModel.ISupportInitialize)picBoxAppLogo).EndInit();
            pnlAppBanner.ResumeLayout(false);
            pnlAppBanner.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        public TextBox txtBoxPasscode;
        private Button btnLogin;
        public Button btnBypass;
        private PictureBox picBoxAppLogo;
        private Label lblDeveloper;
        private Panel pnlAppBanner;
        private Panel panelTitleBar;
        private Button buttonClose;
    }
}