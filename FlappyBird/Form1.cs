namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8; // Spielgeschwindigkeit
        int gravity = 15; // Vogelposition (senkrecht)
        int score = 0;  // aktueller Spielstand
        public Form1()
        {
            InitializeComponent();
        }

        private void gravity_descrease_on_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) {
                gravity -= 20;
            }
        }

        private void gravity_increase_on_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity += 20;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // birdFigure.Top = (birdFigure.Top == 0) ? 0 : birdFigure.Top + gravity;

            //if (birdFigure.Top < 10)
            //{
            //    birdFigure.Top = 10;
            //    gravity = 15;
            //}
            //else birdFigure.Top += gravity;

            score += 30;
            scoreCounterLabel.Text = "Score: " + score;

            if (birdFigure.Top >= 10)
            {
                birdFigure.Top += gravity;
            }
            else 
            {
                birdFigure.Top = 10;
                gravity = 15;
            };

            if (birdFigure.Bounds.IntersectsWith(columnBottom.Bounds) ||
                birdFigure.Bounds.IntersectsWith(columnTop.Bounds) ||
                birdFigure.Bounds.IntersectsWith(groundObj.Bounds)) 
            {
                endGame();
            };

            columnBottom.Left -= pipeSpeed;
            columnTop.Left -= pipeSpeed;

            if (columnBottom.Left < -150)
            {
                columnBottom.Left = 800;
            }
            if (columnTop.Left < -180)
            {
                columnTop.Left = 950;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreCounterLabel.Text = "Game over! You scored: " + score;
        }
    }
}