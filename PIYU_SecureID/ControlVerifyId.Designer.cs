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
            ((System.ComponentModel.ISupportInitialize)pictureBoxQrScanner).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxQrScanner
            // 
            pictureBoxQrScanner.Location = new Point(383, 83);
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
            comboBoxCameras.Location = new Point(261, 354);
            comboBoxCameras.Name = "comboBoxCameras";
            comboBoxCameras.Size = new Size(116, 29);
            comboBoxCameras.TabIndex = 1;
            // 
            // buttonStartStop
            // 
            buttonStartStop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStartStop.Location = new Point(261, 311);
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
            textBoxTransactionNum.Location = new Point(383, 389);
            textBoxTransactionNum.MaxLength = 1000;
            textBoxTransactionNum.Multiline = true;
            textBoxTransactionNum.Name = "textBoxTransactionNum";
            textBoxTransactionNum.Size = new Size(300, 42);
            textBoxTransactionNum.TabIndex = 3;
            textBoxTransactionNum.TextAlign = HorizontalAlignment.Center;
            textBoxTransactionNum.Visible = false;
            textBoxTransactionNum.TextChanged += textBoxTransactionNum_TextChanged;
            // 
            // ControlVerifyId
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxTransactionNum);
            Controls.Add(buttonStartStop);
            Controls.Add(comboBoxCameras);
            Controls.Add(pictureBoxQrScanner);
            Name = "ControlVerifyId";
            Size = new Size(1116, 633);
            Leave += ControlVerifyId_Leave;
            ((System.ComponentModel.ISupportInitialize)pictureBoxQrScanner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxQrScanner;
        private ComboBox comboBoxCameras;
        private Button buttonStartStop;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBoxTransactionNum;
    }
}
