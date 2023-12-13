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
            picBoxAppLogo = new PictureBox();
            lblAppName = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxAppLogo).BeginInit();
            SuspendLayout();
            // 
            // picBoxAppLogo
            // 
            picBoxAppLogo.Image = Properties.Resources.PIYU_SecureID;
            picBoxAppLogo.Location = new Point(156, 113);
            picBoxAppLogo.Margin = new Padding(1000, 3, 1000, 3);
            picBoxAppLogo.Name = "picBoxAppLogo";
            picBoxAppLogo.Size = new Size(125, 125);
            picBoxAppLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxAppLogo.TabIndex = 0;
            picBoxAppLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Font = new Font("Corbel", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAppName.ForeColor = Color.FromArgb(250, 201, 48);
            lblAppName.Location = new Point(281, 153);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(163, 45);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "SecureID";
            // 
            // FormLoad
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 69, 93);
            ClientSize = new Size(600, 350);
            Controls.Add(picBoxAppLogo);
            Controls.Add(lblAppName);
            Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLoad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLoad";
            ((System.ComponentModel.ISupportInitialize)picBoxAppLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picBoxAppLogo;
        private Label lblAppName;
    }
}