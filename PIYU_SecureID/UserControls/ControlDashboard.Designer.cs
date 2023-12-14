namespace PIYU_SecureID
{
    partial class ControlDashboard
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
            labelTotalTransaction = new Label();
            SuspendLayout();
            // 
            // labelTotalTransaction
            // 
            labelTotalTransaction.AutoSize = true;
            labelTotalTransaction.Location = new Point(104, 76);
            labelTotalTransaction.Name = "labelTotalTransaction";
            labelTotalTransaction.Size = new Size(106, 15);
            labelTotalTransaction.TabIndex = 0;
            labelTotalTransaction.Text = "Total Transactions: ";
            // 
            // ControlDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelTotalTransaction);
            Name = "ControlDashboard";
            Size = new Size(1116, 628);
            Load += ControlDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelTotalTransaction;
    }
}
