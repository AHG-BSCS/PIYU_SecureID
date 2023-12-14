namespace PIYU_SecureID
{
    partial class FormCamera
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
            btnSave = new Button();
            picBoxCameraDisplay = new PictureBox();
            btnClear = new Button();
            pnlCameraDisplay = new Panel();
            tblPnlControls = new TableLayoutPanel();
            pnlTitleBar = new Panel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxCameraDisplay).BeginInit();
            pnlCameraDisplay.SuspendLayout();
            tblPnlControls.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Dock = DockStyle.Fill;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(53, 69, 93);
            btnSave.Location = new Point(55, 10);
            btnSave.Margin = new Padding(45, 0, 25, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "CAPTURE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += buttonSave_Click;
            // 
            // picBoxCameraDisplay
            // 
            picBoxCameraDisplay.BackColor = Color.White;
            picBoxCameraDisplay.Dock = DockStyle.Fill;
            picBoxCameraDisplay.Location = new Point(10, 0);
            picBoxCameraDisplay.Name = "picBoxCameraDisplay";
            picBoxCameraDisplay.Size = new Size(300, 300);
            picBoxCameraDisplay.TabIndex = 1;
            picBoxCameraDisplay.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Control;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Dock = DockStyle.Fill;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.FromArgb(53, 69, 93);
            btnClear.Location = new Point(185, 10);
            btnClear.Margin = new Padding(25, 0, 45, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 40);
            btnClear.TabIndex = 2;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += buttonClear_Click;
            // 
            // pnlCameraDisplay
            // 
            pnlCameraDisplay.BackColor = Color.FromArgb(53, 69, 93);
            pnlCameraDisplay.Controls.Add(picBoxCameraDisplay);
            pnlCameraDisplay.Dock = DockStyle.Top;
            pnlCameraDisplay.Location = new Point(0, 20);
            pnlCameraDisplay.Name = "pnlCameraDisplay";
            pnlCameraDisplay.Padding = new Padding(10, 0, 10, 0);
            pnlCameraDisplay.Size = new Size(320, 300);
            pnlCameraDisplay.TabIndex = 4;
            // 
            // tblPnlControls
            // 
            tblPnlControls.BackColor = Color.FromArgb(53, 69, 93);
            tblPnlControls.ColumnCount = 2;
            tblPnlControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblPnlControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblPnlControls.Controls.Add(btnClear, 1, 0);
            tblPnlControls.Controls.Add(btnSave, 0, 0);
            tblPnlControls.Dock = DockStyle.Top;
            tblPnlControls.Location = new Point(0, 320);
            tblPnlControls.Name = "tblPnlControls";
            tblPnlControls.Padding = new Padding(10);
            tblPnlControls.RowCount = 1;
            tblPnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPnlControls.Size = new Size(320, 60);
            tblPnlControls.TabIndex = 6;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(53, 69, 93);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(320, 20);
            pnlTitleBar.TabIndex = 11;
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
            btnClose.Location = new Point(300, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.TabIndex = 8;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // FormCamera
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(320, 380);
            Controls.Add(tblPnlControls);
            Controls.Add(pnlCameraDisplay);
            Controls.Add(pnlTitleBar);
            Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCamera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Camera";
            FormClosed += FormCamera_FormClosed;
            ((System.ComponentModel.ISupportInitialize)picBoxCameraDisplay).EndInit();
            pnlCameraDisplay.ResumeLayout(false);
            tblPnlControls.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private PictureBox picBoxCameraDisplay;
        private Button btnClear;
        private Panel pnlCameraDisplay;
        private TableLayoutPanel tblPnlControls;
        private Panel pnlTitleBar;
        private Button btnClose;
    }
}