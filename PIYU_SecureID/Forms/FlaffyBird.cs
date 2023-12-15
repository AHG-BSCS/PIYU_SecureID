using System;

namespace PIYU_SecureID
{
    public partial class FlaffyBird : Form
    {
        int pipeSpeed = 10;
        int gravity = 7;
        int score = 0;
        int minPipeGap = 50;
        int totalPipeHeight = 115;
        int maxPipeHeight = 175;
        bool isGameRunning = false;
        Random random = new Random();

        public FlaffyBird()
        {
            InitializeComponent();
        }

        private void endGame()
        {
            gameTimer.Stop();
            isGameRunning = false;
            scoreText.Text += " Game over!!!";
            Thread.Sleep(1000);
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;

            int pipeX = 235;

            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = pipeX;
                int newHeightBottom = random.Next(30, maxPipeHeight);
                int remainingSpaceTop = totalPipeHeight - minPipeGap - newHeightBottom;
                int remainingSpaceBottom = totalPipeHeight - newHeightBottom;

                // Distribute the remaining space between top and bottom pipes
                pipeBottom.Height = Math.Min(newHeightBottom + remainingSpaceTop / 2, 359 - 50); // Adjust for ground height
                pipeBottom.Top = ground.Top - pipeBottom.Height;
                score++;
            }

            if (pipeTop.Left < -180)
            {
                pipeTop.Left = pipeX;
                int newHeightTop = random.Next(30, maxPipeHeight);
                int remainingSpaceTop = totalPipeHeight - minPipeGap - newHeightTop;

                // Distribute the remaining space between top and bottom pipes
                pipeTop.Height = Math.Min(newHeightTop + remainingSpaceTop / 2, 359 - ground.Height - minPipeGap - pipeBottom.Height);
                pipeTop.Top = 0; // Adjust if needed
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25
                )
            {
                endGame();
            }

            if (score == 25)
            {
                pipeSpeed = 15;
            }
            else if (score == 50)
            {
                pipeSpeed = 20;
            }
            else if (score == 75)
            {
                pipeSpeed = 30;
            }
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            if (!isGameRunning)
            {
                flappyBird.Location = new Point(41, 127);
                pipeTop.Location = new Point(235, 0);
                pipeTop.Height = 75;
                pipeBottom.Location = new Point(235, 203);
                pipeBottom.Height = 69;
                pipeSpeed = 10;
                score = 0;

                isGameRunning = true;
                gameTimer.Start();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            gravity = -7;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            gravity = 7;
        }
    }
}