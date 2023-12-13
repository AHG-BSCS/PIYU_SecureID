namespace PIYU_SecureID
{
    partial class FormLoad
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
            picBoxApplicationLogo = new PictureBox();
            lblApplicationName = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxApplicationLogo).BeginInit();
            SuspendLayout();
            // 
            // picBoxApplicationLogo
            // 
            picBoxApplicationLogo.Image = Properties.Resources.PIYU_SecureID;
            picBoxApplicationLogo.Location = new Point(218, 113);
            picBoxApplicationLogo.Margin = new Padding(1000, 3, 1000, 3);
            picBoxApplicationLogo.Name = "picBoxApplicationLogo";
            picBoxApplicationLogo.Size = new Size(125, 125);
            picBoxApplicationLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxApplicationLogo.TabIndex = 0;
            picBoxApplicationLogo.TabStop = false;
            // 
            // lblApplicationName
            // 
            lblApplicationName.AutoSize = true;
            lblApplicationName.BackColor = Color.Transparent;
            lblApplicationName.Font = new Font("Corbel", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblApplicationName.ForeColor = Color.Black;
            lblApplicationName.Location = new Point(343, 158);
            lblApplicationName.Name = "lblApplicationName";
            lblApplicationName.Size = new Size(140, 39);
            lblApplicationName.TabIndex = 1;
            lblApplicationName.Text = "SecureID";
            // 
            // FormLoad
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 69, 93);
            ClientSize = new Size(700, 350);
            Controls.Add(picBoxApplicationLogo);
            Controls.Add(lblApplicationName);
            Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLoad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLoad";
            ((System.ComponentModel.ISupportInitialize)picBoxApplicationLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picBoxApplicationLogo;
        private Label lblApplicationName;
    }
}