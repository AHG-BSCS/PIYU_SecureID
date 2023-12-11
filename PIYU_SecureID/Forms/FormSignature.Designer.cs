namespace PIYU_SecureID
{
    partial class FormSignature
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
            pictureBoxSignature = new PictureBox();
            buttonClear = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSignature).BeginInit();
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
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // pictureBoxSignature
            // 
            pictureBoxSignature.BackColor = Color.White;
            pictureBoxSignature.Location = new Point(12, 12);
            pictureBoxSignature.Name = "pictureBoxSignature";
            pictureBoxSignature.Size = new Size(295, 295);
            pictureBoxSignature.TabIndex = 1;
            pictureBoxSignature.TabStop = false;
            pictureBoxSignature.MouseDown += pictureBoxSignature_MouseDown;
            pictureBoxSignature.MouseMove += pictureBoxSignature_MouseMove;
            pictureBoxSignature.MouseUp += pictureBoxSignature_MouseUp;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(311, 210);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(97, 48);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "CLEAR";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
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
            // FormSignature
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 69, 93);
            ClientSize = new Size(410, 318);
            Controls.Add(buttonCancel);
            Controls.Add(buttonClear);
            Controls.Add(pictureBoxSignature);
            Controls.Add(buttonSave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSignature";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSignature";
            ((System.ComponentModel.ISupportInitialize)pictureBoxSignature).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSave;
        private PictureBox pictureBoxSignature;
        private Button buttonClear;
        private Button buttonCancel;
    }
}