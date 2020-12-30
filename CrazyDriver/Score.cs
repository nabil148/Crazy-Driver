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
    public partial class Score : Form
    {
        PictureBox award;
        int coins, score;

        public Score(PictureBox _award,int _score,int _coins)
        {
           
            award = _award;
            score = _score;
            coins = _coins;
            InitializeComponent();
        }

        private void Score_Load(object sender, EventArgs e)
        {
            picAward.Image = award.Image;
            lblScore.Text = score.ToString();
            lblCoins.Text = coins.ToString();
        }
    }
}
