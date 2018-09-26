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
            // back to square one
            Game.resetAll();

            // Form load
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
            pbGameProgress.Value = Game.gameProgress;
        }

        private void refreshGameDetails()
        {
            pbGameProgress.Value = Game.gameProgress;
            lblFirstPlayerScore.Text = Game.player1Score.ToString();
            lblSecondPlayerScore.Text = Game.player2Score.ToString();
            lblRound.Text = Game.gameRound.ToString();
        }

        private void resetGame()
        {
            // Button clear text
            btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
            // Button re-enable
            btn1.Enabled = btn2.Enabled = btn3.Enabled = btn4.Enabled = btn5.Enabled = btn6.Enabled = btn7.Enabled = btn8.Enabled = btn9.Enabled = true;

            // ProgressBar reset
            Game.gameProgress = 0;
            Game.gameRound++;
            Game.player1Combinations = new StringBuilder("");
            Game.player2Combinations = new StringBuilder("");
            Game.playerTurn = 0;
            refreshGameDetails();
        }

        private string getButtonValue(Button button)
        {
            int buttonValue = 0;
            if (button.Name == "btn1")
                buttonValue = 1;
            else if (button.Name == "btn2")
                buttonValue = 2;
            else if (button.Name == "btn3")
                buttonValue = 3;
            else if (button.Name == "btn4")
                buttonValue = 4;
            else if (button.Name == "btn5")
                buttonValue = 5;
            else if (button.Name == "btn6")
                buttonValue = 6;
            else if (button.Name == "btn7")
                buttonValue = 7;
            else if (button.Name == "btn8")
                buttonValue = 8;
            else if (button.Name == "btn9")
                buttonValue = 9;

            return buttonValue.ToString();
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
                // disable used button
                button.Enabled = false;
                button.Text = "O";
                Game.playerTurn = 1;
                Game.player1Combinations.Append(getButtonValue(button));
                if(Game.player1Combinations.Length >= 3)
                {
                    bool status = Game.playerWin(Game.player1Combinations.ToString());
                    if(status)
                    {
                        MessageBox.Show(Game.player1Name + " won this round !!!");
                        Game.player1Score++;
                        resetGame();
                    }
                }
            }
            else if (Game.playerTurn == 1)
            {
                // disable used button
                button.Enabled = false;
                button.Text = "X";
                Game.playerTurn = 0;
                Game.player2Combinations.Append(getButtonValue(button));
                if (Game.player2Combinations.Length >= 3)
                {
                    bool status = Game.playerWin(Game.player2Combinations.ToString());
                    if (status)
                    {
                        MessageBox.Show(Game.player2Name + " won this round !!!");
                        Game.player2Score++;
                        resetGame();
                    }
                }
            }

            // Check game termination
            if(Game.gameProgress == 100)
            {
                MessageBox.Show("Round draw !!!");
                resetGame();
            }
        }
    }
}
