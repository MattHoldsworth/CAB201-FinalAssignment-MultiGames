using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    /// <summary>
    /// 
    /// </summary>
    public static class Twenty_One_Game {
        public const int NUM_OF_PLAYERS = 2;
        private static CardPile cardPile;
        private static Hand[] hands;
        private static int[] totalPoints;
        private static int[] numOfGamesWon;
        private static int numOfUserAcesWithValueOne;


        /// <summary>
        /// 
        /// </summary>
        public static void SetUpGame() {
            cardPile = new CardPile(true);
            hands = new Hand[2];
            hands[0] = new Hand();
            hands[1] = new Hand();
            totalPoints = new int[2] {0, 0};
            numOfGamesWon = new int[2] {0, 0};
            numOfUserAcesWithValueOne = 0;
        }//end SetUpGame

        public static bool Continue() {
            if (hands[1].GetCount() > 0) {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static Card DealOneCardTo(int who) {
            cardPile.Shuffle();
            Card card = cardPile.DealOneCard();
            hands[who].Add(card);
            return card;
        }//end DealOneCard


        /// <summary>
        /// 
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static int CalculateHandTotal(int who) {
            int total = 0;
            foreach (Card card in hands[who])
            {
                if (card.GetFaceValue() == FaceValue.Two) {
                    total = total + 2;
                } else if (card.GetFaceValue() == FaceValue.Three) {
                    total = total + 3;
                } else if (card.GetFaceValue() == FaceValue.Four) {
                    total = total + 4;
                } else if (card.GetFaceValue() == FaceValue.Five) {
                    total = total + 5;
                } else if (card.GetFaceValue() == FaceValue.Six) {
                    total = total + 6;
                } else if (card.GetFaceValue() == FaceValue.Seven) {
                    total = total + 7;
                } else if (card.GetFaceValue() == FaceValue.Eight) {
                    total = total + 8;
                } else if (card.GetFaceValue() == FaceValue.Nine) {
                    total = total + 9;
                } else if (card.GetFaceValue() == FaceValue.Ten) {
                    total = total + 10;
                } else if (card.GetFaceValue() == FaceValue.Jack) {
                    total = total + 10;
                } else if (card.GetFaceValue() == FaceValue.Queen) {
                    total = total + 10;
                } else if (card.GetFaceValue() == FaceValue.King) {
                    total = total + 10;
                } else if (card.GetFaceValue() == FaceValue.Ace) {
                    total = total + 11;
                }
            }
            return totalPoints[who] = total;
        }//end CalculateHandTotal


        /// <summary>
        /// 
        /// </summary>
        public static void PlayForDealer() {
            DealOneCardTo(0);
        }//end PlayForDealer

        /// <summary>
        /// 
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static Hand GetHand(int who) {
            return hands[who];
        }//end GetHand


        /// <summary>
        /// Added in helper-method
        /// </summary>
        public static void SetNumOfAcesValuedOneToZero() {
            numOfUserAcesWithValueOne = 0;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static int GetTotalPoints(int who) {
            return totalPoints[who];
        }//end GetTotalPoints


        /// <summary>
        /// 
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static int GetNumOfGamesWon(int who) {
            return numOfGamesWon[who];
        }//end GetNumOfGamesWon

        /// <summary>
        /// Added in helper method
        /// </summary>
        /// <param name="who"></param>
        public static void IncrementGamesWon(int who) {
            numOfGamesWon[who] = numOfGamesWon[who] + 1;
        }//end IncrementGamesWon

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int GetNumOfUserAcesWithValueOne() {
            return numOfUserAcesWithValueOne;
        }//end GetNumOfUserAcesWithValueOne

        /// <summary>
        /// 
        /// </summary>
        public static void IncrementNumofUserAcesWithValueOne() {
            numOfUserAcesWithValueOne = numOfUserAcesWithValueOne + 1;
        }//end IncrementNumofUserAcesWithValueOne

        /// <summary>
        /// 
        /// </summary>
        public static void ResetTotals() {
            cardPile = new CardPile(true);
            hands = new Hand[2];
            hands[0] = new Hand();
            hands[1] = new Hand();
            //totalPoints = new int[2] { 0, 0 };
            //numOfUserAcesWithValueOne = 0;
        }//end ResetTotals
    }//end Twenty One Game class
}//end namespace
