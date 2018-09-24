using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class Game
    {
        // player names
        public static string player1Name = null;
        public static string player2Name = null;

        // progress tracker
        public static int gameProgress = 0;

        // score
        public static int player1Score = 0;
        public static int player2Score = 0;

        // round
        public static int gameRound = 0;

        // 0 for player1, 1 for player2
        public static byte playerTurn = 0;

    }
}
