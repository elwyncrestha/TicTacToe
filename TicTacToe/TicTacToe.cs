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
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void TicTacToe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
            this.Close();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            lblRound.Text = Game.gameRound.ToString();
            lblFirstPlayer.Text = Game.player1Name;
            lblSecondPlayer.Text = Game.player2Name;
            lblFirstPlayerScore.Text = Game.player1Score.ToString();
            lblSecondPlayerScore.Text = Game.player2Score.ToString();
            pbGameProgress.Value = (int) Game.gameProgress;
        }

        private void refreshGameDetails()
        {
            pbGameProgress.Value = Game.gameProgress;
        }

        private void resetGame()
        {
            // Button clear text
            btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
            // Button re-enable
            btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = true;
            // ProgressBar reset
            Game.gameProgress = 0;
            refreshGameDetails();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // ProgressBar
            int futureProgress = Game.gameProgress + 12;
            if (futureProgress > 100)
            {
                Game.gameProgress = 100;
            }
            else
            {
                Game.gameProgress = futureProgress;
            }
            refreshGameDetails();

            Button button = (Button)sender;
            if (Game.playerTurn == 0)
            {
                button.Text = "O";
                Game.playerTurn = 1;
            }
            else if (Game.playerTurn == 1)
            {
                button.Text = "X";
                Game.playerTurn = 0;
            }

            // disable used button
            button.Enabled = false;

            // Check game termination
            if(Game.gameProgress == 100)
            {
                MessageBox.Show("Round draw !!!");
                resetGame();
            }
        }
    }
}
