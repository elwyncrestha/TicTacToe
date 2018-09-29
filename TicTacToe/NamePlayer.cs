using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class NamePlayer : Form
    {
        public NamePlayer()
        {
            InitializeComponent();
        }

        private void btnDefaultName_Click(object sender, EventArgs e)
        {
            Game.player1Name = "Player 1: O";
            Game.player2Name = "Player 2: X";

            this.Hide();
            TicTacToe ttt = new TicTacToe();
            ttt.ShowDialog();
            this.Close();
        }

        private void NamePlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game.player1Name = txtFirstPlayer.Text.Trim() + ": O";
            Game.player2Name = txtSecondPlayer.Text.Trim() + ": X";

            this.Hide();
            TicTacToe ttt = new TicTacToe();
            ttt.ShowDialog();
            this.Close();
        }

        private void NamePlayer_Load(object sender, EventArgs e)
        {
            btnPlay.Enabled = false;
        }

        private void empty_Check(object sender, EventArgs e)
        {
            bool status = String.IsNullOrEmpty(txtFirstPlayer.Text) || String.IsNullOrEmpty(txtSecondPlayer.Text);
            if (status == false)
            {
                btnPlay.Enabled = true;
            }
            else
            {
                btnPlay.Enabled = false;
            }
        }
    }
}
