using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyDriver
{
    public partial class GameForm : Form
    {
        int roadSpeed,
           trafficSpeed,
           playerSpeed = 12,
           score,
           coins,
           carImage;

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
                goLeft = false;
            if (e.KeyCode == Keys.Right)
                goRight = false;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                goLeft = true;
            if (e.KeyCode == Keys.Right)
                goRight = true;
        }

        private void GameForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                case Keys.Left:
                    e.IsInputKey = true;
                    break;
            }
        }

        Random rand = new Random();
        Random carPosition = new Random();
        bool goLeft, goRight;
        public GameForm()
        {
            InitializeComponent();
            ResetGame();
        }
    
        private void GameForm_Load(object sender, EventArgs e)
        {
            this.gameArea.Height = this.Height;
            this.gameArea.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.gameArea.Width) / 2,
                       (Screen.PrimaryScreen.WorkingArea.Height - this.gameArea.Height) / 2);

            panelRight.Width = (this.Width - gameArea.Width) / 2;
            panelLeft.Width = (this.Width - gameArea.Width) / 2;
            this.picSpeed.Location = new Point(this.picSpeed.Location.X,
                       (Screen.PrimaryScreen.WorkingArea.Height - this.picSpeed.Height) / 2);
            picRoadTrack1.Location = new Point(gameArea.Width / 2,
                       (picRoadTrack1.Location.Y));
            picRoadTrack2.Location = new Point(gameArea.Width / 2,
                    (picRoadTrack2.Location.Y));
        }
        private void changeCoin(PictureBox picCoin)
        {
            picCoin.Top = rand.Next(100, 400) * -1;

          
        }
        private void coinCheck()
        {
            if (picPlayer.Bounds.IntersectsWith(picCoin1.Bounds))
            {
                coins++;
                lblCoins.Text = coins.ToString();
                playCoinSound();
                changeCoin(picCoin1);


            }
            if (picPlayer.Bounds.IntersectsWith(picCoin2.Bounds))
            {
                coins++;
                lblCoins.Text = coins.ToString();
                playCoinSound();
                changeCoin(picCoin2);

            }
            if (picPlayer.Bounds.IntersectsWith(picCoin3.Bounds))
            {
                coins++;
                lblCoins.Text = coins.ToString();
                playCoinSound();
                changeCoin(picCoin3);

            }
            if (picPlayer.Bounds.IntersectsWith(picCoin4.Bounds))
            {
                coins++;
                lblCoins.Text = coins.ToString();
                playCoinSound();
                changeCoin(picCoin4);

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            score++;
            lblScore.Text = score.ToString();

            if (goLeft == true && picPlayer.Left > 30)
            {
                picPlayer.Left -= playerSpeed;
            }
            if (goRight == true && picPlayer.Left < 330)
            {
                picPlayer.Left += playerSpeed;
            }
            picRoadTrack1.Top += roadSpeed;
            picRoadTrack2.Top += roadSpeed;
            if (picRoadTrack2.Top > 519)
            {
                picRoadTrack2.Top = -519;
            }
            if (picRoadTrack1.Top > 519)
            {
                picRoadTrack1.Top = -519;
            }
            picConstraint1.Top += trafficSpeed;
            picConstraint2.Top += trafficSpeed;
            //Coin
            picCoin1.Top += trafficSpeed;
            picCoin2.Top += trafficSpeed;
            picCoin3.Top += trafficSpeed;
            picCoin4.Top += trafficSpeed;
            //Coin
            if (picConstraint1.Top > 530)
            {
                changeConstraintCar(picConstraint1);
            }
            if (picConstraint2.Top > 530)
            {
                changeConstraintCar(picConstraint2);
            }
            //Coin
            if (picCoin1.Top > 530)
            {
                changeCoin(picCoin1);
            }
            if (picCoin2.Top > 530)
            {
                changeCoin(picCoin2);
            }
            if (picCoin3.Top > 530)
            {
                changeCoin(picCoin3);
            }
            if (picCoin4.Top > 530)
            {
                changeCoin(picCoin4);
            }
            //Coin
            if (picPlayer.Bounds.IntersectsWith(picConstraint1.Bounds) || picPlayer.Bounds.IntersectsWith(picConstraint2.Bounds))
            {
                gameOver();
            }
            //Coin
            coinCheck();
            //Coin
            if (score >= 0 && score < 100)
            {
                picAward.Image = Properties.Resources.medalBronze;
                picSpeed.Image = Properties.Resources._30;
            }
            if (score > 100 && score < 200)
            {
                picAward.Image = Properties.Resources.medalSilver;
                picSpeed.Image = Properties.Resources._70;
                roadSpeed = 30;
                trafficSpeed = 32;
            }

            if (score > 200)
            {
                picAward.Image = Properties.Resources.medalGold;
                picSpeed.Image = Properties.Resources._100;
                roadSpeed = 40;
                trafficSpeed = 42;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            fScore.Close();
            ResetGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            GameForm_PreviewKeyDown(sender, e);
        }

        Score fScore;
        private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            picExplosion.Visible = true;
            picPlayer.Controls.Add(picExplosion);
            picExplosion.Location = new Point(-8, 5);
            picExplosion.BackColor = Color.Transparent;
            fScore = new Score(picAward, score, coins);
            fScore.Show();
            btnStart.Visible = true;
        }
        private void ResetGame()
        {
            btnStart.Visible = false;
            picExplosion.Visible = false;
            picAward.Visible = false;
            goLeft = false;
            goRight = false;
            score = 0;
            coins = 0;
            lblCoins.Text = (0).ToString();
            picAward.Image = Properties.Resources.medalBronze;
            picSpeed.Image = Properties.Resources._30;
            roadSpeed = 12;
            trafficSpeed = 17;
            picConstraint1.Top = carPosition.Next(200, 500) * -1;
            picConstraint1.Left = carPosition.Next(5, 200);
            picConstraint2.Top = carPosition.Next(200, 500) * -1;
            picConstraint2.Left = carPosition.Next(245, 422);

            gameTimer.Start();
        }
        private void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playCrash.Play();
        }
        private void playCoinSound()
        {
            System.Media.SoundPlayer playCoin = new System.Media.SoundPlayer(Properties.Resources.coinEarned);
            playCoin.Play();
        }
        private void changeConstraintCar(PictureBox tempCar)
        {
            carImage = rand.Next(1, 7);
            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.car1;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.car2;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.car3;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.car4;
                    break;

                case 5:
                    tempCar.Image = Properties.Resources.car5;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.car6;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.decapotable;
                    break;
            }
            tempCar.Top = carPosition.Next(100, 400) * -1;

            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(30, 200);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(245, 330);

            }
        }

    }
}
