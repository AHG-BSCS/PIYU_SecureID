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
            lblVerifiedIdCounter = new Label();
            labelVerifiedId = new Label();
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
            btnMinimize.Location = new Point(1016, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(35, 30);
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
            btnMinimizeMaximize.Location = new Point(1051, 0);
            btnMinimizeMaximize.Name = "btnMinimizeMaximize";
            btnMinimizeMaximize.Size = new Size(35, 30);
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
            btnClose.Location = new Point(1086, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 30);
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
            pnlTitleBar.Location = new Point(145, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1121, 30);
            pnlTitleBar.TabIndex = 0;
            pnlTitleBar.MouseDown += lblAppName_MouseDown;
            pnlTitleBar.MouseMove += lblAppName_MouseMove;
            pnlTitleBar.MouseUp += lblAppName_MouseUp;
            // 
            // plnSideNavigation
            // 
            plnSideNavigation.BackColor = Color.FromArgb(53, 69, 93);
            plnSideNavigation.Controls.Add(lblVerifiedIdCounter);
            plnSideNavigation.Controls.Add(labelVerifiedId);
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
            plnSideNavigation.Name = "plnSideNavigation";
            plnSideNavigation.Padding = new Padding(0, 0, 0, 10);
            plnSideNavigation.Size = new Size(145, 649);
            plnSideNavigation.TabIndex = 0;
            // 
            // lblVerifiedIdCounter
            // 
            lblVerifiedIdCounter.Dock = DockStyle.Top;
            lblVerifiedIdCounter.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblVerifiedIdCounter.ForeColor = Color.FromArgb(92, 176, 21);
            lblVerifiedIdCounter.Location = new Point(0, 351);
            lblVerifiedIdCounter.Name = "lblVerifiedIdCounter";
            lblVerifiedIdCounter.Size = new Size(145, 40);
            lblVerifiedIdCounter.TabIndex = 16;
            lblVerifiedIdCounter.Text = "0";
            lblVerifiedIdCounter.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelVerifiedId
            // 
            labelVerifiedId.Dock = DockStyle.Top;
            labelVerifiedId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelVerifiedId.ForeColor = Color.FromArgb(92, 176, 21);
            labelVerifiedId.Location = new Point(0, 321);
            labelVerifiedId.Name = "labelVerifiedId";
            labelVerifiedId.Size = new Size(145, 30);
            labelVerifiedId.TabIndex = 14;
            labelVerifiedId.Text = "Verified Id";
            labelVerifiedId.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblTransactionCounter
            // 
            lblTransactionCounter.Dock = DockStyle.Top;
            lblTransactionCounter.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTransactionCounter.ForeColor = Color.FromArgb(92, 176, 21);
            lblTransactionCounter.Location = new Point(0, 281);
            lblTransactionCounter.Name = "lblTransactionCounter";
            lblTransactionCounter.Size = new Size(145, 40);
            lblTransactionCounter.TabIndex = 13;
            lblTransactionCounter.Text = "0";
            lblTransactionCounter.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTransactions
            // 
            lblTransactions.Dock = DockStyle.Top;
            lblTransactions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTransactions.ForeColor = Color.FromArgb(92, 176, 21);
            lblTransactions.Location = new Point(0, 251);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(145, 30);
            lblTransactions.TabIndex = 0;
            lblTransactions.Text = "Transactions";
            lblTransactions.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pnlMiddleSeparator
            // 
            pnlMiddleSeparator.BackColor = Color.FromArgb(92, 176, 21);
            pnlMiddleSeparator.Dock = DockStyle.Top;
            pnlMiddleSeparator.Location = new Point(0, 246);
            pnlMiddleSeparator.Name = "pnlMiddleSeparator";
            pnlMiddleSeparator.Size = new Size(145, 5);
            pnlMiddleSeparator.TabIndex = 11;
            // 
            // btnSettings
            // 
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(0, 524);
            btnSettings.Margin = new Padding(3, 2, 3, 2);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 0, 0);
            btnSettings.Size = new Size(145, 40);
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
            btnLogout.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 564);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(145, 45);
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
            pnlLiveDateTime.Location = new Point(0, 609);
            pnlLiveDateTime.Name = "pnlLiveDateTime";
            pnlLiveDateTime.Size = new Size(145, 30);
            pnlLiveDateTime.TabIndex = 0;
            // 
            // lblLiveTime
            // 
            lblLiveTime.Dock = DockStyle.Top;
            lblLiveTime.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblLiveTime.ForeColor = Color.White;
            lblLiveTime.Location = new Point(0, 15);
            lblLiveTime.Name = "lblLiveTime";
            lblLiveTime.Padding = new Padding(10, 0, 0, 0);
            lblLiveTime.Size = new Size(145, 15);
            lblLiveTime.TabIndex = 0;
            lblLiveTime.Text = "00:00:00 AM";
            lblLiveTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLiveDate
            // 
            lblLiveDate.Dock = DockStyle.Top;
            lblLiveDate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblLiveDate.ForeColor = SystemColors.Control;
            lblLiveDate.Location = new Point(0, 0);
            lblLiveDate.Name = "lblLiveDate";
            lblLiveDate.Padding = new Padding(10, 0, 0, 0);
            lblLiveDate.Size = new Size(145, 15);
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
            btnVerifyId.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerifyId.ForeColor = Color.White;
            btnVerifyId.Location = new Point(0, 201);
            btnVerifyId.Margin = new Padding(3, 2, 3, 2);
            btnVerifyId.Name = "btnVerifyId";
            btnVerifyId.Padding = new Padding(10, 0, 0, 0);
            btnVerifyId.Size = new Size(145, 45);
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
            btnCheckId.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckId.ForeColor = Color.White;
            btnCheckId.Location = new Point(0, 156);
            btnCheckId.Margin = new Padding(3, 2, 3, 2);
            btnCheckId.Name = "btnCheckId";
            btnCheckId.Padding = new Padding(10, 0, 0, 0);
            btnCheckId.Size = new Size(145, 45);
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
            btnCreateId.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateId.ForeColor = Color.White;
            btnCreateId.Location = new Point(0, 111);
            btnCreateId.Margin = new Padding(3, 2, 3, 2);
            btnCreateId.Name = "btnCreateId";
            btnCreateId.Padding = new Padding(10, 0, 0, 0);
            btnCreateId.Size = new Size(145, 45);
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
            pnlTopSeparator.Location = new Point(0, 106);
            pnlTopSeparator.Name = "pnlTopSeparator";
            pnlTopSeparator.Size = new Size(145, 5);
            pnlTopSeparator.TabIndex = 12;
            // 
            // lblAppName
            // 
            lblAppName.Dock = DockStyle.Top;
            lblAppName.FlatStyle = FlatStyle.Flat;
            lblAppName.Font = new Font("Corbel", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppName.ForeColor = Color.FromArgb(250, 201, 48);
            lblAppName.ImageAlign = ContentAlignment.TopCenter;
            lblAppName.ImageKey = "(none)";
            lblAppName.Location = new Point(0, 66);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(145, 40);
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
            picBoxAppLogo.Location = new Point(0, 10);
            picBoxAppLogo.Margin = new Padding(3, 2, 3, 2);
            picBoxAppLogo.Name = "picBoxAppLogo";
            picBoxAppLogo.Size = new Size(145, 56);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 10);
            panel1.TabIndex = 10;
            panel1.MouseDown += lblAppName_MouseDown;
            panel1.MouseMove += lblAppName_MouseMove;
            panel1.MouseUp += lblAppName_MouseUp;
            // 
            // pnlActiveTab
            // 
            pnlActiveTab.BackColor = Color.White;
            pnlActiveTab.Dock = DockStyle.Fill;
            pnlActiveTab.Location = new Point(145, 30);
            pnlActiveTab.Margin = new Padding(3, 2, 3, 2);
            pnlActiveTab.Name = "pnlActiveTab";
            pnlActiveTab.Size = new Size(1121, 619);
            pnlActiveTab.TabIndex = 0;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 649);
            Controls.Add(pnlActiveTab);
            Controls.Add(pnlTitleBar);
            Controls.Add(plnSideNavigation);
            Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Label labelVerifiedId;
        public static Label lblTransactionCounter;
        public static Label lblVerifiedIdCounter;
    }
}