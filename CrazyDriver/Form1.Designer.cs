namespace CrazyDriver
{
    partial class GameForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picRoadTrack1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gameArea = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblCoins = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.picScore = new System.Windows.Forms.PictureBox();
            this.picCoin1 = new System.Windows.Forms.PictureBox();
            this.picAward = new System.Windows.Forms.PictureBox();
            this.picSpeed = new System.Windows.Forms.PictureBox();
            this.picConstraint2 = new System.Windows.Forms.PictureBox();
            this.picConstraint1 = new System.Windows.Forms.PictureBox();
            this.picCoin4 = new System.Windows.Forms.PictureBox();
            this.picCoin3 = new System.Windows.Forms.PictureBox();
            this.picCoin2 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picExplosion = new System.Windows.Forms.PictureBox();
            this.picRoadTrack2 = new System.Windows.Forms.Panel();
            this.gameArea.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConstraint2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConstraint1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplosion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 515);
            this.panel1.TabIndex = 0;
            // 
            // picRoadTrack1
            // 
            this.picRoadTrack1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picRoadTrack1.BackColor = System.Drawing.Color.White;
            this.picRoadTrack1.Location = new System.Drawing.Point(207, 19);
            this.picRoadTrack1.Name = "picRoadTrack1";
            this.picRoadTrack1.Size = new System.Drawing.Size(10, 193);
            this.picRoadTrack1.TabIndex = 0;
            this.picRoadTrack1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(392, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(11, 515);
            this.panel4.TabIndex = 1;
            // 
            // gameArea
            // 
            this.gameArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameArea.BackColor = System.Drawing.Color.Black;
            this.gameArea.Controls.Add(this.picPlayer);
            this.gameArea.Controls.Add(this.picExplosion);
            this.gameArea.Controls.Add(this.picCoin1);
            this.gameArea.Controls.Add(this.picConstraint2);
            this.gameArea.Controls.Add(this.picConstraint1);
            this.gameArea.Controls.Add(this.picCoin4);
            this.gameArea.Controls.Add(this.picCoin3);
            this.gameArea.Controls.Add(this.picCoin2);
            this.gameArea.Controls.Add(this.panel4);
            this.gameArea.Controls.Add(this.panel1);
            this.gameArea.Controls.Add(this.picRoadTrack2);
            this.gameArea.Controls.Add(this.picRoadTrack1);
            this.gameArea.Location = new System.Drawing.Point(264, 2);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(403, 515);
            this.gameArea.TabIndex = 2;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Black;
            this.panelLeft.Controls.Add(this.picSpeed);
            this.panelLeft.Controls.Add(this.picAward);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(268, 517);
            this.panelLeft.TabIndex = 3;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.picCoin);
            this.panelRight.Controls.Add(this.picScore);
            this.panelRight.Controls.Add(this.btnExit);
            this.panelRight.Controls.Add(this.btnStart);
            this.panelRight.Controls.Add(this.lblScore);
            this.panelRight.Controls.Add(this.lblCoins);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(665, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(254, 517);
            this.panelRight.TabIndex = 4;
            // 
            // lblCoins
            // 
            this.lblCoins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.Color.White;
            this.lblCoins.Location = new System.Drawing.Point(105, 126);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(36, 39);
            this.lblCoins.TabIndex = 0;
            this.lblCoins.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(105, 55);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(36, 39);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.Red;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(-6, 212);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(260, 57);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(-6, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 57);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnExit_PreviewKeyDown);
            // 
            // picCoin
            // 
            this.picCoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCoin.Image = global::CrazyDriver.Properties.Resources.coin;
            this.picCoin.Location = new System.Drawing.Point(23, 126);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(52, 39);
            this.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoin.TabIndex = 11;
            this.picCoin.TabStop = false;
            // 
            // picScore
            // 
            this.picScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picScore.Image = global::CrazyDriver.Properties.Resources.star;
            this.picScore.Location = new System.Drawing.Point(11, 44);
            this.picScore.Name = "picScore";
            this.picScore.Size = new System.Drawing.Size(75, 68);
            this.picScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScore.TabIndex = 10;
            this.picScore.TabStop = false;
            // 
            // picCoin1
            // 
            this.picCoin1.Image = ((System.Drawing.Image)(resources.GetObject("picCoin1.Image")));
            this.picCoin1.Location = new System.Drawing.Point(42, 84);
            this.picCoin1.Name = "picCoin1";
            this.picCoin1.Size = new System.Drawing.Size(32, 23);
            this.picCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoin1.TabIndex = 2;
            this.picCoin1.TabStop = false;
            // 
            // picAward
            // 
            this.picAward.Location = new System.Drawing.Point(56, 409);
            this.picAward.Name = "picAward";
            this.picAward.Size = new System.Drawing.Size(100, 50);
            this.picAward.TabIndex = 8;
            this.picAward.TabStop = false;
            // 
            // picSpeed
            // 
            this.picSpeed.Location = new System.Drawing.Point(127, 125);
            this.picSpeed.Name = "picSpeed";
            this.picSpeed.Size = new System.Drawing.Size(235, 168);
            this.picSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpeed.TabIndex = 0;
            this.picSpeed.TabStop = false;
            // 
            // picConstraint2
            // 
            this.picConstraint2.Image = global::CrazyDriver.Properties.Resources.car2;
            this.picConstraint2.Location = new System.Drawing.Point(294, 124);
            this.picConstraint2.Name = "picConstraint2";
            this.picConstraint2.Size = new System.Drawing.Size(50, 104);
            this.picConstraint2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConstraint2.TabIndex = 7;
            this.picConstraint2.TabStop = false;
            this.picConstraint2.Tag = "carLeft";
            // 
            // picConstraint1
            // 
            this.picConstraint1.Image = global::CrazyDriver.Properties.Resources.car3;
            this.picConstraint1.Location = new System.Drawing.Point(77, 84);
            this.picConstraint1.Name = "picConstraint1";
            this.picConstraint1.Size = new System.Drawing.Size(50, 104);
            this.picConstraint1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConstraint1.TabIndex = 6;
            this.picConstraint1.TabStop = false;
            this.picConstraint1.Tag = "carRight";
            // 
            // picCoin4
            // 
            this.picCoin4.Image = ((System.Drawing.Image)(resources.GetObject("picCoin4.Image")));
            this.picCoin4.Location = new System.Drawing.Point(223, 84);
            this.picCoin4.Name = "picCoin4";
            this.picCoin4.Size = new System.Drawing.Size(32, 23);
            this.picCoin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoin4.TabIndex = 3;
            this.picCoin4.TabStop = false;
            // 
            // picCoin3
            // 
            this.picCoin3.Image = ((System.Drawing.Image)(resources.GetObject("picCoin3.Image")));
            this.picCoin3.Location = new System.Drawing.Point(312, 84);
            this.picCoin3.Name = "picCoin3";
            this.picCoin3.Size = new System.Drawing.Size(32, 23);
            this.picCoin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoin3.TabIndex = 4;
            this.picCoin3.TabStop = false;
            // 
            // picCoin2
            // 
            this.picCoin2.Image = ((System.Drawing.Image)(resources.GetObject("picCoin2.Image")));
            this.picCoin2.Location = new System.Drawing.Point(117, 84);
            this.picCoin2.Name = "picCoin2";
            this.picCoin2.Size = new System.Drawing.Size(32, 23);
            this.picCoin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoin2.TabIndex = 1;
            this.picCoin2.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::CrazyDriver.Properties.Resources.car1;
            this.picPlayer.Location = new System.Drawing.Point(190, 407);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(50, 104);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picExplosion
            // 
            this.picExplosion.Image = global::CrazyDriver.Properties.Resources.explosion;
            this.picExplosion.Location = new System.Drawing.Point(140, 194);
            this.picExplosion.Name = "picExplosion";
            this.picExplosion.Size = new System.Drawing.Size(100, 50);
            this.picExplosion.TabIndex = 5;
            this.picExplosion.TabStop = false;
            // 
            // picRoadTrack2
            // 
            this.picRoadTrack2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picRoadTrack2.BackColor = System.Drawing.Color.White;
            this.picRoadTrack2.Location = new System.Drawing.Point(207, 265);
            this.picRoadTrack2.Name = "picRoadTrack2";
            this.picRoadTrack2.Size = new System.Drawing.Size(10, 192);
            this.picRoadTrack2.TabIndex = 1;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(919, 517);
            this.Controls.Add(this.gameArea);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "GameForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameForm_PreviewKeyDown);
            this.gameArea.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConstraint2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConstraint1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplosion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel picRoadTrack1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel gameArea;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox picSpeed;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picCoin4;
        private System.Windows.Forms.PictureBox picCoin3;
        private System.Windows.Forms.PictureBox picCoin2;
        private System.Windows.Forms.PictureBox picCoin1;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox picExplosion;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picConstraint2;
        private System.Windows.Forms.PictureBox picConstraint1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picAward;
        private System.Windows.Forms.PictureBox picScore;
        private System.Windows.Forms.PictureBox picCoin;
        private System.Windows.Forms.Panel picRoadTrack2;
    }
}

