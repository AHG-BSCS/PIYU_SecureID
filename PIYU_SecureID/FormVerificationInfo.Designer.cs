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
            pictureBox1 = new PictureBox();
            panelMain = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBoxQRCode = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            labelTransactionNum = new Label();
            labelName = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonSave = new Button();
            buttonPrint = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PIYU_SecureID;
            pictureBox1.InitialImage = Properties.Resources.PIYU_SecureID;
            pictureBox1.Location = new Point(29, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(label9);
            panelMain.Controls.Add(label8);
            panelMain.Controls.Add(pictureBoxQRCode);
            panelMain.Controls.Add(label7);
            panelMain.Controls.Add(label6);
            panelMain.Controls.Add(labelTransactionNum);
            panelMain.Controls.Add(labelName);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(pictureBox1);
            panelMain.Location = new Point(12, 12);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(776, 459);
            panelMain.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(55, 326);
            label9.Name = "label9";
            label9.Size = new Size(680, 84);
            label9.TabIndex = 10;
            label9.Text = resources.GetString("label9.Text");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(29, 303);
            label8.Name = "label8";
            label8.Size = new Size(124, 21);
            label8.TabIndex = 9;
            label8.Text = "INFORMATION:";
            // 
            // pictureBoxQRCode
            // 
            pictureBoxQRCode.InitialImage = Properties.Resources.PIYU_SecureID;
            pictureBoxQRCode.Location = new Point(582, 3);
            pictureBoxQRCode.Name = "pictureBoxQRCode";
            pictureBoxQRCode.Size = new Size(191, 188);
            pictureBoxQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxQRCode.TabIndex = 8;
            pictureBoxQRCode.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(83, 255);
            label7.Name = "label7";
            label7.Size = new Size(597, 21);
            label7.TabIndex = 7;
            label7.Text = "Please keep your transaction number and QR code safe, secure, and confidential.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(55, 234);
            label6.Name = "label6";
            label6.Size = new Size(668, 21);
            label6.TabIndex = 6;
            label6.Text = "NOTE: DO NOT SHARE YOUR TRANSACTION SLIP TO ANYONE OR POST ON SOCIAL MEDIA";
            // 
            // labelTransactionNum
            // 
            labelTransactionNum.AutoSize = true;
            labelTransactionNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTransactionNum.Location = new Point(29, 194);
            labelTransactionNum.Name = "labelTransactionNum";
            labelTransactionNum.Size = new Size(158, 21);
            labelTransactionNum.TabIndex = 5;
            labelTransactionNum.Text = "Transaction Number: ";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(29, 158);
            labelName.Name = "labelName";
            labelName.Size = new Size(59, 21);
            labelName.TabIndex = 4;
            labelName.Text = "Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(137, 66);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 3;
            label3.Text = "SECURE ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(135, 45);
            label2.Name = "label2";
            label2.Size = new Size(194, 21);
            label2.TabIndex = 2;
            label2.Text = "Republic of the Philippines";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 104);
            label1.Name = "label1";
            label1.Size = new Size(242, 21);
            label1.TabIndex = 1;
            label1.Text = "SECURE ID TRANSACTION SLIP";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(794, 326);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(97, 48);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonPrint
            // 
            buttonPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPrint.FlatAppearance.BorderSize = 0;
            buttonPrint.FlatStyle = FlatStyle.Flat;
            buttonPrint.ForeColor = Color.White;
            buttonPrint.Location = new Point(794, 379);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(97, 48);
            buttonPrint.TabIndex = 3;
            buttonPrint.Text = "PRINT";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(794, 431);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(97, 48);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "CANCEL";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormVerificationInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 69, 93);
            ClientSize = new Size(894, 483);
            Controls.Add(buttonCancel);
            Controls.Add(buttonPrint);
            Controls.Add(buttonSave);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVerificationInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVerificationInfo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelMain;
        private Button buttonSave;
        private Button buttonPrint;
        private Label label7;
        private Label label6;
        private Label labelTransactionNum;
        private Label labelName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonCancel;
        private Label label9;
        private Label label8;
        private PictureBox pictureBoxQRCode;
    }
}