using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Games_Logic_Library;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Snake_Eyes_Game {
        private static int rollTotal;
        private static int playerTotal;
        private static int houseTotal;
        private static int possiblePoints;
        private static Die[] Die;
        private static int faceValue;
        private static bool rollAgain;
        private static int rollNumber;
        private static string outcome;
        private static string headline;

        public static void SetUpGame() {
            playerTotal = GetPlayersPoints();
            houseTotal = GetHousePoints();
            possiblePoints = 0;
            rollTotal = 0;
            rollNumber = 0;
            outcome = "";
            headline = "First Roll";
            Die = new Die[2];
            Die[0] = new Die();
            Die[1] = new Die();
        }//end SetUpGame

        public static void RollDice() {
            Die[0].RollDie();
            Die[1].RollDie();
            rollTotal = (Die[0].GetFaceValue() + Die[1].GetFaceValue());
            rollNumber = rollNumber + 1;
        }//end RollDice

        public static bool FirstRoll() {
            if (rollTotal == 2) {
                playerTotal = (playerTotal + 2);
                outcome = "Snake Eyes! You get 2 points";
                headline = "Congratulations, you won!";
                rollAgain = false;
                return rollAgain;
            } else if (rollTotal == 7) {
                playerTotal = (playerTotal + 1);
                outcome = "You get 1 point!";
                headline = "Congratulations, you won!";
                rollAgain = false;
                return rollAgain;
            } else if (rollTotal == 11) {
                playerTotal = (playerTotal + 1);
                outcome = "You get 1 point!";
                headline = "Congratulations, you won!";
                rollAgain = false;
                return rollAgain;
            } else if (rollTotal == 3) {
                houseTotal = (houseTotal + 2);
                outcome = "House gets 2 points!";
                headline = "Sorry, you lost!";
                rollAgain = false;
                return rollAgain;
            } else if (rollTotal == 12) {
                houseTotal = (houseTotal + 2);
                outcome = "House gets 2 points!";
                headline = "Sorry, you lost!";
                rollAgain = false;
                return rollAgain;
            } else {
                possiblePoints = rollTotal;
                outcome = "You need to roll a " + possiblePoints + " to win...";
                headline = "Roll Dice Again";
                rollAgain = true;
                return rollAgain;
            }//end if-else
        }//end FirstRoll

        public static bool AnotherRoll() {
            if (rollTotal == 7) {
                houseTotal = (houseTotal + 2);
                outcome = "House gets 2 points!";
                headline = "Sorry, you lost!";
                rollAgain = false;
                return rollAgain;
            } else if (rollTotal == possiblePoints) {
                playerTotal = (playerTotal + possiblePoints);
                outcome = "You get " + possiblePoints + " points!";
                headline = "Congratulations, you won!";
                rollAgain = false;
                return rollAgain;
            } else {
                outcome = "You need to roll a " + possiblePoints + " to win...";
                headline = "Roll Dice Again";
                rollAgain = true;
                return rollAgain;
            }//end if-else
        }//end AnotherRoll

        public static int GetDieFaceValue(int whichDie) {
            if (whichDie == 1) {
                faceValue = Die[0].GetFaceValue();
                return faceValue;
            } else {
                faceValue = Die[1].GetFaceValue();
                return faceValue;
            }//end if-else
        }//end GetDieFaceValue

        public static int GetPlayersPoints() {
            return playerTotal;
        }//end GetPlayersPoints

        public static int GetHousePoints() {
            return houseTotal;
        }//end GetHousePoints

        public static int GetPossiblePoints() {
            return possiblePoints;
        }//end GetPossiblePoints

        public static int GetRollTotal() {
            return rollTotal;
        }//end GetRollTotal

        public static string GetRollOutcome() {
            return outcome;
        }//end GetRollOutcome

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int RollCount() {
            return rollNumber;
        }//end RollCount

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetRollHeadline() {
            return headline;
        }//end GetRollHeadline
    }//end Snake Eyes Game class
}//end namespace
