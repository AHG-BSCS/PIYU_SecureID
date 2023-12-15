namespace PIYU_SecureID
{
    partial class FormVerificationInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerificationInfo));
            picBoxAppLogo = new PictureBox();
            pnlTransactionSlip = new Panel();
            picBoxQRCode = new PictureBox();
            lblNoteText = new Label();
            lblNote = new Label();
            lblInformationText = new Label();
            lblInformation = new Label();
            lblTransactionNumber = new Label();
            lblName = new Label();
            lblBrand = new Label();
            lblRepublic = new Label();
            lblDocumentTitle = new Label();
            btnSave = new Button();
            btnPrint = new Button();
            pnlControls = new Panel();
            buttonCopyTN = new Button();
            pnlTitleBar = new Panel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxAppLogo).BeginInit();
            pnlTransactionSlip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxQRCode).BeginInit();
            pnlControls.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // picBoxAppLogo
            // 
            picBoxAppLogo.Image = Properties.Resources.PIYU_SecureID;
            picBoxAppLogo.InitialImage = Properties.Resources.PIYU_SecureID;
            picBoxAppLogo.Location = new Point(30, 30);
            picBoxAppLogo.Name = "picBoxAppLogo";
            picBoxAppLogo.Size = new Size(90, 90);
            picBoxAppLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxAppLogo.TabIndex = 0;
            picBoxAppLogo.TabStop = false;
            // 
            // pnlTransactionSlip
            // 
            pnlTransactionSlip.BackColor = Color.White;
            pnlTransactionSlip.Controls.Add(picBoxAppLogo);
            pnlTransactionSlip.Controls.Add(picBoxQRCode);
            pnlTransactionSlip.Controls.Add(lblNoteText);
            pnlTransactionSlip.Controls.Add(lblNote);
            pnlTransactionSlip.Controls.Add(lblInformationText);
            pnlTransactionSlip.Controls.Add(lblInformation);
            pnlTransactionSlip.Controls.Add(lblTransactionNumber);
            pnlTransactionSlip.Controls.Add(lblName);
            pnlTransactionSlip.Controls.Add(lblBrand);
            pnlTransactionSlip.Controls.Add(lblRepublic);
            pnlTransactionSlip.Controls.Add(lblDocumentTitle);
            pnlTransactionSlip.Dock = DockStyle.Left;
            pnlTransactionSlip.Location = new Point(20, 20);
            pnlTransactionSlip.Name = "pnlTransactionSlip";
            pnlTransactionSlip.Size = new Size(750, 431);
            pnlTransactionSlip.TabIndex = 1;
            // 
            // picBoxQRCode
            // 
            picBoxQRCode.InitialImage = Properties.Resources.PIYU_SecureID;
            picBoxQRCode.Location = new Point(544, 6);
            picBoxQRCode.Name = "picBoxQRCode";
            picBoxQRCode.Size = new Size(200, 200);
            picBoxQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxQRCode.TabIndex = 8;
            picBoxQRCode.TabStop = false;
            // 
            // lblNoteText
            // 
            lblNoteText.AutoSize = true;
            lblNoteText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNoteText.Location = new Point(77, 380);
            lblNoteText.Name = "lblNoteText";
            lblNoteText.Size = new Size(597, 21);
            lblNoteText.TabIndex = 0;
            lblNoteText.Text = "Please keep your transaction number and QR code safe, secure, and confidential.";
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNote.Location = new Point(41, 359);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(668, 21);
            lblNote.TabIndex = 0;
            lblNote.Text = "NOTE: DO NOT SHARE YOUR TRANSACTION SLIP TO ANYONE OR POST ON SOCIAL MEDIA";
            // 
            // lblInformationText
            // 
            lblInformationText.AutoSize = true;
            lblInformationText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInformationText.Location = new Point(54, 230);
            lblInformationText.Name = "lblInformationText";
            lblInformationText.Size = new Size(507, 105);
            lblInformationText.TabIndex = 0;
            lblInformationText.Text = resources.GetString("lblInformationText.Text");
            // 
            // lblInformation
            // 
            lblInformation.AutoSize = true;
            lblInformation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformation.Location = new Point(30, 209);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new Size(124, 21);
            lblInformation.TabIndex = 0;
            lblInformation.Text = "INFORMATION:";
            // 
            // lblTransactionNumber
            // 
            lblTransactionNumber.AutoSize = true;
            lblTransactionNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTransactionNumber.Location = new Point(30, 170);
            lblTransactionNumber.Name = "lblTransactionNumber";
            lblTransactionNumber.Size = new Size(158, 21);
            lblTransactionNumber.TabIndex = 0;
            lblTransactionNumber.Text = "Transaction Number: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(30, 142);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Name: ";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBrand.Location = new Point(333, 72);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(76, 21);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Secure ID";
            // 
            // lblRepublic
            // 
            lblRepublic.AutoSize = true;
            lblRepublic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRepublic.Location = new Point(278, 51);
            lblRepublic.Name = "lblRepublic";
            lblRepublic.Size = new Size(194, 21);
            lblRepublic.TabIndex = 0;
            lblRepublic.Text = "Republic of the Philippines";
            // 
            // lblDocumentTitle
            // 
            lblDocumentTitle.AutoSize = true;
            lblDocumentTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumentTitle.Location = new Point(254, 30);
            lblDocumentTitle.Name = "lblDocumentTitle";
            lblDocumentTitle.Size = new Size(242, 21);
            lblDocumentTitle.TabIndex = 0;
            lblDocumentTitle.Text = "SECURE ID TRANSACTION SLIP";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(53, 69, 93);
            btnSave.Location = new Point(10, 342);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(76, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += buttonSave_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.White;
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.Dock = DockStyle.Bottom;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.FromArgb(53, 69, 93);
            btnPrint.Location = new Point(10, 391);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(76, 40);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "PRINT";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += buttonPrint_Click;
            // 
            // pnlControls
            // 
            pnlControls.Controls.Add(buttonCopyTN);
            pnlControls.Controls.Add(btnSave);
            pnlControls.Controls.Add(btnPrint);
            pnlControls.Dock = DockStyle.Left;
            pnlControls.Location = new Point(770, 20);
            pnlControls.Name = "pnlControls";
            pnlControls.Padding = new Padding(10, 0, 10, 0);
            pnlControls.Size = new Size(96, 431);
            pnlControls.TabIndex = 0;
            // 
            // buttonCopyTN
            // 
            buttonCopyTN.BackColor = Color.White;
            buttonCopyTN.Cursor = Cursors.Hand;
            buttonCopyTN.FlatAppearance.BorderSize = 0;
            buttonCopyTN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCopyTN.ForeColor = Color.FromArgb(53, 69, 93);
            buttonCopyTN.Location = new Point(10, 291);
            buttonCopyTN.Name = "buttonCopyTN";
            buttonCopyTN.Size = new Size(76, 40);
            buttonCopyTN.TabIndex = 3;
            buttonCopyTN.Text = "COPY";
            buttonCopyTN.UseVisualStyleBackColor = false;
            buttonCopyTN.Click += buttonCopyTN_Click;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(53, 69, 93);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(20, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(845, 20);
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
            btnClose.Location = new Point(815, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 20);
            btnClose.TabIndex = 8;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // FormVerificationInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 69, 93);
            ClientSize = new Size(865, 471);
            Controls.Add(pnlControls);
            Controls.Add(pnlTransactionSlip);
            Controls.Add(pnlTitleBar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVerificationInfo";
            Padding = new Padding(20, 0, 0, 20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVerificationInfo";
            ((System.ComponentModel.ISupportInitialize)picBoxAppLogo).EndInit();
            pnlTransactionSlip.ResumeLayout(false);
            pnlTransactionSlip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxQRCode).EndInit();
            pnlControls.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picBoxAppLogo;
        private Panel pnlTransactionSlip;
        private Button btnSave;
        private Button btnPrint;
        private Label lblNoteText;
        private Label lblNote;
        private Label lblTransactionNumber;
        private Label lblName;
        private Label lblBrand;
        private Label lblRepublic;
        private Label lblDocumentTitle;
        private Label lblInformationText;
        private Label lblInformation;
        private PictureBox picBoxQRCode;
        private Panel pnlControls;
        private Panel pnlTitleBar;
        private Button btnClose;
        private Button buttonCopyTN;
    }
}