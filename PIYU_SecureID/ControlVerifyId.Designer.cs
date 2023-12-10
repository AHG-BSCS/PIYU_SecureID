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
            pictureBoxQrScanner = new PictureBox();
            comboBoxCameras = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQrScanner).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxQrScanner
            // 
            pictureBoxQrScanner.Location = new Point(378, 31);
            pictureBoxQrScanner.Name = "pictureBoxQrScanner";
            pictureBoxQrScanner.Size = new Size(300, 300);
            pictureBoxQrScanner.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxQrScanner.TabIndex = 0;
            pictureBoxQrScanner.TabStop = false;
            // 
            // comboBoxCameras
            // 
            comboBoxCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCameras.FormattingEnabled = true;
            comboBoxCameras.Location = new Point(557, 337);
            comboBoxCameras.Name = "comboBoxCameras";
            comboBoxCameras.Size = new Size(121, 23);
            comboBoxCameras.TabIndex = 1;
            // 
            // ControlVerifyId
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxCameras);
            Controls.Add(pictureBoxQrScanner);
            Name = "ControlVerifyId";
            Size = new Size(1116, 633);
            ((System.ComponentModel.ISupportInitialize)pictureBoxQrScanner).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxQrScanner;
        private ComboBox comboBoxCameras;
    }
}
