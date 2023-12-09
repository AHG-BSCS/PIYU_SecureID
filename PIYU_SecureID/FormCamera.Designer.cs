namespace PIYU_SecureID
{
    partial class FormCamera
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
            buttonSave = new Button();
            pictureBoxIdPhoto = new PictureBox();
            buttonClearPhoto = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIdPhoto).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(311, 162);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(97, 48);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "CAPTURE";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // pictureBoxIdPhoto
            // 
            pictureBoxIdPhoto.BackColor = Color.White;
            pictureBoxIdPhoto.Location = new Point(12, 12);
            pictureBoxIdPhoto.Name = "pictureBoxIdPhoto";
            pictureBoxIdPhoto.Size = new Size(295, 295);
            pictureBoxIdPhoto.TabIndex = 1;
            pictureBoxIdPhoto.TabStop = false;
            // 
            // buttonClearPhoto
            // 
            buttonClearPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClearPhoto.FlatAppearance.BorderSize = 0;
            buttonClearPhoto.FlatStyle = FlatStyle.Flat;
            buttonClearPhoto.ForeColor = Color.White;
            buttonClearPhoto.Location = new Point(311, 210);
            buttonClearPhoto.Name = "buttonClearPhoto";
            buttonClearPhoto.Size = new Size(97, 48);
            buttonClearPhoto.TabIndex = 2;
            buttonClearPhoto.Text = "CLEAR";
            buttonClearPhoto.UseVisualStyleBackColor = true;
            buttonClearPhoto.Click += buttonClear_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(311, 258);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(97, 48);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "CANCEL";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormCamera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 69, 93);
            ClientSize = new Size(410, 318);
            Controls.Add(buttonCancel);
            Controls.Add(buttonClearPhoto);
            Controls.Add(pictureBoxIdPhoto);
            Controls.Add(buttonSave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCamera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSignature";
            FormClosed += FormCamera_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIdPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSave;
        private PictureBox pictureBoxIdPhoto;
        private Button buttonClearPhoto;
        private Button buttonCancel;
    }
}