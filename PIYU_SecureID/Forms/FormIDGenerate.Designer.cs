namespace PIYU_SecureID
{
    partial class FormIDGenerate
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
            picBoxFrontBackground = new PictureBox();
            picBoxBackBackground = new PictureBox();
            lblFont = new Label();
            lblBack = new Label();
            lblLastname = new Label();
            lblMiddleName = new Label();
            lblGivenName = new Label();
            lblSuffix = new Label();
            lblSex = new Label();
            lblMaritalStatus = new Label();
            lblDateOfBirth = new Label();
            lblBloodType = new Label();
            lblAddress = new Label();
            lblGenerationDate = new Label();
            picBoxQREncrypted = new PictureBox();
            picBoxIdPhoto = new PictureBox();
            buttonPrint = new Button();
            pnlFrontId = new Panel();
            pnlBackId = new Panel();
            buttonSave = new Button();
            pnlTitleBar = new Panel();
            btnClose = new Button();
            tblPnlIdPreview = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)picBoxFrontBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBackBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxQREncrypted).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxIdPhoto).BeginInit();
            pnlFrontId.SuspendLayout();
            pnlBackId.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            tblPnlIdPreview.SuspendLayout();
            SuspendLayout();
            // 
            // picBoxFrontBackground
            // 
            picBoxFrontBackground.Dock = DockStyle.Fill;
            picBoxFrontBackground.Image = Properties.Resources.secureid_front;
            picBoxFrontBackground.Location = new Point(10, 10);
            picBoxFrontBackground.Margin = new Padding(3, 2, 3, 2);
            picBoxFrontBackground.Name = "picBoxFrontBackground";
            picBoxFrontBackground.Size = new Size(612, 376);
            picBoxFrontBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxFrontBackground.TabIndex = 0;
            picBoxFrontBackground.TabStop = false;
            // 
            // picBoxBackBackground
            // 
            picBoxBackBackground.Dock = DockStyle.Fill;
            picBoxBackBackground.Image = Properties.Resources.secureid_back;
            picBoxBackBackground.Location = new Point(5, 10);
            picBoxBackBackground.Margin = new Padding(3, 2, 3, 2);
            picBoxBackBackground.Name = "picBoxBackBackground";
            picBoxBackBackground.Size = new Size(612, 376);
            picBoxBackBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxBackBackground.TabIndex = 1;
            picBoxBackBackground.TabStop = false;
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Dock = DockStyle.Top;
            lblFont.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFont.ForeColor = Color.White;
            lblFont.Location = new Point(3, 402);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(627, 37);
            lblFont.TabIndex = 0;
            lblFont.Text = "FRONT";
            lblFont.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Dock = DockStyle.Top;
            lblBack.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBack.ForeColor = Color.White;
            lblBack.Location = new Point(636, 402);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(627, 37);
            lblBack.TabIndex = 0;
            lblBack.Text = "BACK";
            lblBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLastname
            // 
            lblLastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLastname.AutoSize = true;
            lblLastname.BackColor = Color.Transparent;
            lblLastname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastname.Location = new Point(60, 317);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(61, 21);
            lblLastname.TabIndex = 0;
            lblLastname.Text = "Tamad";
            // 
            // lblMiddleName
            // 
            lblMiddleName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMiddleName.AutoSize = true;
            lblMiddleName.BackColor = Color.Transparent;
            lblMiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMiddleName.Location = new Point(278, 358);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(64, 21);
            lblMiddleName.TabIndex = 0;
            lblMiddleName.Text = "Panget";
            // 
            // lblGivenName
            // 
            lblGivenName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblGivenName.AutoSize = true;
            lblGivenName.BackColor = Color.Transparent;
            lblGivenName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGivenName.Location = new Point(60, 358);
            lblGivenName.Name = "lblGivenName";
            lblGivenName.Size = new Size(46, 21);
            lblGivenName.TabIndex = 0;
            lblGivenName.Text = "Juan";
            // 
            // lblSuffix
            // 
            lblSuffix.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSuffix.AutoSize = true;
            lblSuffix.BackColor = Color.Transparent;
            lblSuffix.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuffix.Location = new Point(533, 358);
            lblSuffix.Name = "lblSuffix";
            lblSuffix.Size = new Size(31, 21);
            lblSuffix.TabIndex = 0;
            lblSuffix.Text = "Dr.";
            // 
            // lblSex
            // 
            lblSex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSex.AutoSize = true;
            lblSex.BackColor = Color.Transparent;
            lblSex.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSex.Location = new Point(70, 89);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(29, 20);
            lblSex.TabIndex = 0;
            lblSex.Text = "Oo";
            // 
            // lblMaritalStatus
            // 
            lblMaritalStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMaritalStatus.AutoSize = true;
            lblMaritalStatus.BackColor = Color.Transparent;
            lblMaritalStatus.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaritalStatus.Location = new Point(303, 89);
            lblMaritalStatus.Name = "lblMaritalStatus";
            lblMaritalStatus.Size = new Size(51, 20);
            lblMaritalStatus.TabIndex = 0;
            lblMaritalStatus.Text = "Secret";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.BackColor = Color.Transparent;
            lblDateOfBirth.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateOfBirth.Location = new Point(70, 143);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(82, 20);
            lblDateOfBirth.TabIndex = 0;
            lblDateOfBirth.Text = "01/01/2024";
            // 
            // lblBloodType
            // 
            lblBloodType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblBloodType.AutoSize = true;
            lblBloodType.BackColor = Color.Transparent;
            lblBloodType.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBloodType.Location = new Point(303, 143);
            lblBloodType.Name = "lblBloodType";
            lblBloodType.Size = new Size(48, 20);
            lblBloodType.TabIndex = 0;
            lblBloodType.Text = "(A+B)";
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(70, 185);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(186, 20);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Inayawan, Bangag, Talaga";
            // 
            // lblGenerationDate
            // 
            lblGenerationDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblGenerationDate.AutoSize = true;
            lblGenerationDate.BackColor = Color.Transparent;
            lblGenerationDate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenerationDate.Location = new Point(70, 224);
            lblGenerationDate.Name = "lblGenerationDate";
            lblGenerationDate.Size = new Size(65, 20);
            lblGenerationDate.TabIndex = 0;
            lblGenerationDate.Text = "12/15/23";
            // 
            // picBoxQREncrypted
            // 
            picBoxQREncrypted.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picBoxQREncrypted.BackColor = Color.White;
            picBoxQREncrypted.BorderStyle = BorderStyle.FixedSingle;
            picBoxQREncrypted.Location = new Point(296, 48);
            picBoxQREncrypted.Margin = new Padding(3, 2, 3, 2);
            picBoxQREncrypted.Name = "picBoxQREncrypted";
            picBoxQREncrypted.Size = new Size(295, 287);
            picBoxQREncrypted.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxQREncrypted.TabIndex = 14;
            picBoxQREncrypted.TabStop = false;
            // 
            // picBoxIdPhoto
            // 
            picBoxIdPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picBoxIdPhoto.BackColor = Color.White;
            picBoxIdPhoto.BorderStyle = BorderStyle.FixedSingle;
            picBoxIdPhoto.Location = new Point(93, 126);
            picBoxIdPhoto.Name = "picBoxIdPhoto";
            picBoxIdPhoto.Size = new Size(126, 126);
            picBoxIdPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxIdPhoto.TabIndex = 15;
            picBoxIdPhoto.TabStop = false;
            // 
            // buttonPrint
            // 
            buttonPrint.BackColor = Color.FromArgb(53, 69, 93);
            buttonPrint.Cursor = Cursors.Hand;
            buttonPrint.FlatAppearance.BorderSize = 0;
            buttonPrint.FlatStyle = FlatStyle.Flat;
            buttonPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrint.ForeColor = Color.White;
            buttonPrint.Location = new Point(550, 487);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(80, 40);
            buttonPrint.TabIndex = 1;
            buttonPrint.Text = "PRINT";
            buttonPrint.UseVisualStyleBackColor = false;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // pnlFrontId
            // 
            pnlFrontId.Controls.Add(picBoxIdPhoto);
            pnlFrontId.Controls.Add(picBoxQREncrypted);
            pnlFrontId.Controls.Add(lblLastname);
            pnlFrontId.Controls.Add(lblGivenName);
            pnlFrontId.Controls.Add(lblMiddleName);
            pnlFrontId.Controls.Add(lblSuffix);
            pnlFrontId.Controls.Add(picBoxFrontBackground);
            pnlFrontId.Dock = DockStyle.Fill;
            pnlFrontId.Location = new Point(3, 3);
            pnlFrontId.Name = "pnlFrontId";
            pnlFrontId.Padding = new Padding(10, 10, 5, 10);
            pnlFrontId.Size = new Size(627, 396);
            pnlFrontId.TabIndex = 0;
            // 
            // pnlBackId
            // 
            pnlBackId.Controls.Add(lblSex);
            pnlBackId.Controls.Add(lblMaritalStatus);
            pnlBackId.Controls.Add(lblDateOfBirth);
            pnlBackId.Controls.Add(lblBloodType);
            pnlBackId.Controls.Add(lblAddress);
            pnlBackId.Controls.Add(lblGenerationDate);
            pnlBackId.Controls.Add(picBoxBackBackground);
            pnlBackId.Dock = DockStyle.Fill;
            pnlBackId.Location = new Point(636, 3);
            pnlBackId.Name = "pnlBackId";
            pnlBackId.Padding = new Padding(5, 10, 10, 10);
            pnlBackId.Size = new Size(627, 396);
            pnlBackId.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(53, 69, 93);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(636, 487);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(80, 40);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(53, 69, 93);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1266, 20);
            pnlTitleBar.TabIndex = 0;
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
            btnClose.Location = new Point(1236, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 20);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // tblPnlIdPreview
            // 
            tblPnlIdPreview.BackColor = Color.FromArgb(53, 69, 93);
            tblPnlIdPreview.ColumnCount = 2;
            tblPnlIdPreview.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPnlIdPreview.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPnlIdPreview.Controls.Add(lblFont, 0, 1);
            tblPnlIdPreview.Controls.Add(lblBack, 1, 1);
            tblPnlIdPreview.Controls.Add(pnlBackId, 1, 0);
            tblPnlIdPreview.Controls.Add(pnlFrontId, 0, 0);
            tblPnlIdPreview.Dock = DockStyle.Top;
            tblPnlIdPreview.Location = new Point(0, 20);
            tblPnlIdPreview.Name = "tblPnlIdPreview";
            tblPnlIdPreview.RowCount = 2;
            tblPnlIdPreview.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPnlIdPreview.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblPnlIdPreview.Size = new Size(1266, 452);
            tblPnlIdPreview.TabIndex = 0;
            // 
            // FormIDGenerate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 543);
            Controls.Add(tblPnlIdPreview);
            Controls.Add(pnlTitleBar);
            Controls.Add(buttonSave);
            Controls.Add(buttonPrint);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormIDGenerate";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormIDGenerate_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxFrontBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxBackBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxQREncrypted).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxIdPhoto).EndInit();
            pnlFrontId.ResumeLayout(false);
            pnlFrontId.PerformLayout();
            pnlBackId.ResumeLayout(false);
            pnlBackId.PerformLayout();
            pnlTitleBar.ResumeLayout(false);
            tblPnlIdPreview.ResumeLayout(false);
            tblPnlIdPreview.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBoxFrontBackground;
        private PictureBox picBoxBackBackground;
        private Label lblFont;
        private Label lblBack;
        private Label lblLastname;
        private Label lblMiddleName;
        private Label lblGivenName;
        private Label lblSuffix;
        private Label lblSex;
        private Label lblMaritalStatus;
        private Label lblDateOfBirth;
        private Label lblBloodType;
        private Label lblAddress;
        private Label lblGenerationDate;
        private PictureBox picBoxIdPhoto;
        private Button buttonPrint;
        private Panel pnlFrontId;
        private Panel pnlBackId;
        private Button buttonSave;
        public PictureBox picBoxQREncrypted;
        private Panel pnlTitleBar;
        private Button btnClose;
        private TableLayoutPanel tblPnlIdPreview;
    }
}