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
            this.picBoxAppLogo = new System.Windows.Forms.PictureBox();
            this.pnlTransactionSlip = new System.Windows.Forms.Panel();
            this.picBoxQRCode = new System.Windows.Forms.PictureBox();
            this.lblNoteText = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblInformationText = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblTransactionNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblRepublic = new System.Windows.Forms.Label();
            this.lblDocumentTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.buttonCopyTN = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAppLogo)).BeginInit();
            this.pnlTransactionSlip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQRCode)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxAppLogo
            // 
            this.picBoxAppLogo.Image = global::PIYU_SecureID.Properties.Resources.PIYU_SecureID;
            this.picBoxAppLogo.InitialImage = global::PIYU_SecureID.Properties.Resources.PIYU_SecureID;
            this.picBoxAppLogo.Location = new System.Drawing.Point(34, 40);
            this.picBoxAppLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxAppLogo.Name = "picBoxAppLogo";
            this.picBoxAppLogo.Size = new System.Drawing.Size(103, 120);
            this.picBoxAppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAppLogo.TabIndex = 0;
            this.picBoxAppLogo.TabStop = false;
            // 
            // pnlTransactionSlip
            // 
            this.pnlTransactionSlip.BackColor = System.Drawing.Color.White;
            this.pnlTransactionSlip.Controls.Add(this.picBoxAppLogo);
            this.pnlTransactionSlip.Controls.Add(this.picBoxQRCode);
            this.pnlTransactionSlip.Controls.Add(this.lblNoteText);
            this.pnlTransactionSlip.Controls.Add(this.lblNote);
            this.pnlTransactionSlip.Controls.Add(this.lblInformationText);
            this.pnlTransactionSlip.Controls.Add(this.lblInformation);
            this.pnlTransactionSlip.Controls.Add(this.lblTransactionNumber);
            this.pnlTransactionSlip.Controls.Add(this.lblName);
            this.pnlTransactionSlip.Controls.Add(this.lblBrand);
            this.pnlTransactionSlip.Controls.Add(this.lblRepublic);
            this.pnlTransactionSlip.Controls.Add(this.lblDocumentTitle);
            this.pnlTransactionSlip.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTransactionSlip.Location = new System.Drawing.Point(23, 27);
            this.pnlTransactionSlip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTransactionSlip.Name = "pnlTransactionSlip";
            this.pnlTransactionSlip.Size = new System.Drawing.Size(857, 546);
            this.pnlTransactionSlip.TabIndex = 1;
            // 
            // picBoxQRCode
            // 
            this.picBoxQRCode.InitialImage = global::PIYU_SecureID.Properties.Resources.PIYU_SecureID;
            this.picBoxQRCode.Location = new System.Drawing.Point(633, 8);
            this.picBoxQRCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxQRCode.Name = "picBoxQRCode";
            this.picBoxQRCode.Size = new System.Drawing.Size(217, 253);
            this.picBoxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxQRCode.TabIndex = 8;
            this.picBoxQRCode.TabStop = false;
            // 
            // lblNoteText
            // 
            this.lblNoteText.AutoSize = true;
            this.lblNoteText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoteText.Location = new System.Drawing.Point(88, 479);
            this.lblNoteText.Name = "lblNoteText";
            this.lblNoteText.Size = new System.Drawing.Size(751, 28);
            this.lblNoteText.TabIndex = 0;
            this.lblNoteText.Text = "Please keep your transaction number and QR code safe, secure, and confidential.";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNote.Location = new System.Drawing.Point(47, 451);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(840, 28);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "NOTE: DO NOT SHARE YOUR TRANSACTION SLIP TO ANYONE OR POST ON SOCIAL MEDIA";
            // 
            // lblInformationText
            // 
            this.lblInformationText.AutoSize = true;
            this.lblInformationText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInformationText.Location = new System.Drawing.Point(62, 307);
            this.lblInformationText.Name = "lblInformationText";
            this.lblInformationText.Size = new System.Drawing.Size(831, 112);
            this.lblInformationText.TabIndex = 0;
            this.lblInformationText.Text = resources.GetString("lblInformationText.Text");
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInformation.Location = new System.Drawing.Point(34, 279);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(152, 28);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "INFORMATION:";
            // 
            // lblTransactionNumber
            // 
            this.lblTransactionNumber.AutoSize = true;
            this.lblTransactionNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTransactionNumber.Location = new System.Drawing.Point(34, 227);
            this.lblTransactionNumber.Name = "lblTransactionNumber";
            this.lblTransactionNumber.Size = new System.Drawing.Size(196, 28);
            this.lblTransactionNumber.TabIndex = 0;
            this.lblTransactionNumber.Text = "Transaction Number: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(34, 189);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.Location = new System.Drawing.Point(381, 96);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(94, 28);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Secure ID";
            // 
            // lblRepublic
            // 
            this.lblRepublic.AutoSize = true;
            this.lblRepublic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRepublic.Location = new System.Drawing.Point(318, 68);
            this.lblRepublic.Name = "lblRepublic";
            this.lblRepublic.Size = new System.Drawing.Size(243, 28);
            this.lblRepublic.TabIndex = 0;
            this.lblRepublic.Text = "Republic of the Philippines";
            // 
            // lblDocumentTitle
            // 
            this.lblDocumentTitle.AutoSize = true;
            this.lblDocumentTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDocumentTitle.Location = new System.Drawing.Point(290, 40);
            this.lblDocumentTitle.Name = "lblDocumentTitle";
            this.lblDocumentTitle.Size = new System.Drawing.Size(303, 28);
            this.lblDocumentTitle.TabIndex = 0;
            this.lblDocumentTitle.Text = "SECURE ID TRANSACTION SLIP";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(93)))));
            this.btnSave.Location = new System.Drawing.Point(11, 425);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 53);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(93)))));
            this.btnPrint.Location = new System.Drawing.Point(11, 493);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 53);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.buttonCopyTN);
            this.pnlControls.Controls.Add(this.btnSave);
            this.pnlControls.Controls.Add(this.btnPrint);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(880, 27);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.pnlControls.Size = new System.Drawing.Size(110, 546);
            this.pnlControls.TabIndex = 0;
            // 
            // buttonCopyTN
            // 
            this.buttonCopyTN.BackColor = System.Drawing.Color.White;
            this.buttonCopyTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCopyTN.FlatAppearance.BorderSize = 0;
            this.buttonCopyTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCopyTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(93)))));
            this.buttonCopyTN.Location = new System.Drawing.Point(11, 347);
            this.buttonCopyTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCopyTN.Name = "buttonCopyTN";
            this.buttonCopyTN.Size = new System.Drawing.Size(87, 72);
            this.buttonCopyTN.TabIndex = 3;
            this.buttonCopyTN.Text = "COPY TN";
            this.buttonCopyTN.UseVisualStyleBackColor = false;
            this.buttonCopyTN.Click += new System.EventHandler(this.buttonCopyTN_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(93)))));
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(23, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(966, 27);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::PIYU_SecureID.Properties.Resources.icons_close;
            this.btnClose.Location = new System.Drawing.Point(943, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // FormVerificationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(69)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(989, 600);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlTransactionSlip);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormVerificationInfo";
            this.Padding = new System.Windows.Forms.Padding(23, 0, 0, 27);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVerificationInfo";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAppLogo)).EndInit();
            this.pnlTransactionSlip.ResumeLayout(false);
            this.pnlTransactionSlip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQRCode)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

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