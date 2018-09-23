namespace TicTacToe
{
    partial class NamePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NamePlayer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstPlayer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecondPlayer = new System.Windows.Forms.TextBox();
            this.btnDefaultName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Give";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFirstPlayer
            // 
            this.txtFirstPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.txtFirstPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstPlayer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstPlayer.ForeColor = System.Drawing.Color.Black;
            this.txtFirstPlayer.Location = new System.Drawing.Point(100, 100);
            this.txtFirstPlayer.Name = "txtFirstPlayer";
            this.txtFirstPlayer.Size = new System.Drawing.Size(137, 24);
            this.txtFirstPlayer.TabIndex = 1;
            this.txtFirstPlayer.TextChanged += new System.EventHandler(this.empty_Check);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player 1";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.Location = new System.Drawing.Point(14, 204);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(98, 49);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Player 2";
            // 
            // txtSecondPlayer
            // 
            this.txtSecondPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.txtSecondPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecondPlayer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondPlayer.ForeColor = System.Drawing.Color.Black;
            this.txtSecondPlayer.Location = new System.Drawing.Point(100, 136);
            this.txtSecondPlayer.Name = "txtSecondPlayer";
            this.txtSecondPlayer.Size = new System.Drawing.Size(139, 24);
            this.txtSecondPlayer.TabIndex = 2;
            this.txtSecondPlayer.TextChanged += new System.EventHandler(this.empty_Check);
            // 
            // btnDefaultName
            // 
            this.btnDefaultName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.btnDefaultName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefaultName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefaultName.ForeColor = System.Drawing.Color.Black;
            this.btnDefaultName.Location = new System.Drawing.Point(118, 204);
            this.btnDefaultName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDefaultName.Name = "btnDefaultName";
            this.btnDefaultName.Size = new System.Drawing.Size(193, 49);
            this.btnDefaultName.TabIndex = 4;
            this.btnDefaultName.Text = "Use Default Name";
            this.btnDefaultName.UseVisualStyleBackColor = false;
            this.btnDefaultName.Click += new System.EventHandler(this.btnDefaultName_Click);
            // 
            // NamePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(331, 279);
            this.Controls.Add(this.btnDefaultName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSecondPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstPlayer);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NamePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player\'s Name";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NamePlayer_FormClosed);
            this.Load += new System.EventHandler(this.NamePlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecondPlayer;
        private System.Windows.Forms.Button btnDefaultName;
    }
}

