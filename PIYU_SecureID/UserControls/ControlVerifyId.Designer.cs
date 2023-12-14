namespace PIYU_SecureID
{
    partial class ControlVerifyId
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBoxQrScanner = new PictureBox();
            comboBoxCameras = new ComboBox();
            buttonStartStop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            textBoxTransactionNum = new TextBox();
            panelInfo = new Panel();
            panel12 = new Panel();
            labelDateIssued = new Label();
            label13 = new Label();
            panel11 = new Panel();
            labelSex = new Label();
            label11 = new Label();
            panel10 = new Panel();
            labelBloodType = new Label();
            label10 = new Label();
            panel9 = new Panel();
            labelDateOfBirth = new Label();
            label8 = new Label();
            panel8 = new Panel();
            labelMaritalStatus = new Label();
            label9 = new Label();
            panel7 = new Panel();
            labelBarangay = new Label();
            label5 = new Label();
            panel6 = new Panel();
            labelCity = new Label();
            label6 = new Label();
            panel5 = new Panel();
            labelProvince = new Label();
            label7 = new Label();
            panel4 = new Panel();
            labelSuffix = new Label();
            label4 = new Label();
            panel3 = new Panel();
            labelMiddleName = new Label();
            label3 = new Label();
            panel2 = new Panel();
            labelGivenName = new Label();
            label2 = new Label();
            panel1 = new Panel();
            labelLastName = new Label();
            label1 = new Label();
            pictureBoxIdPhoto = new PictureBox();
            pictureBoxSign = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQrScanner).BeginInit();
            panelInfo.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIdPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSign).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxQrScanner
            // 
            pictureBoxQrScanner.Location = new Point(22, 58);
            pictureBoxQrScanner.Name = "pictureBoxQrScanner";
            pictureBoxQrScanner.Size = new Size(300, 300);
            pictureBoxQrScanner.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxQrScanner.TabIndex = 0;
            pictureBoxQrScanner.TabStop = false;
            // 
            // comboBoxCameras
            // 
            comboBoxCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCameras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCameras.FormattingEnabled = true;
            comboBoxCameras.Location = new Point(144, 364);
            comboBoxCameras.Name = "comboBoxCameras";
            comboBoxCameras.Size = new Size(178, 29);
            comboBoxCameras.TabIndex = 1;
            // 
            // buttonStartStop
            // 
            buttonStartStop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStartStop.Location = new Point(22, 364);
            buttonStartStop.Name = "buttonStartStop";
            buttonStartStop.Size = new Size(116, 36);
            buttonStartStop.TabIndex = 2;
            buttonStartStop.Text = "START";
            buttonStartStop.UseVisualStyleBackColor = true;
            buttonStartStop.Click += buttonStartStop_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // textBoxTransactionNum
            // 
            textBoxTransactionNum.Enabled = false;
            textBoxTransactionNum.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTransactionNum.Location = new Point(22, 406);
            textBoxTransactionNum.MaxLength = 1000;
            textBoxTransactionNum.Multiline = true;
            textBoxTransactionNum.Name = "textBoxTransactionNum";
            textBoxTransactionNum.Size = new Size(300, 42);
            textBoxTransactionNum.TabIndex = 3;
            textBoxTransactionNum.TextAlign = HorizontalAlignment.Center;
            textBoxTransactionNum.Visible = false;
            // 
            // panelInfo
            // 
            panelInfo.BorderStyle = BorderStyle.FixedSingle;
            panelInfo.Controls.Add(panel12);
            panelInfo.Controls.Add(panel11);
            panelInfo.Controls.Add(panel10);
            panelInfo.Controls.Add(panel9);
            panelInfo.Controls.Add(panel8);
            panelInfo.Controls.Add(panel7);
            panelInfo.Controls.Add(panel6);
            panelInfo.Controls.Add(panel5);
            panelInfo.Controls.Add(panel4);
            panelInfo.Controls.Add(panel3);
            panelInfo.Controls.Add(panel2);
            panelInfo.Controls.Add(panel1);
            panelInfo.Controls.Add(pictureBoxIdPhoto);
            panelInfo.Controls.Add(pictureBoxSign);
            panelInfo.Location = new Point(328, 59);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(765, 554);
            panelInfo.TabIndex = 16;
            panelInfo.Visible = false;
            // 
            // panel12
            // 
            panel12.Controls.Add(labelDateIssued);
            panel12.Controls.Add(label13);
            panel12.Location = new Point(438, 286);
            panel12.Name = "panel12";
            panel12.Size = new Size(306, 21);
            panel12.TabIndex = 37;
            // 
            // labelDateIssued
            // 
            labelDateIssued.AutoSize = true;
            labelDateIssued.Dock = DockStyle.Left;
            labelDateIssued.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDateIssued.Location = new Point(115, 0);
            labelDateIssued.Name = "labelDateIssued";
            labelDateIssued.Size = new Size(0, 21);
            labelDateIssued.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Left;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(115, 21);
            label13.TabIndex = 23;
            label13.Text = "Date Issued    :";
            // 
            // panel11
            // 
            panel11.Controls.Add(labelSex);
            panel11.Controls.Add(label11);
            panel11.Location = new Point(438, 89);
            panel11.Name = "panel11";
            panel11.Size = new Size(306, 21);
            panel11.TabIndex = 36;
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Dock = DockStyle.Left;
            labelSex.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSex.Location = new Point(120, 0);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(0, 21);
            labelSex.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Left;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 21);
            label11.TabIndex = 25;
            label11.Text = "Sex                   : ";
            // 
            // panel10
            // 
            panel10.Controls.Add(labelBloodType);
            panel10.Controls.Add(label10);
            panel10.Location = new Point(438, 131);
            panel10.Name = "panel10";
            panel10.Size = new Size(306, 21);
            panel10.TabIndex = 35;
            // 
            // labelBloodType
            // 
            labelBloodType.AutoSize = true;
            labelBloodType.Dock = DockStyle.Left;
            labelBloodType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBloodType.Location = new Point(121, 0);
            labelBloodType.Name = "labelBloodType";
            labelBloodType.Size = new Size(0, 21);
            labelBloodType.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Left;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(121, 21);
            label10.TabIndex = 22;
            label10.Text = "Blood Type     : ";
            // 
            // panel9
            // 
            panel9.Controls.Add(labelDateOfBirth);
            panel9.Controls.Add(label8);
            panel9.Location = new Point(438, 173);
            panel9.Name = "panel9";
            panel9.Size = new Size(306, 21);
            panel9.TabIndex = 34;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Dock = DockStyle.Left;
            labelDateOfBirth.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDateOfBirth.Location = new Point(119, 0);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(0, 21);
            labelDateOfBirth.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(119, 21);
            label8.TabIndex = 24;
            label8.Text = "Date of Birth  : ";
            // 
            // panel8
            // 
            panel8.Controls.Add(labelMaritalStatus);
            panel8.Controls.Add(label9);
            panel8.Location = new Point(438, 244);
            panel8.Name = "panel8";
            panel8.Size = new Size(306, 21);
            panel8.TabIndex = 33;
            // 
            // labelMaritalStatus
            // 
            labelMaritalStatus.AutoSize = true;
            labelMaritalStatus.Dock = DockStyle.Left;
            labelMaritalStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMaritalStatus.Location = new Point(118, 0);
            labelMaritalStatus.Name = "labelMaritalStatus";
            labelMaritalStatus.Size = new Size(0, 21);
            labelMaritalStatus.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Left;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(118, 21);
            label9.TabIndex = 23;
            label9.Text = "Marital Status: ";
            // 
            // panel7
            // 
            panel7.Controls.Add(labelBarangay);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(31, 328);
            panel7.Name = "panel7";
            panel7.Size = new Size(392, 21);
            panel7.TabIndex = 32;
            // 
            // labelBarangay
            // 
            labelBarangay.AutoSize = true;
            labelBarangay.Dock = DockStyle.Left;
            labelBarangay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBarangay.Location = new Point(113, 0);
            labelBarangay.Name = "labelBarangay";
            labelBarangay.Size = new Size(0, 21);
            labelBarangay.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 21);
            label5.TabIndex = 21;
            label5.Text = "Barangay       : ";
            // 
            // panel6
            // 
            panel6.Controls.Add(labelCity);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(31, 286);
            panel6.Name = "panel6";
            panel6.Size = new Size(392, 21);
            panel6.TabIndex = 31;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Dock = DockStyle.Left;
            labelCity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCity.Location = new Point(114, 0);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(0, 21);
            labelCity.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(114, 21);
            label6.TabIndex = 20;
            label6.Text = "City                 : ";
            // 
            // panel5
            // 
            panel5.Controls.Add(labelProvince);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(31, 244);
            panel5.Name = "panel5";
            panel5.Size = new Size(392, 21);
            panel5.TabIndex = 30;
            // 
            // labelProvince
            // 
            labelProvince.AutoSize = true;
            labelProvince.Dock = DockStyle.Left;
            labelProvince.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelProvince.Location = new Point(113, 0);
            labelProvince.Name = "labelProvince";
            labelProvince.Size = new Size(0, 21);
            labelProvince.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(113, 21);
            label7.TabIndex = 19;
            label7.Text = "Province        : ";
            // 
            // panel4
            // 
            panel4.Controls.Add(labelSuffix);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(31, 173);
            panel4.Name = "panel4";
            panel4.Size = new Size(392, 21);
            panel4.TabIndex = 29;
            // 
            // labelSuffix
            // 
            labelSuffix.AutoSize = true;
            labelSuffix.Dock = DockStyle.Left;
            labelSuffix.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSuffix.Location = new Point(116, 0);
            labelSuffix.Name = "labelSuffix";
            labelSuffix.Size = new Size(0, 21);
            labelSuffix.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 21);
            label4.TabIndex = 18;
            label4.Text = "Suffix              : ";
            // 
            // panel3
            // 
            panel3.Controls.Add(labelMiddleName);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(31, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(392, 21);
            panel3.TabIndex = 28;
            // 
            // labelMiddleName
            // 
            labelMiddleName.AutoSize = true;
            labelMiddleName.Dock = DockStyle.Left;
            labelMiddleName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMiddleName.Location = new Point(117, 0);
            labelMiddleName.Name = "labelMiddleName";
            labelMiddleName.Size = new Size(0, 21);
            labelMiddleName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 17;
            label3.Text = "Middle Name: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelGivenName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(31, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 21);
            panel2.TabIndex = 27;
            // 
            // labelGivenName
            // 
            labelGivenName.AutoSize = true;
            labelGivenName.Dock = DockStyle.Left;
            labelGivenName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGivenName.Location = new Point(118, 0);
            labelGivenName.Name = "labelGivenName";
            labelGivenName.Size = new Size(0, 21);
            labelGivenName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 16;
            label2.Text = "Given Name   : ";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelLastName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(31, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 21);
            panel1.TabIndex = 26;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Dock = DockStyle.Left;
            labelLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLastName.Location = new Point(118, 0);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(0, 21);
            labelLastName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 15;
            label1.Text = "Last Name      : ";
            // 
            // pictureBoxIdPhoto
            // 
            pictureBoxIdPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxIdPhoto.Location = new Point(438, 384);
            pictureBoxIdPhoto.Name = "pictureBoxIdPhoto";
            pictureBoxIdPhoto.Size = new Size(150, 150);
            pictureBoxIdPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIdPhoto.TabIndex = 14;
            pictureBoxIdPhoto.TabStop = false;
            // 
            // pictureBoxSign
            // 
            pictureBoxSign.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxSign.Location = new Point(594, 384);
            pictureBoxSign.Name = "pictureBoxSign";
            pictureBoxSign.Size = new Size(150, 150);
            pictureBoxSign.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSign.TabIndex = 13;
            pictureBoxSign.TabStop = false;
            // 
            // ControlVerifyId
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelInfo);
            Controls.Add(textBoxTransactionNum);
            Controls.Add(buttonStartStop);
            Controls.Add(comboBoxCameras);
            Controls.Add(pictureBoxQrScanner);
            Name = "ControlVerifyId";
            Size = new Size(1116, 628);
            Leave += ControlVerifyId_Leave;
            ((System.ComponentModel.ISupportInitialize)pictureBoxQrScanner).EndInit();
            panelInfo.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIdPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSign).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxQrScanner;
        private ComboBox comboBoxCameras;
        private Button buttonStartStop;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBoxTransactionNum;
        private Panel panelInfo;
        private Panel panel11;
        private Label labelSex;
        private Label label11;
        private Panel panel10;
        private Label labelBloodType;
        private Label label10;
        private Panel panel9;
        private Label labelDateOfBirth;
        private Label label8;
        private Panel panel8;
        private Label labelMaritalStatus;
        private Label label9;
        private Panel panel7;
        private Label labelBarangay;
        private Label label5;
        private Panel panel6;
        private Label labelCity;
        private Label label6;
        private Panel panel5;
        private Label labelProvince;
        private Label label7;
        private Panel panel4;
        private Label labelSuffix;
        private Label label4;
        private Panel panel3;
        private Label labelMiddleName;
        private Label label3;
        private Panel panel2;
        private Label labelGivenName;
        private Label label2;
        private Panel panel1;
        private Label labelLastName;
        private Label label1;
        private PictureBox pictureBoxIdPhoto;
        private PictureBox pictureBoxSign;
        private Panel panel12;
        private Label labelDateIssued;
        private Label label13;
    }
}
