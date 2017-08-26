using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;
using Games_Logic_Library;

namespace Games_Logic_Library
{
    public static class Two_Up_Game
    {
        private static int playersScore;
        private static int computersScore;
        private static Coin coin1;
        private static Coin coin2;
        private static string outcome;
        private static int counter;

        public static int GetCounter()
        {
            return counter;
        }

        public static void InitCounter()
        {
            counter = 0;
        }

        public static void IncrementCounter()
        {
            counter = counter + 1;
        }

        public static void SetUpGame()
        {
            playersScore = 0;
            computersScore = 0;
            coin1 = new Coin();
            coin2 = new Coin();
        }//end SetUpGame

        public static void TossCoins()
        {
            coin1.Flip();
            coin2.Flip();
        }//end TossCoins

        public static string TossOutcome()
        {
            if ((coin1.IsHeads()) && (coin2.IsHeads()))
            {
                outcome = "Heads";
                playersScore = playersScore + 1;
                return outcome;
            }
            else if ((!coin1.IsHeads()) && (!coin2.IsHeads()))
            {
                outcome = "Tails";
                computersScore = computersScore + 1;
                return outcome;
            }
            else
            {
                outcome = "Odds";
                return outcome;
            }
        }//end TossOutcome

        public static bool IsHeads(int whichCoin)
        {
            if (whichCoin == 1)
            {
                return coin1.IsHeads();
            }
            else
            {
                return coin2.IsHeads();
            }
        }//end IsHeads

        public static int GetPlayersScore()
        {
            return playersScore;
        }//end GetPlayersScore

        public static int GetComputersScore()
        {
            return computersScore;
        }//end GetComputersScore
    }//end Two Up Game class
}//end namespace