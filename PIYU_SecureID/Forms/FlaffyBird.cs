using System;

namespace PIYU_SecureID
{
    public partial class FlaffyBird : Form
    {
        int pipeSpeed = 20;
        int gravity = 10;
        int score = 0;
        bool isGameRunning = false;

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
            pipeBottom.Left -= pipeSpeed; 
            pipeTop.Left -= pipeSpeed; 
            scoreText.Text = "Score: " + score; 

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }

            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
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
                pipeSpeed = 25;
            }
            else if (score == 50)
            {
                pipeSpeed = 30;
            }
            else if (score > 50)
            {
                pipeSpeed = 40;
            }
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            if (!isGameRunning)
            {
                flappyBird.Location = new Point(41, 127);
                pipeTop.Location = new Point(235, 0);
                pipeBottom.Location = new Point(235, 203);
                pipeSpeed = 20;
                score = 0;

                isGameRunning = true;
                gameTimer.Start();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            gravity = -10;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            gravity = 10;
        }
    }
}