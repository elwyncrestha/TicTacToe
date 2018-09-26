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

        // win combinations
        public static string[] winCombinations = { "123", "159", "147", "258", "369", "357", "456", "789" };

        // player combinations
        public static StringBuilder player1Combinations = new StringBuilder("");
        public static StringBuilder player2Combinations = new StringBuilder("");

        // methods
        public static string sortString(string stringName)
        {
            StringBuilder stringBuilder = new StringBuilder(stringName);
            int stringLength = stringBuilder.Length;
            for(int i = 0; i < stringLength - 1; i ++)
            {
                for(int j = i+1; j < stringLength; j ++)
                {
                    if(stringBuilder[i] > stringBuilder[j])
                    {
                        char temp = stringBuilder[i];
                        stringBuilder[i] = stringBuilder[j];
                        stringBuilder[j] = temp;
                    }
                }
            }

            return stringBuilder.ToString();
        }

        public static bool playerWin(string playerCombinations)
        {
            string sortedCombinations = sortString(playerCombinations);
            

            for(int i = 0; i < winCombinations.Length; i ++)
            {
                int passCount = 0;

                int stringLength = winCombinations[i].Length;
                for (int j = 0; j < stringLength; j++)
                {
                    if (sortedCombinations.Contains( (winCombinations[i])[j] ))
                    {
                        passCount++;
                    }
                }

                if(passCount >= 3)
                {
                    return true;
                }
            }

            return false;

        }

        public static void resetAll()
        {
            player1Name = null;
            player2Name = null;
            gameProgress = 0;
            player1Score = 0;
            player2Score = 0;
            gameRound = 0;
            playerTurn = 0;
            player1Combinations = new StringBuilder("");
            player2Combinations = new StringBuilder("");
        }

    }
}
