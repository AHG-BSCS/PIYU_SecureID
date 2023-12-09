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
            this.components = new System.ComponentModel.Container();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonRestoreDownMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.buttonVerifyId = new System.Windows.Forms.Button();
            this.buttonCheckId = new System.Windows.Forms.Button();
            this.buttonCreateId = new System.Windows.Forms.Button();
            this.labelInstitution = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelActive = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Location = new System.Drawing.Point(908, 0);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(57, 47);
            this.buttonMinimize.TabIndex = 6;
            this.buttonMinimize.Text = "--";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonRestoreDownMaximize
            // 
            this.buttonRestoreDownMaximize.BackColor = System.Drawing.Color.Transparent;
            this.buttonRestoreDownMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRestoreDownMaximize.FlatAppearance.BorderSize = 0;
            this.buttonRestoreDownMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestoreDownMaximize.ForeColor = System.Drawing.Color.White;
            this.buttonRestoreDownMaximize.Location = new System.Drawing.Point(965, 0);
            this.buttonRestoreDownMaximize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRestoreDownMaximize.Name = "buttonRestoreDownMaximize";
            this.buttonRestoreDownMaximize.Size = new System.Drawing.Size(57, 47);
            this.buttonRestoreDownMaximize.TabIndex = 7;
            this.buttonRestoreDownMaximize.Text = "O";
            this.buttonRestoreDownMaximize.UseVisualStyleBackColor = false;
            this.buttonRestoreDownMaximize.Click += new System.EventHandler(this.buttonRestoreDownMaximize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(1022, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(57, 47);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(93)))));
            this.panelTitleBar.Controls.Add(this.buttonMinimize);
            this.panelTitleBar.Controls.Add(this.buttonRestoreDownMaximize);
            this.panelTitleBar.Controls.Add(this.buttonClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(171, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1079, 47);
            this.panelTitleBar.TabIndex = 9;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(95)))), ((int)(((byte)(106)))));
            this.panelNavigation.Controls.Add(this.labelDateTime);
            this.panelNavigation.Controls.Add(this.buttonVerifyId);
            this.panelNavigation.Controls.Add(this.buttonCheckId);
            this.panelNavigation.Controls.Add(this.buttonCreateId);
            this.panelNavigation.Controls.Add(this.labelInstitution);
            this.panelNavigation.Controls.Add(this.pictureBoxLogo);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(171, 788);
            this.panelNavigation.TabIndex = 0;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDateTime.ForeColor = System.Drawing.Color.White;
            this.labelDateTime.Location = new System.Drawing.Point(0, 749);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(171, 39);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "00/00/00 00:00:00 AM";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonVerifyId
            // 
            this.buttonVerifyId.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVerifyId.FlatAppearance.BorderSize = 0;
            this.buttonVerifyId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerifyId.ForeColor = System.Drawing.Color.White;
            this.buttonVerifyId.Location = new System.Drawing.Point(0, 274);
            this.buttonVerifyId.Name = "buttonVerifyId";
            this.buttonVerifyId.Size = new System.Drawing.Size(171, 67);
            this.buttonVerifyId.TabIndex = 3;
            this.buttonVerifyId.Text = "VERIFY ID";
            this.buttonVerifyId.UseVisualStyleBackColor = true;
            this.buttonVerifyId.Click += new System.EventHandler(this.buttonVerifyId_Click);
            // 
            // buttonCheckId
            // 
            this.buttonCheckId.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCheckId.FlatAppearance.BorderSize = 0;
            this.buttonCheckId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckId.ForeColor = System.Drawing.Color.White;
            this.buttonCheckId.Location = new System.Drawing.Point(0, 207);
            this.buttonCheckId.Name = "buttonCheckId";
            this.buttonCheckId.Size = new System.Drawing.Size(171, 67);
            this.buttonCheckId.TabIndex = 2;
            this.buttonCheckId.Text = "CHECK ID";
            this.buttonCheckId.UseVisualStyleBackColor = true;
            this.buttonCheckId.Click += new System.EventHandler(this.buttonCheckId_Click);
            // 
            // buttonCreateId
            // 
            this.buttonCreateId.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreateId.FlatAppearance.BorderSize = 0;
            this.buttonCreateId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateId.ForeColor = System.Drawing.Color.White;
            this.buttonCreateId.Location = new System.Drawing.Point(0, 140);
            this.buttonCreateId.Name = "buttonCreateId";
            this.buttonCreateId.Size = new System.Drawing.Size(171, 67);
            this.buttonCreateId.TabIndex = 1;
            this.buttonCreateId.Text = "CREATE ID";
            this.buttonCreateId.UseVisualStyleBackColor = true;
            this.buttonCreateId.Click += new System.EventHandler(this.buttonCreateId_Click);
            // 
            // labelInstitution
            // 
            this.labelInstitution.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInstitution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelInstitution.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInstitution.ForeColor = System.Drawing.Color.White;
            this.labelInstitution.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelInstitution.Location = new System.Drawing.Point(0, 93);
            this.labelInstitution.Name = "labelInstitution";
            this.labelInstitution.Size = new System.Drawing.Size(171, 47);
            this.labelInstitution.TabIndex = 0;
            this.labelInstitution.Text = "SecureID";
            this.labelInstitution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.Image = global::PIYU_SecureID.Properties.Resources.PIYU_SecureID;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(171, 93);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelActive
            // 
            this.panelActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActive.Location = new System.Drawing.Point(171, 47);
            this.panelActive.Name = "panelActive";
            this.panelActive.Size = new System.Drawing.Size(1079, 741);
            this.panelActive.TabIndex = 5;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 788);
            this.Controls.Add(this.panelActive);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.panelTitleBar.ResumeLayout(false);
            this.panelNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerDateTime;
        private Button buttonMinimize;
        private Button buttonRestoreDownMaximize;
        private Button buttonClose;
        private Panel panelTitleBar;
        private Panel panelNavigation;
        private Button buttonVerifyId;
        private Button buttonCheckId;
        private Button buttonCreateId;
        private Label labelDateTime;
        private Label labelInstitution;
        private Panel panelActive;
        private PictureBox pictureBoxLogo;
    }
}