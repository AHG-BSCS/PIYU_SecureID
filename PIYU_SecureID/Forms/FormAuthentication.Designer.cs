namespace PIYU_SecureID
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
            pnlTitleBar = new Panel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxAppLogo).BeginInit();
            pnlAppBanner.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppName.ForeColor = Color.FromArgb(250, 201, 48);
            lblAppName.Location = new Point(282, 22);
            lblAppName.Margin = new Padding(4, 0, 4, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(153, 45);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "SecureID";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxPasscode
            // 
            txtBoxPasscode.Anchor = AnchorStyles.Bottom;
            txtBoxPasscode.BorderStyle = BorderStyle.None;
            txtBoxPasscode.Cursor = Cursors.IBeam;
            txtBoxPasscode.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxPasscode.Location = new Point(182, 171);
            txtBoxPasscode.Margin = new Padding(4, 2, 4, 2);
            txtBoxPasscode.MaxLength = 6;
            txtBoxPasscode.Name = "txtBoxPasscode";
            txtBoxPasscode.PasswordChar = '⚫';
            txtBoxPasscode.Size = new Size(236, 32);
            txtBoxPasscode.TabIndex = 1;
            txtBoxPasscode.TextAlign = HorizontalAlignment.Center;
            txtBoxPasscode.TextChanged += txtBoxPasscode_TextChanged;
            txtBoxPasscode.KeyPress += FormAuthentication_KeyPress;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom;
            btnLogin.BackColor = Color.FromArgb(29, 146, 61);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(254, 224);
            btnLogin.Margin = new Padding(4, 2, 4, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(93, 38);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnBypass
            // 
            btnBypass.Anchor = AnchorStyles.Bottom;
            btnBypass.BackColor = Color.FromArgb(250, 201, 48);
            btnBypass.Cursor = Cursors.Hand;
            btnBypass.FlatAppearance.BorderSize = 0;
            btnBypass.FlatStyle = FlatStyle.Flat;
            btnBypass.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBypass.Location = new Point(236, 278);
            btnBypass.Margin = new Padding(4, 2, 4, 2);
            btnBypass.Name = "btnBypass";
            btnBypass.Size = new Size(128, 27);
            btnBypass.TabIndex = 3;
            btnBypass.Text = "★ Debug Bypass";
            btnBypass.UseVisualStyleBackColor = false;
            btnBypass.Visible = false;
            btnBypass.Click += btnBypass_Click;
            // 
            // picBoxAppLogo
            // 
            picBoxAppLogo.BackColor = Color.Transparent;
            picBoxAppLogo.Image = Properties.Resources.PIYU_SecureID;
            picBoxAppLogo.Location = new Point(165, 1);
            picBoxAppLogo.Margin = new Padding(4, 2, 4, 2);
            picBoxAppLogo.Name = "picBoxAppLogo";
            picBoxAppLogo.Size = new Size(117, 107);
            picBoxAppLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxAppLogo.TabIndex = 4;
            picBoxAppLogo.TabStop = false;
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeveloper.ForeColor = Color.FromArgb(250, 201, 48);
            lblDeveloper.Location = new Point(288, 67);
            lblDeveloper.Margin = new Padding(4, 0, 4, 0);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(93, 15);
            lblDeveloper.TabIndex = 0;
            lblDeveloper.Text = "Al Hans Gaming";
            lblDeveloper.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAppBanner
            // 
            pnlAppBanner.BackColor = Color.FromArgb(53, 69, 93);
            pnlAppBanner.Controls.Add(lblDeveloper);
            pnlAppBanner.Controls.Add(lblAppName);
            pnlAppBanner.Controls.Add(picBoxAppLogo);
            pnlAppBanner.Dock = DockStyle.Top;
            pnlAppBanner.Location = new Point(0, 25);
            pnlAppBanner.Margin = new Padding(4, 3, 4, 3);
            pnlAppBanner.Name = "pnlAppBanner";
            pnlAppBanner.Size = new Size(600, 123);
            pnlAppBanner.TabIndex = 0;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(53, 69, 93);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Margin = new Padding(4, 3, 4, 3);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(600, 25);
            pnlTitleBar.TabIndex = 10;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            pnlTitleBar.MouseMove += pnlTitleBar_MouseMove;
            pnlTitleBar.MouseUp += pnlTitleBar_MouseUp;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.icons_close;
            btnClose.Location = new Point(555, 0);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 25);
            btnClose.TabIndex = 8;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // FormAuthentication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 350);
            Controls.Add(btnBypass);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxPasscode);
            Controls.Add(pnlAppBanner);
            Controls.Add(pnlTitleBar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            Name = "FormAuthentication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)picBoxAppLogo).EndInit();
            pnlAppBanner.ResumeLayout(false);
            pnlAppBanner.PerformLayout();
            pnlTitleBar.ResumeLayout(false);
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
        private Panel pnlTitleBar;
        private Button btnClose;
    }
}