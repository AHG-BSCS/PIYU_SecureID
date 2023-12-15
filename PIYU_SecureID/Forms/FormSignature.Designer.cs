namespace PIYU_SecureID
{
    partial class FormSignature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignature));
            btnSave = new Button();
            picBoxSignatureDrawing = new PictureBox();
            btnClear = new Button();
            pnlTitleBar = new Panel();
            btnClose = new Button();
            pnlCameraDisplay = new Panel();
            tblPnlControls = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)picBoxSignatureDrawing).BeginInit();
            pnlTitleBar.SuspendLayout();
            pnlCameraDisplay.SuspendLayout();
            tblPnlControls.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = SystemColors.Control;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(53, 69, 93);
            btnSave.Location = new Point(55, 10);
            btnSave.Margin = new Padding(45, 0, 25, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += buttonSave_Click;
            // 
            // picBoxSignatureDrawing
            // 
            picBoxSignatureDrawing.BackColor = Color.White;
            picBoxSignatureDrawing.Cursor = Cursors.No;
            picBoxSignatureDrawing.Dock = DockStyle.Fill;
            picBoxSignatureDrawing.Location = new Point(10, 0);
            picBoxSignatureDrawing.Name = "picBoxSignatureDrawing";
            picBoxSignatureDrawing.Size = new Size(300, 300);
            picBoxSignatureDrawing.TabIndex = 1;
            picBoxSignatureDrawing.TabStop = false;
            picBoxSignatureDrawing.MouseDown += pictureBoxSignature_MouseDown;
            picBoxSignatureDrawing.MouseMove += pictureBoxSignature_MouseMove;
            picBoxSignatureDrawing.MouseUp += pictureBoxSignature_MouseUp;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.BackColor = SystemColors.Control;
            btnClear.Cursor = Cursors.Hand;
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
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(53, 69, 93);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(320, 20);
            pnlTitleBar.TabIndex = 12;
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
            // pnlCameraDisplay
            // 
            pnlCameraDisplay.Controls.Add(picBoxSignatureDrawing);
            pnlCameraDisplay.Dock = DockStyle.Top;
            pnlCameraDisplay.Location = new Point(0, 20);
            pnlCameraDisplay.Name = "pnlCameraDisplay";
            pnlCameraDisplay.Padding = new Padding(10, 0, 10, 0);
            pnlCameraDisplay.Size = new Size(320, 300);
            pnlCameraDisplay.TabIndex = 13;
            // 
            // tblPnlControls
            // 
            tblPnlControls.ColumnCount = 2;
            tblPnlControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPnlControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPnlControls.Controls.Add(btnSave, 0, 0);
            tblPnlControls.Controls.Add(btnClear, 1, 0);
            tblPnlControls.Dock = DockStyle.Top;
            tblPnlControls.Location = new Point(0, 320);
            tblPnlControls.Name = "tblPnlControls";
            tblPnlControls.Padding = new Padding(10);
            tblPnlControls.RowCount = 1;
            tblPnlControls.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPnlControls.Size = new Size(320, 60);
            tblPnlControls.TabIndex = 14;
            // 
            // FormSignature
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 69, 93);
            ClientSize = new Size(320, 380);
            Controls.Add(tblPnlControls);
            Controls.Add(pnlCameraDisplay);
            Controls.Add(pnlTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSignature";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signature";
            ((System.ComponentModel.ISupportInitialize)picBoxSignatureDrawing).EndInit();
            pnlTitleBar.ResumeLayout(false);
            pnlCameraDisplay.ResumeLayout(false);
            tblPnlControls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private PictureBox picBoxSignatureDrawing;
        private Button btnClear;
        private Panel pnlTitleBar;
        private Button btnClose;
        private Panel pnlCameraDisplay;
        private TableLayoutPanel tblPnlControls;
    }
}