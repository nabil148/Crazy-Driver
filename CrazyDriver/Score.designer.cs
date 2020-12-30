namespace CrazyDriver
{
    partial class Score
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Score));
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.picAward = new System.Windows.Forms.PictureBox();
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.picScore = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(137, 211);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 39);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.Location = new System.Drawing.Point(645, 203);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(71, 39);
            this.lblCoins.TabIndex = 4;
            this.lblCoins.Text = "899";
            // 
            // picAward
            // 
            this.picAward.Image = global::CrazyDriver.Properties.Resources.medalBronze;
            this.picAward.Location = new System.Drawing.Point(318, 23);
            this.picAward.Name = "picAward";
            this.picAward.Size = new System.Drawing.Size(152, 152);
            this.picAward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAward.TabIndex = 2;
            this.picAward.TabStop = false;
            // 
            // picCoin
            // 
            this.picCoin.Image = ((System.Drawing.Image)(resources.GetObject("picCoin.Image")));
            this.picCoin.Location = new System.Drawing.Point(524, 200);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(100, 50);
            this.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCoin.TabIndex = 1;
            this.picCoin.TabStop = false;
            // 
            // picScore
            // 
            this.picScore.Image = ((System.Drawing.Image)(resources.GetObject("picScore.Image")));
            this.picScore.Location = new System.Drawing.Point(12, 175);
            this.picScore.Name = "picScore";
            this.picScore.Size = new System.Drawing.Size(160, 109);
            this.picScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScore.TabIndex = 0;
            this.picScore.TabStop = false;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picAward);
            this.Controls.Add(this.picCoin);
            this.Controls.Add(this.picScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Score";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score";
            this.Load += new System.EventHandler(this.Score_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picScore;
        private System.Windows.Forms.PictureBox picCoin;
        private System.Windows.Forms.PictureBox picAward;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCoins;
    }
}