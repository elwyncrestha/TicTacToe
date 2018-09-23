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
    }
}
