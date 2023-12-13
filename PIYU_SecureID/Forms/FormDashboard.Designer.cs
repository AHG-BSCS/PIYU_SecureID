namespace PIYU_SecureID
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timerDateTime = new System.Windows.Forms.Timer(components);
            btnMinimize = new Button();
            btnMinimizeMaximize = new Button();
            btnClose = new Button();
            pnlTitleBar = new Panel();
            plnSideNavigation = new Panel();
            btnSettings = new Button();
            btnLogout = new Button();
            lblLiveDateTime = new Label();
            btnVerifyId = new Button();
            btnCheckId = new Button();
            btnCreateId = new Button();
            btnDashboard = new Button();
            lblAppName = new Label();
            picBoxAppLogo = new PictureBox();
            pnlActiveTab = new Panel();
            pnlTitleBar.SuspendLayout();
            plnSideNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxAppLogo).BeginInit();
            SuspendLayout();
            // 
            // timerDateTime
            // 
            timerDateTime.Enabled = true;
            timerDateTime.Interval = 1000;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Image = Properties.Resources.icons_minimize;
            btnMinimize.Location = new Point(1116, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(50, 35);
            btnMinimize.TabIndex = 6;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMinimizeMaximize
            // 
            btnMinimizeMaximize.BackColor = Color.Transparent;
            btnMinimizeMaximize.Dock = DockStyle.Right;
            btnMinimizeMaximize.FlatAppearance.BorderSize = 0;
            btnMinimizeMaximize.FlatStyle = FlatStyle.Flat;
            btnMinimizeMaximize.ForeColor = Color.White;
            btnMinimizeMaximize.Image = Properties.Resources.icons_square;
            btnMinimizeMaximize.Location = new Point(1166, 0);
            btnMinimizeMaximize.Name = "btnMinimizeMaximize";
            btnMinimizeMaximize.Size = new Size(50, 35);
            btnMinimizeMaximize.TabIndex = 7;
            btnMinimizeMaximize.UseVisualStyleBackColor = false;
            btnMinimizeMaximize.Click += btnMinimizeMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.icons_close;
            btnClose.Location = new Point(1216, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 35);
            btnClose.TabIndex = 8;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += buttonClose_MouseEnter;
            btnClose.MouseLeave += buttonClose_MouseLeave;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(53, 69, 93);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(btnMinimizeMaximize);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1266, 35);
            pnlTitleBar.TabIndex = 9;
            pnlTitleBar.MouseDown += lblAppName_MouseDown;
            pnlTitleBar.MouseMove += lblAppName_MouseMove;
            pnlTitleBar.MouseUp += lblAppName_MouseUp;
            // 
            // plnSideNavigation
            // 
            plnSideNavigation.BackColor = Color.FromArgb(60, 95, 106);
            plnSideNavigation.Controls.Add(btnSettings);
            plnSideNavigation.Controls.Add(btnLogout);
            plnSideNavigation.Controls.Add(lblLiveDateTime);
            plnSideNavigation.Controls.Add(btnVerifyId);
            plnSideNavigation.Controls.Add(btnCheckId);
            plnSideNavigation.Controls.Add(btnCreateId);
            plnSideNavigation.Controls.Add(btnDashboard);
            plnSideNavigation.Controls.Add(lblAppName);
            plnSideNavigation.Controls.Add(picBoxAppLogo);
            plnSideNavigation.Dock = DockStyle.Left;
            plnSideNavigation.Location = new Point(0, 35);
            plnSideNavigation.Name = "plnSideNavigation";
            plnSideNavigation.Size = new Size(150, 628);
            plnSideNavigation.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(0, 499);
            btnSettings.Margin = new Padding(3, 2, 3, 2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(150, 50);
            btnSettings.TabIndex = 7;
            btnSettings.Text = "SETTINGS";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 549);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 50);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblLiveDateTime
            // 
            lblLiveDateTime.Dock = DockStyle.Bottom;
            lblLiveDateTime.ForeColor = Color.White;
            lblLiveDateTime.Location = new Point(0, 599);
            lblLiveDateTime.Name = "lblLiveDateTime";
            lblLiveDateTime.Size = new Size(150, 29);
            lblLiveDateTime.TabIndex = 4;
            lblLiveDateTime.Text = "00/00/00 00:00:00 AM";
            lblLiveDateTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVerifyId
            // 
            btnVerifyId.Dock = DockStyle.Top;
            btnVerifyId.FlatAppearance.BorderSize = 0;
            btnVerifyId.FlatStyle = FlatStyle.Flat;
            btnVerifyId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerifyId.ForeColor = Color.White;
            btnVerifyId.Location = new Point(0, 273);
            btnVerifyId.Margin = new Padding(3, 2, 3, 2);
            btnVerifyId.Name = "btnVerifyId";
            btnVerifyId.Size = new Size(150, 50);
            btnVerifyId.TabIndex = 3;
            btnVerifyId.Text = "VERIFY ID";
            btnVerifyId.UseVisualStyleBackColor = true;
            btnVerifyId.Click += btnVerifyId_Click;
            // 
            // btnCheckId
            // 
            btnCheckId.Dock = DockStyle.Top;
            btnCheckId.FlatAppearance.BorderSize = 0;
            btnCheckId.FlatStyle = FlatStyle.Flat;
            btnCheckId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckId.ForeColor = Color.White;
            btnCheckId.Location = new Point(0, 223);
            btnCheckId.Margin = new Padding(3, 2, 3, 2);
            btnCheckId.Name = "btnCheckId";
            btnCheckId.Size = new Size(150, 50);
            btnCheckId.TabIndex = 2;
            btnCheckId.Text = "CHECK ID APPLICATION";
            btnCheckId.UseVisualStyleBackColor = true;
            btnCheckId.Click += btnCheckId_Click;
            // 
            // btnCreateId
            // 
            btnCreateId.Dock = DockStyle.Top;
            btnCreateId.FlatAppearance.BorderSize = 0;
            btnCreateId.FlatStyle = FlatStyle.Flat;
            btnCreateId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateId.ForeColor = Color.White;
            btnCreateId.Location = new Point(0, 173);
            btnCreateId.Margin = new Padding(3, 2, 3, 2);
            btnCreateId.Name = "btnCreateId";
            btnCreateId.Size = new Size(150, 50);
            btnCreateId.TabIndex = 1;
            btnCreateId.Text = "ID APPLICATION";
            btnCreateId.UseVisualStyleBackColor = true;
            btnCreateId.Click += btnCreateId_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 123);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(150, 50);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblAppName
            // 
            lblAppName.Dock = DockStyle.Top;
            lblAppName.FlatStyle = FlatStyle.Flat;
            lblAppName.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppName.ForeColor = Color.White;
            lblAppName.ImageAlign = ContentAlignment.TopCenter;
            lblAppName.Location = new Point(0, 70);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(150, 53);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "SecureID";
            lblAppName.TextAlign = ContentAlignment.TopCenter;
            lblAppName.MouseDown += lblAppName_MouseDown;
            lblAppName.MouseMove += lblAppName_MouseMove;
            lblAppName.MouseUp += lblAppName_MouseUp;
            // 
            // picBoxAppLogo
            // 
            picBoxAppLogo.Dock = DockStyle.Top;
            picBoxAppLogo.Image = Properties.Resources.PIYU_SecureID;
            picBoxAppLogo.Location = new Point(0, 0);
            picBoxAppLogo.Margin = new Padding(3, 2, 3, 2);
            picBoxAppLogo.Name = "picBoxAppLogo";
            picBoxAppLogo.Size = new Size(150, 70);
            picBoxAppLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxAppLogo.TabIndex = 0;
            picBoxAppLogo.TabStop = false;
            picBoxAppLogo.MouseDown += lblAppName_MouseDown;
            picBoxAppLogo.MouseMove += lblAppName_MouseMove;
            picBoxAppLogo.MouseUp += lblAppName_MouseUp;
            // 
            // pnlActiveTab
            // 
            pnlActiveTab.Dock = DockStyle.Fill;
            pnlActiveTab.Location = new Point(150, 35);
            pnlActiveTab.Margin = new Padding(3, 2, 3, 2);
            pnlActiveTab.Name = "pnlActiveTab";
            pnlActiveTab.Size = new Size(1116, 628);
            pnlActiveTab.TabIndex = 5;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 663);
            Controls.Add(pnlActiveTab);
            Controls.Add(plnSideNavigation);
            Controls.Add(pnlTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DASHBOARD";
            pnlTitleBar.ResumeLayout(false);
            plnSideNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxAppLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerDateTime;
        private Button btnMinimize;
        private Button btnMinimizeMaximize;
        private Button btnClose;
        private Panel pnlTitleBar;
        private Panel plnSideNavigation;
        private Button btnVerifyId;
        private Button btnCheckId;
        private Button btnCreateId;
        private Label lblLiveDateTime;
        private Label lblAppName;
        private PictureBox picBoxAppLogo;
        private Button btnDashboard;
        private Button btnLogout;
        public Panel pnlActiveTab;
        private Button btnSettings;
    }
}