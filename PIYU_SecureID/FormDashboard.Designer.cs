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
            buttonMinimize = new Button();
            buttonRestoreDownMaximize = new Button();
            buttonClose = new Button();
            panelTitleBar = new Panel();
            panel2 = new Panel();
            buttonVerifyId = new Button();
            buttonCheckId = new Button();
            buttonCreateId = new Button();
            labelDateTime = new Label();
            labelInstitution = new Label();
            panel1 = new Panel();
            panelTitleBar.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // timerDateTime
            // 
            timerDateTime.Enabled = true;
            timerDateTime.Interval = 1000;
            timerDateTime.Tick += timerDateTime_Tick;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.Transparent;
            buttonMinimize.Dock = DockStyle.Right;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.ForeColor = Color.White;
            buttonMinimize.Location = new Point(794, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(50, 35);
            buttonMinimize.TabIndex = 6;
            buttonMinimize.Text = "--";
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonRestoreDownMaximize
            // 
            buttonRestoreDownMaximize.BackColor = Color.Transparent;
            buttonRestoreDownMaximize.Dock = DockStyle.Right;
            buttonRestoreDownMaximize.FlatAppearance.BorderSize = 0;
            buttonRestoreDownMaximize.FlatStyle = FlatStyle.Flat;
            buttonRestoreDownMaximize.ForeColor = Color.White;
            buttonRestoreDownMaximize.Location = new Point(844, 0);
            buttonRestoreDownMaximize.Name = "buttonRestoreDownMaximize";
            buttonRestoreDownMaximize.Size = new Size(50, 35);
            buttonRestoreDownMaximize.TabIndex = 7;
            buttonRestoreDownMaximize.Text = "O";
            buttonRestoreDownMaximize.UseVisualStyleBackColor = false;
            buttonRestoreDownMaximize.Click += buttonRestoreDownMaximize_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.Transparent;
            buttonClose.Dock = DockStyle.Right;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.ForeColor = Color.White;
            buttonClose.Location = new Point(894, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(50, 35);
            buttonClose.TabIndex = 8;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(64, 64, 64);
            panelTitleBar.Controls.Add(buttonMinimize);
            panelTitleBar.Controls.Add(buttonRestoreDownMaximize);
            panelTitleBar.Controls.Add(buttonClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(150, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(944, 35);
            panelTitleBar.TabIndex = 9;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            panelTitleBar.MouseMove += panelTitleBar_MouseMove;
            panelTitleBar.MouseUp += panelTitleBar_MouseUp;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(buttonVerifyId);
            panel2.Controls.Add(buttonCheckId);
            panel2.Controls.Add(buttonCreateId);
            panel2.Controls.Add(labelDateTime);
            panel2.Controls.Add(labelInstitution);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 648);
            panel2.TabIndex = 0;
            // 
            // buttonVerifyId
            // 
            buttonVerifyId.Dock = DockStyle.Top;
            buttonVerifyId.FlatAppearance.BorderSize = 0;
            buttonVerifyId.FlatStyle = FlatStyle.Flat;
            buttonVerifyId.ForeColor = Color.White;
            buttonVerifyId.Location = new Point(0, 170);
            buttonVerifyId.Margin = new Padding(3, 2, 3, 2);
            buttonVerifyId.Name = "buttonVerifyId";
            buttonVerifyId.Size = new Size(150, 50);
            buttonVerifyId.TabIndex = 3;
            buttonVerifyId.Text = "VERIFY ID";
            buttonVerifyId.UseVisualStyleBackColor = true;
            // 
            // buttonCheckId
            // 
            buttonCheckId.Dock = DockStyle.Top;
            buttonCheckId.FlatAppearance.BorderSize = 0;
            buttonCheckId.FlatStyle = FlatStyle.Flat;
            buttonCheckId.ForeColor = Color.White;
            buttonCheckId.Location = new Point(0, 120);
            buttonCheckId.Margin = new Padding(3, 2, 3, 2);
            buttonCheckId.Name = "buttonCheckId";
            buttonCheckId.Size = new Size(150, 50);
            buttonCheckId.TabIndex = 2;
            buttonCheckId.Text = "CHECK ID";
            buttonCheckId.UseVisualStyleBackColor = true;
            // 
            // buttonCreateId
            // 
            buttonCreateId.Dock = DockStyle.Top;
            buttonCreateId.FlatAppearance.BorderSize = 0;
            buttonCreateId.FlatStyle = FlatStyle.Flat;
            buttonCreateId.ForeColor = Color.White;
            buttonCreateId.Location = new Point(0, 70);
            buttonCreateId.Margin = new Padding(3, 2, 3, 2);
            buttonCreateId.Name = "buttonCreateId";
            buttonCreateId.Size = new Size(150, 50);
            buttonCreateId.TabIndex = 1;
            buttonCreateId.Text = "CREATE ID";
            buttonCreateId.UseVisualStyleBackColor = true;
            // 
            // labelDateTime
            // 
            labelDateTime.Dock = DockStyle.Bottom;
            labelDateTime.ForeColor = Color.White;
            labelDateTime.Location = new Point(0, 619);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(150, 29);
            labelDateTime.TabIndex = 4;
            labelDateTime.Text = "00/00/00 00:00:00 AM";
            labelDateTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInstitution
            // 
            labelInstitution.Dock = DockStyle.Top;
            labelInstitution.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelInstitution.ForeColor = Color.White;
            labelInstitution.Location = new Point(0, 0);
            labelInstitution.Name = "labelInstitution";
            labelInstitution.Size = new Size(150, 70);
            labelInstitution.TabIndex = 0;
            labelInstitution.Text = "plan of operations: (logo)";
            labelInstitution.TextAlign = ContentAlignment.MiddleCenter;
            labelInstitution.MouseDown += labelInstitution_MouseDown;
            labelInstitution.MouseMove += labelInstitution_MouseMove;
            labelInstitution.MouseUp += labelInstitution_MouseUp;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(150, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 648);
            panel1.TabIndex = 5;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 648);
            Controls.Add(panelTitleBar);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DASHBOARD";
            panelTitleBar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerDateTime;
        private Button buttonMinimize;
        private Button buttonRestoreDownMaximize;
        private Button buttonClose;
        private Panel panelTitleBar;
        private Panel panel2;
        private Button buttonVerifyId;
        private Button buttonCheckId;
        private Button buttonCreateId;
        private Label labelDateTime;
        private Label labelInstitution;
        private Panel panel1;
    }
}