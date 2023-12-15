namespace PIYU_SecureID
{
    partial class FlaffyBird
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlaffyBird));
            pipeTop = new PictureBox();
            ground = new PictureBox();
            pipeBottom = new PictureBox();
            flappyBird = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            scoreText = new Label();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            SuspendLayout();
            // 
            // pipeTop
            // 
            pipeTop.Image = (Image)resources.GetObject("pipeTop.Image");
            pipeTop.Location = new Point(235, 0);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(40, 75);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 0;
            pipeTop.TabStop = false;
            pipeTop.Click += Form1_Click_1;
            pipeTop.MouseDown += Form1_MouseDown;
            pipeTop.MouseUp += Form1_MouseUp;
            // 
            // ground
            // 
            ground.Dock = DockStyle.Bottom;
            ground.Image = (Image)resources.GetObject("ground.Image");
            ground.Location = new Point(0, 270);
            ground.Name = "ground";
            ground.Size = new Size(310, 50);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 1;
            ground.TabStop = false;
            ground.Click += Form1_Click_1;
            ground.MouseDown += Form1_MouseDown;
            ground.MouseUp += Form1_MouseUp;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = (Image)resources.GetObject("pipeBottom.Image");
            pipeBottom.Location = new Point(235, 203);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(40, 69);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            pipeBottom.Click += Form1_Click_1;
            pipeBottom.MouseDown += Form1_MouseDown;
            pipeBottom.MouseUp += Form1_MouseUp;
            // 
            // flappyBird
            // 
            flappyBird.Image = Properties.Resources.PIYU_SecureID;
            flappyBird.Location = new Point(41, 127);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(28, 31);
            flappyBird.SizeMode = PictureBoxSizeMode.Zoom;
            flappyBird.TabIndex = 3;
            flappyBird.TabStop = false;
            flappyBird.Click += Form1_Click_1;
            flappyBird.MouseDown += Form1_MouseDown;
            flappyBird.MouseUp += Form1_MouseUp;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 33;
            gameTimer.Tick += gameTimerEvent;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            scoreText.Location = new Point(12, 9);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(19, 21);
            scoreText.TabIndex = 4;
            scoreText.Text = "0";
            scoreText.Click += Form1_Click_1;
            scoreText.MouseDown += Form1_MouseDown;
            scoreText.MouseUp += Form1_MouseUp;
            // 
            // FlaffyBird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 320);
            Controls.Add(scoreText);
            Controls.Add(flappyBird);
            Controls.Add(pipeBottom);
            Controls.Add(ground);
            Controls.Add(pipeTop);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "FlaffyBird";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniGame";
            Click += Form1_Click_1;
            MouseDown += Form1_MouseDown;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipeTop;
        private PictureBox ground;
        private PictureBox pipeBottom;
        private PictureBox flappyBird;
        private System.Windows.Forms.Timer gameTimer;
        private Label scoreText;
    }
}