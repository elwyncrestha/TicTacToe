namespace TicTacToe
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.gbxGame = new System.Windows.Forms.GroupBox();
            this.gbxGamePoints = new System.Windows.Forms.GroupBox();
            this.lblSecondPlayerScore = new System.Windows.Forms.Label();
            this.lblFirstPlayerScore = new System.Windows.Forms.Label();
            this.lblSecondPlayer = new System.Windows.Forms.Label();
            this.lblFirstPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbGameProgress = new System.Windows.Forms.ProgressBar();
            this.gbxGamePoints.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGame
            // 
            this.gbxGame.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.gbxGame.Location = new System.Drawing.Point(15, 16);
            this.gbxGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxGame.Name = "gbxGame";
            this.gbxGame.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxGame.Size = new System.Drawing.Size(256, 258);
            this.gbxGame.TabIndex = 0;
            this.gbxGame.TabStop = false;
            this.gbxGame.Text = "Game";
            // 
            // gbxGamePoints
            // 
            this.gbxGamePoints.Controls.Add(this.pbGameProgress);
            this.gbxGamePoints.Controls.Add(this.label4);
            this.gbxGamePoints.Controls.Add(this.lblRound);
            this.gbxGamePoints.Controls.Add(this.label3);
            this.gbxGamePoints.Controls.Add(this.label2);
            this.gbxGamePoints.Controls.Add(this.label1);
            this.gbxGamePoints.Controls.Add(this.lblSecondPlayerScore);
            this.gbxGamePoints.Controls.Add(this.lblFirstPlayerScore);
            this.gbxGamePoints.Controls.Add(this.lblSecondPlayer);
            this.gbxGamePoints.Controls.Add(this.lblFirstPlayer);
            this.gbxGamePoints.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGamePoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.gbxGamePoints.Location = new System.Drawing.Point(300, 16);
            this.gbxGamePoints.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxGamePoints.Name = "gbxGamePoints";
            this.gbxGamePoints.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxGamePoints.Size = new System.Drawing.Size(167, 258);
            this.gbxGamePoints.TabIndex = 1;
            this.gbxGamePoints.TabStop = false;
            this.gbxGamePoints.Text = "Game Details";
            // 
            // lblSecondPlayerScore
            // 
            this.lblSecondPlayerScore.AutoSize = true;
            this.lblSecondPlayerScore.Location = new System.Drawing.Point(79, 222);
            this.lblSecondPlayerScore.Name = "lblSecondPlayerScore";
            this.lblSecondPlayerScore.Size = new System.Drawing.Size(72, 22);
            this.lblSecondPlayerScore.TabIndex = 3;
            this.lblSecondPlayerScore.Text = "Score2";
            // 
            // lblFirstPlayerScore
            // 
            this.lblFirstPlayerScore.AutoSize = true;
            this.lblFirstPlayerScore.Location = new System.Drawing.Point(79, 159);
            this.lblFirstPlayerScore.Name = "lblFirstPlayerScore";
            this.lblFirstPlayerScore.Size = new System.Drawing.Size(72, 22);
            this.lblFirstPlayerScore.TabIndex = 2;
            this.lblFirstPlayerScore.Text = "Score1";
            // 
            // lblSecondPlayer
            // 
            this.lblSecondPlayer.AutoSize = true;
            this.lblSecondPlayer.Location = new System.Drawing.Point(7, 200);
            this.lblSecondPlayer.Name = "lblSecondPlayer";
            this.lblSecondPlayer.Size = new System.Drawing.Size(141, 22);
            this.lblSecondPlayer.TabIndex = 1;
            this.lblSecondPlayer.Text = "Second Player";
            // 
            // lblFirstPlayer
            // 
            this.lblFirstPlayer.AutoSize = true;
            this.lblFirstPlayer.Location = new System.Drawing.Point(7, 137);
            this.lblFirstPlayer.Name = "lblFirstPlayer";
            this.lblFirstPlayer.Size = new System.Drawing.Size(103, 22);
            this.lblFirstPlayer.TabIndex = 0;
            this.lblFirstPlayer.Text = "First Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Round:";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(89, 28);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(21, 22);
            this.lblRound.TabIndex = 7;
            this.lblRound.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current Game";
            // 
            // pbGameProgress
            // 
            this.pbGameProgress.Location = new System.Drawing.Point(10, 91);
            this.pbGameProgress.Name = "pbGameProgress";
            this.pbGameProgress.Size = new System.Drawing.Size(141, 23);
            this.pbGameProgress.TabIndex = 9;
            this.pbGameProgress.Value = 50;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(479, 309);
            this.Controls.Add(this.gbxGamePoints);
            this.Controls.Add(this.gbxGame);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TicTacToe_FormClosed);
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.gbxGamePoints.ResumeLayout(false);
            this.gbxGamePoints.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGame;
        private System.Windows.Forms.GroupBox gbxGamePoints;
        private System.Windows.Forms.Label lblSecondPlayerScore;
        private System.Windows.Forms.Label lblFirstPlayerScore;
        private System.Windows.Forms.Label lblSecondPlayer;
        private System.Windows.Forms.Label lblFirstPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbGameProgress;
        private System.Windows.Forms.Label label4;
    }
}