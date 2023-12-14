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
            lblTransactionCounter = new Label();
            lblTransactions = new Label();
            pnlMiddleSeparator = new Panel();
            btnSettings = new Button();
            btnLogout = new Button();
            pnlLiveDateTime = new Panel();
            lblLiveTime = new Label();
            lblLiveDate = new Label();
            btnVerifyId = new Button();
            btnCheckId = new Button();
            btnCreateId = new Button();
            pnlTopSeparator = new Panel();
            lblAppName = new Label();
            picBoxAppLogo = new PictureBox();
            panel1 = new Panel();
            pnlActiveTab = new Panel();
            pnlTitleBar.SuspendLayout();
            plnSideNavigation.SuspendLayout();
            pnlLiveDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxAppLogo).BeginInit();
            SuspendLayout();
            // 
            // timerDateTime
            // 
            timerDateTime.Enabled = true;
            timerDateTime.Interval = 1000;
            timerDateTime.Tick += timerDateTime_Tick;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = SystemColors.Control;
            btnMinimize.Image = Properties.Resources.icons_minimize;
            btnMinimize.Location = new Point(988, 0);
            btnMinimize.Margin = new Padding(4, 3, 4, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(41, 32);
            btnMinimize.TabIndex = 7;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMinimizeMaximize
            // 
            btnMinimizeMaximize.BackColor = Color.Transparent;
            btnMinimizeMaximize.Cursor = Cursors.Hand;
            btnMinimizeMaximize.Dock = DockStyle.Right;
            btnMinimizeMaximize.FlatAppearance.BorderSize = 0;
            btnMinimizeMaximize.FlatStyle = FlatStyle.Flat;
            btnMinimizeMaximize.ForeColor = SystemColors.Control;
            btnMinimizeMaximize.Image = Properties.Resources.icons_square;
            btnMinimizeMaximize.Location = new Point(1029, 0);
            btnMinimizeMaximize.Margin = new Padding(4, 3, 4, 3);
            btnMinimizeMaximize.Name = "btnMinimizeMaximize";
            btnMinimizeMaximize.Size = new Size(41, 32);
            btnMinimizeMaximize.TabIndex = 8;
            btnMinimizeMaximize.UseVisualStyleBackColor = false;
            btnMinimizeMaximize.Click += btnMinimizeMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = SystemColors.Control;
            btnClose.Image = Properties.Resources.icons_close;
            btnClose.Location = new Point(1070, 0);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 32);
            btnClose.TabIndex = 9;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(53, 69, 93);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(btnMinimizeMaximize);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(155, 0);
            pnlTitleBar.Margin = new Padding(4, 3, 4, 3);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1111, 32);
            pnlTitleBar.TabIndex = 0;
            pnlTitleBar.MouseDown += lblAppName_MouseDown;
            pnlTitleBar.MouseMove += lblAppName_MouseMove;
            pnlTitleBar.MouseUp += lblAppName_MouseUp;
            // 
            // plnSideNavigation
            // 
            plnSideNavigation.BackColor = Color.FromArgb(53, 69, 93);
            plnSideNavigation.Controls.Add(lblTransactionCounter);
            plnSideNavigation.Controls.Add(lblTransactions);
            plnSideNavigation.Controls.Add(pnlMiddleSeparator);
            plnSideNavigation.Controls.Add(btnSettings);
            plnSideNavigation.Controls.Add(btnLogout);
            plnSideNavigation.Controls.Add(pnlLiveDateTime);
            plnSideNavigation.Controls.Add(btnVerifyId);
            plnSideNavigation.Controls.Add(btnCheckId);
            plnSideNavigation.Controls.Add(btnCreateId);
            plnSideNavigation.Controls.Add(pnlTopSeparator);
            plnSideNavigation.Controls.Add(lblAppName);
            plnSideNavigation.Controls.Add(picBoxAppLogo);
            plnSideNavigation.Controls.Add(panel1);
            plnSideNavigation.Dock = DockStyle.Left;
            plnSideNavigation.Location = new Point(0, 0);
            plnSideNavigation.Margin = new Padding(4, 3, 4, 3);
            plnSideNavigation.Name = "plnSideNavigation";
            plnSideNavigation.Padding = new Padding(0, 0, 0, 10);
            plnSideNavigation.Size = new Size(155, 649);
            plnSideNavigation.TabIndex = 0;
            // 
            // lblTransactionCounter
            // 
            lblTransactionCounter.Dock = DockStyle.Top;
            lblTransactionCounter.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTransactionCounter.ForeColor = Color.FromArgb(92, 176, 21);
            lblTransactionCounter.Location = new Point(0, 310);
            lblTransactionCounter.Margin = new Padding(4, 0, 4, 0);
            lblTransactionCounter.Name = "lblTransactionCounter";
            lblTransactionCounter.Size = new Size(155, 43);
            lblTransactionCounter.TabIndex = 13;
            lblTransactionCounter.Text = "0";
            lblTransactionCounter.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTransactions
            // 
            lblTransactions.Dock = DockStyle.Top;
            lblTransactions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTransactions.ForeColor = Color.FromArgb(92, 176, 21);
            lblTransactions.Location = new Point(0, 278);
            lblTransactions.Margin = new Padding(4, 0, 4, 0);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(155, 32);
            lblTransactions.TabIndex = 0;
            lblTransactions.Text = "Transactions";
            lblTransactions.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pnlMiddleSeparator
            // 
            pnlMiddleSeparator.BackColor = Color.FromArgb(92, 176, 21);
            pnlMiddleSeparator.Dock = DockStyle.Top;
            pnlMiddleSeparator.Location = new Point(0, 273);
            pnlMiddleSeparator.Margin = new Padding(4, 3, 4, 3);
            pnlMiddleSeparator.Name = "pnlMiddleSeparator";
            pnlMiddleSeparator.Size = new Size(155, 5);
            pnlMiddleSeparator.TabIndex = 11;
            // 
            // btnSettings
            // 
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(0, 508);
            btnSettings.Margin = new Padding(4, 2, 4, 2);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(12, 0, 0, 0);
            btnSettings.Size = new Size(155, 43);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 551);
            btnLogout.Margin = new Padding(4, 2, 4, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(12, 0, 0, 0);
            btnLogout.Size = new Size(155, 48);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlLiveDateTime
            // 
            pnlLiveDateTime.AutoSize = true;
            pnlLiveDateTime.Controls.Add(lblLiveTime);
            pnlLiveDateTime.Controls.Add(lblLiveDate);
            pnlLiveDateTime.Dock = DockStyle.Bottom;
            pnlLiveDateTime.Location = new Point(0, 599);
            pnlLiveDateTime.Margin = new Padding(4, 3, 4, 3);
            pnlLiveDateTime.Name = "pnlLiveDateTime";
            pnlLiveDateTime.Size = new Size(155, 40);
            pnlLiveDateTime.TabIndex = 0;
            // 
            // lblLiveTime
            // 
            lblLiveTime.Dock = DockStyle.Top;
            lblLiveTime.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLiveTime.ForeColor = Color.White;
            lblLiveTime.Location = new Point(0, 20);
            lblLiveTime.Margin = new Padding(4, 0, 4, 0);
            lblLiveTime.Name = "lblLiveTime";
            lblLiveTime.Padding = new Padding(12, 0, 0, 0);
            lblLiveTime.Size = new Size(155, 20);
            lblLiveTime.TabIndex = 0;
            lblLiveTime.Text = "00:00:00 AM";
            lblLiveTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLiveDate
            // 
            lblLiveDate.Dock = DockStyle.Top;
            lblLiveDate.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLiveDate.ForeColor = SystemColors.Control;
            lblLiveDate.Location = new Point(0, 0);
            lblLiveDate.Margin = new Padding(4, 0, 4, 0);
            lblLiveDate.Name = "lblLiveDate";
            lblLiveDate.Padding = new Padding(12, 0, 0, 0);
            lblLiveDate.Size = new Size(155, 20);
            lblLiveDate.TabIndex = 0;
            lblLiveDate.Text = "January 01, 1753";
            lblLiveDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnVerifyId
            // 
            btnVerifyId.Cursor = Cursors.Hand;
            btnVerifyId.Dock = DockStyle.Top;
            btnVerifyId.FlatAppearance.BorderSize = 0;
            btnVerifyId.FlatStyle = FlatStyle.Flat;
            btnVerifyId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerifyId.ForeColor = Color.White;
            btnVerifyId.Location = new Point(0, 225);
            btnVerifyId.Margin = new Padding(4, 2, 4, 2);
            btnVerifyId.Name = "btnVerifyId";
            btnVerifyId.Padding = new Padding(12, 0, 0, 0);
            btnVerifyId.Size = new Size(155, 48);
            btnVerifyId.TabIndex = 4;
            btnVerifyId.Text = "Verify ID";
            btnVerifyId.TextAlign = ContentAlignment.MiddleLeft;
            btnVerifyId.UseVisualStyleBackColor = true;
            btnVerifyId.Click += btnVerifyId_Click;
            // 
            // btnCheckId
            // 
            btnCheckId.Cursor = Cursors.Hand;
            btnCheckId.Dock = DockStyle.Top;
            btnCheckId.FlatAppearance.BorderSize = 0;
            btnCheckId.FlatStyle = FlatStyle.Flat;
            btnCheckId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckId.ForeColor = Color.White;
            btnCheckId.Location = new Point(0, 177);
            btnCheckId.Margin = new Padding(4, 2, 4, 2);
            btnCheckId.Name = "btnCheckId";
            btnCheckId.Padding = new Padding(12, 0, 0, 0);
            btnCheckId.Size = new Size(155, 48);
            btnCheckId.TabIndex = 3;
            btnCheckId.Text = "Check ID";
            btnCheckId.TextAlign = ContentAlignment.MiddleLeft;
            btnCheckId.UseVisualStyleBackColor = true;
            btnCheckId.Click += btnCheckId_Click;
            // 
            // btnCreateId
            // 
            btnCreateId.Cursor = Cursors.Hand;
            btnCreateId.Dock = DockStyle.Top;
            btnCreateId.FlatAppearance.BorderSize = 0;
            btnCreateId.FlatStyle = FlatStyle.Flat;
            btnCreateId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateId.ForeColor = Color.White;
            btnCreateId.Location = new Point(0, 129);
            btnCreateId.Margin = new Padding(4, 2, 4, 2);
            btnCreateId.Name = "btnCreateId";
            btnCreateId.Padding = new Padding(12, 0, 0, 0);
            btnCreateId.Size = new Size(155, 48);
            btnCreateId.TabIndex = 2;
            btnCreateId.Text = "ID Application";
            btnCreateId.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateId.UseVisualStyleBackColor = true;
            btnCreateId.Click += btnCreateId_Click;
            // 
            // pnlTopSeparator
            // 
            pnlTopSeparator.BackColor = Color.FromArgb(250, 201, 48);
            pnlTopSeparator.Dock = DockStyle.Top;
            pnlTopSeparator.Location = new Point(0, 124);
            pnlTopSeparator.Margin = new Padding(4, 3, 4, 3);
            pnlTopSeparator.Name = "pnlTopSeparator";
            pnlTopSeparator.Size = new Size(155, 5);
            pnlTopSeparator.TabIndex = 12;
            // 
            // lblAppName
            // 
            lblAppName.Dock = DockStyle.Top;
            lblAppName.FlatStyle = FlatStyle.Flat;
            lblAppName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppName.ForeColor = Color.FromArgb(250, 201, 48);
            lblAppName.ImageAlign = ContentAlignment.TopCenter;
            lblAppName.ImageKey = "(none)";
            lblAppName.Location = new Point(0, 81);
            lblAppName.Margin = new Padding(4, 0, 4, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(155, 43);
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
            picBoxAppLogo.Location = new Point(0, 11);
            picBoxAppLogo.Margin = new Padding(4, 2, 4, 2);
            picBoxAppLogo.Name = "picBoxAppLogo";
            picBoxAppLogo.Size = new Size(155, 70);
            picBoxAppLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxAppLogo.TabIndex = 0;
            picBoxAppLogo.TabStop = false;
            picBoxAppLogo.Click += picBoxAppLogo_Click;
            picBoxAppLogo.MouseDown += lblAppName_MouseDown;
            picBoxAppLogo.MouseMove += lblAppName_MouseMove;
            picBoxAppLogo.MouseUp += lblAppName_MouseUp;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 69, 93);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 11);
            panel1.TabIndex = 10;
            panel1.MouseDown += lblAppName_MouseDown;
            panel1.MouseMove += lblAppName_MouseMove;
            panel1.MouseUp += lblAppName_MouseUp;
            // 
            // pnlActiveTab
            // 
            pnlActiveTab.BackColor = Color.White;
            pnlActiveTab.Dock = DockStyle.Fill;
            pnlActiveTab.Location = new Point(155, 32);
            pnlActiveTab.Margin = new Padding(4, 2, 4, 2);
            pnlActiveTab.Name = "pnlActiveTab";
            pnlActiveTab.Size = new Size(1111, 617);
            pnlActiveTab.TabIndex = 0;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 649);
            Controls.Add(pnlActiveTab);
            Controls.Add(pnlTitleBar);
            Controls.Add(plnSideNavigation);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DASHBOARD";
            Load += FormDashboard_Load;
            pnlTitleBar.ResumeLayout(false);
            plnSideNavigation.ResumeLayout(false);
            plnSideNavigation.PerformLayout();
            pnlLiveDateTime.ResumeLayout(false);
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
        private Label lblLiveDate;
        private Label lblAppName;
        private PictureBox picBoxAppLogo;
        private Button btnLogout;
        public Panel pnlActiveTab;
        private Button btnSettings;
        private Panel pnlLiveDateTime;
        private Label lblLiveTime;
        private Panel panel1;
        private Label lblTransactions;
        private Panel pnlMiddleSeparator;
        private Panel pnlTopSeparator;
        private Label lblTransactionCounter;
    }
}