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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help fHelp = new Help();
            fHelp.ShowDialog();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            btnStart.TabIndex = 0;
        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.Red;
            

        }

        private void btnHelp_MouseHover(object sender, EventArgs e)
        {
            btnHelp.BackColor = Color.Red;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Black;
        }

        private void btnHelp_MouseLeave(object sender, EventArgs e)
        {
            btnHelp.BackColor = Color.Black;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.Black;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameForm fGame = new GameForm();
            this.Hide();
            fGame.ShowDialog();
        }
    }
}
