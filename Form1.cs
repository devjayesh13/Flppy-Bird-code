using System;
using System.Windows.Forms;

namespace plappy_bird
{
    
    public partial class Form1 : Form
    {
        int pipespeed = 8;
        int score = 0;
        int gravity = 10;
        public bool end = false;
        Form2 f2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public void gametimerevent(object sender, EventArgs e)
        {
            Random random = new Random();
            int rnd = random.Next(3);
            int rnd2 = random.Next(300, 360);
            flappybird.Top += gravity;
            pipebottom.Left -= pipespeed;
            pipetop.Left -= pipespeed;
            scoretext.Text = "Score: " + score;
            

            if (pipebottom.Left < -50 && rnd == 0)
            {
                pipebottom.Left = rnd2;
                score++;
            }
            if (pipebottom.Left < -50 && rnd == 1)
            {
                pipebottom.Left = rnd2;
                score++;
            }
            if (pipebottom.Left < -50 && rnd == 2)
            {
                pipebottom.Left = rnd2;
                score++;
            }
            if (pipetop.Left < -50 && rnd == 0)
            {
                pipetop.Left = rnd2;
            }
            if (pipetop.Left < -50 && rnd == 1)
            {
                pipetop.Left = rnd2;
            }
            if (pipetop.Left < -50 && rnd == 2)
            {
                pipetop.Left = rnd2;
            }

            if (flappybird.Bounds.IntersectsWith(pipebottom.Bounds) ||
                (flappybird.Bounds.IntersectsWith(pipetop.Bounds))
                || (flappybird.Bounds.IntersectsWith(ground.Bounds)) || (flappybird.Top < -25))
            {
                endGame();
                Application.DoEvents();
                gameoverscreen();
            }

            if (score > 35)
            {
                pipespeed = 12;
            }
            if (score > 50)
            {
                pipespeed = 15;
            }
            if (score > 75)
            {
                pipespeed = 20;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.W)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.W)
            {
                gravity = 10;
            }
        }

        public void endGame()
        {
            gametimer.Stop();
            scoretext.Text += " Game over!!!";
            end = true;
        }

        public void gameoverscreen()
        {
            if (end == true)
            {
                DialogResult res = MessageBox.Show("Game Over !!! Do you want to restart",
                    "Game Over",MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    this.Dispose();
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                    Application.DoEvents();
                    Application.DoEvents();
                }
                else
                {
                    this.Dispose();
                    f2.ShowDialog();
                    Application.DoEvents();
                }
            }
        }
    }
}