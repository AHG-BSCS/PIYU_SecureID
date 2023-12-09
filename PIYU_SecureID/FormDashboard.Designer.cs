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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonVerifyId = new System.Windows.Forms.Button();
            this.buttonCheckId = new System.Windows.Forms.Button();
            this.buttonCreateId = new System.Windows.Forms.Button();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelInstitution = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(95)))), ((int)(((byte)(106)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonVerifyId);
            this.panel2.Controls.Add(this.buttonCheckId);
            this.panel2.Controls.Add(this.buttonCreateId);
            this.panel2.Controls.Add(this.labelDateTime);
            this.panel2.Controls.Add(this.labelInstitution);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 864);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PIYU_SecureID.Properties.Resources.PIYU_SecureID;
            this.pictureBox1.Location = new System.Drawing.Point(41, 735);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonVerifyId
            // 
            this.buttonVerifyId.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVerifyId.FlatAppearance.BorderSize = 0;
            this.buttonVerifyId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerifyId.ForeColor = System.Drawing.Color.White;
            this.buttonVerifyId.Location = new System.Drawing.Point(0, 227);
            this.buttonVerifyId.Name = "buttonVerifyId";
            this.buttonVerifyId.Size = new System.Drawing.Size(171, 67);
            this.buttonVerifyId.TabIndex = 3;
            this.buttonVerifyId.Text = "VERIFY ID";
            this.buttonVerifyId.UseVisualStyleBackColor = true;
            // 
            // buttonCheckId
            // 
            this.buttonCheckId.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCheckId.FlatAppearance.BorderSize = 0;
            this.buttonCheckId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckId.ForeColor = System.Drawing.Color.White;
            this.buttonCheckId.Location = new System.Drawing.Point(0, 160);
            this.buttonCheckId.Name = "buttonCheckId";
            this.buttonCheckId.Size = new System.Drawing.Size(171, 67);
            this.buttonCheckId.TabIndex = 2;
            this.buttonCheckId.Text = "CHECK ID";
            this.buttonCheckId.UseVisualStyleBackColor = true;
            // 
            // buttonCreateId
            // 
            this.buttonCreateId.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreateId.FlatAppearance.BorderSize = 0;
            this.buttonCreateId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateId.ForeColor = System.Drawing.Color.White;
            this.buttonCreateId.Location = new System.Drawing.Point(0, 93);
            this.buttonCreateId.Name = "buttonCreateId";
            this.buttonCreateId.Size = new System.Drawing.Size(171, 67);
            this.buttonCreateId.TabIndex = 1;
            this.buttonCreateId.Text = "CREATE ID";
            this.buttonCreateId.UseVisualStyleBackColor = true;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDateTime.ForeColor = System.Drawing.Color.White;
            this.labelDateTime.Location = new System.Drawing.Point(0, 825);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(171, 39);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "00/00/00 00:00:00 AM";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInstitution
            // 
            this.labelInstitution.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInstitution.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInstitution.ForeColor = System.Drawing.Color.White;
            this.labelInstitution.Location = new System.Drawing.Point(0, 0);
            this.labelInstitution.Name = "labelInstitution";
            this.labelInstitution.Size = new System.Drawing.Size(171, 93);
            this.labelInstitution.TabIndex = 0;
            this.labelInstitution.Text = "plan of operations: (logo)";
            this.labelInstitution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(171, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 864);
            this.panel1.TabIndex = 5;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 864);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.panelTitleBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private PictureBox pictureBox1;
    }
}