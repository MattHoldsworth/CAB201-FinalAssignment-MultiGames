using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public static class Crazy_Eights_Game {
        public const int NUM_OF_PLAYERS = 2;
        public const int MAX_HAND_SIZE = 13;
        private static CardPile drawPile;
        private static CardPile discardPile;
        private static Hand[] hands;
        
        /// <summary>
        /// Sets up the game
        /// </summary>
        public static void SetUpGame()
        {
            drawPile = new CardPile(true);
            discardPile = new CardPile(false);
            hands = new Hand[2];
            hands[0] = new Hand();
            hands[1] = new Hand();
        } // end SetUpGame

        /// <summary>
        /// Checks if deal button is starting a new game or dealing one card to player
        /// </summary>
        /// <returns></returns>
        public static bool DealStart() {
            // check players hand for cards
            if (hands[1].GetCount() < 1) {
                return true;
            } else {
                return false;
            } // end if
        } // end DealStart

        /// <summary>
        /// Checks if clicked card is allowed to be played and play the card
        /// </summary>
        /// <param name="card"></param>
        /// <param name="hand"></param>
        /// <returns></returns>
        public static bool IsGoodClick(Card card, Suit suit) {
            Card discard = discardPile.GetLastCardInPile();
            // check if the clicked card has a playable suit, facevalue or is an eight
            if ((card.GetSuit() == suit) || (card.GetFaceValue() == discard.GetFaceValue()) 
                || (card.GetFaceValue() == FaceValue.Eight)) {
                hands[1].Remove(card);
                discardPile.Add(card);
                return true;
            } else {
                return false;
            } // end if
        } // end IsGoodClick

        /// <summary>
        /// Checks if player has a valid move (for enabling deal button)
        /// </summary>
        /// <returns></returns>
        public static bool PlayerHasMove(Suit suit) {
            int valIndex = HasValue(1);
            int suitIndex = HasSuit(suit, 1);
            int eightIndex = HasEight(1);
            // check if an index exists for a playable card
            if ((valIndex >= 0) || (suitIndex >= 0) || (eightIndex >= 0)) {
                return true;
            } else {
                return false;
            } // end if
        } // end PlayerHasMove

        /// <summary>
        /// Deals one card to specific hand
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static Card DealOneCardTo(int who) {
            // check for empty draw pile
            if (drawPile.GetCount() <= 0) {
                drawPile = discardPile;
                DealOneCard();
            }
            drawPile.Shuffle();
            Card card = drawPile.DealOneCard();
            hands[who].Add(card);
            return card;
        }//end DealOneCard

        /// <summary>
        /// Checks hand for card with the same value as the top discard, excluding eights
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static int HasValue(int who) {
            Card discard = discardPile.GetLastCardInPile();
            Card check;
            // check each index for the same value as discard (excluding eights)
            for (int i = 0; i < hands[who].GetCount(); i++) {
                check = hands[who].GetCard(i);
                if ((check.GetFaceValue() == discard.GetFaceValue()) && (check.GetFaceValue() != FaceValue.Eight)) {
                    return i;
                
                } // end if
            } // end for
            return -1;
        } // end HasValue

        /// <summary>
        /// Checks hand for card with the same suit as top discard
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static int HasSuit(Suit suit, int who) {
            //Card discard = discardPile.GetLastCardInPile();
            Card check;
            for (int i = 0; i < hands[who].GetCount(); i++) {
                check = hands[who].GetCard(i);
                if (check.GetSuit() == suit) {
                    return i;
                } // end if
            } // end for
            return -1;
        } // end HasSuit

        /// <summary>
        /// Checks hand for eights
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static int HasEight(int who) {
            Card check;
            for (int i = 0; i < hands[who].GetCount(); i++) {
                check = hands[who].GetCard(i);
                if (check.GetFaceValue() == FaceValue.Eight) {
                    return i;
                } // end if
            } // end for
            return -1;
        } // end HasEight

        /// <summary>
        /// Checks computer's hand for valid moves and performs the move.
        /// </summary>
        public static bool ComputerTurn(Suit suit) {
            int valIndex = HasValue(0);
            int suitIndex = HasSuit(suit, 0);
            int eightIndex = HasEight(0);
            // check value first as per rules
            if (valIndex >= 0) {
                discardPile.Add(hands[0].GetCard(valIndex));
                hands[0].RemoveAt(valIndex);
                return true;
            // check suit second
            } else if (suitIndex >= 0) {
                discardPile.Add(hands[0].GetCard(suitIndex));
                hands[0].RemoveAt(suitIndex);
                return true;
            // check eights last
            } else if (eightIndex >= 0) {
                discardPile.Add(hands[0].GetCard(eightIndex));
                hands[0].RemoveAt(eightIndex);
                return true;
            } else {
                // give the CPU a card if their hand isn't maxed
                if (!MaxHand(0)) {
                    DealOneCardTo(0);
                    return false;
                } else {
                    return false;
                }// end if
            } // end if
        } // end ComputerTurn

        /// <summary>
        /// Checks for max hand size
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static bool MaxHand(int who) {
            if (hands[who].GetCount() < MAX_HAND_SIZE) {
                return false;
            } else {
                return true;
            } // end if
        } // end MaxHand

        /// <summary>
        /// Checks player for empty hand (winner)
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static bool EmptyHand(int who) {
            // check hand size is <= 0
            if (hands[who].GetCount() <= 0) {
                return true;
            } else {
                return false;
            } // end if
        } // end EmptyHand

        /// <summary>
        /// Deals a card to the discard pile to start the game
        /// </summary>
        /// <returns></returns>
        public static Card DealOneCard() {
            Card card = drawPile.DealOneCard();
            discardPile.Add(card);
            return card;
        } // end DealOneCard

        /// <summary>
        /// Gets the current top of the discard pile
        /// </summary>
        /// <returns></returns>
        public static Card CurrentDiscard() {
            return discardPile.GetLastCardInPile();
        } // end CurrentDiscard

        /// <summary>
        /// Gets a players hand
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static Hand GetHand(int who)
        {
            return hands[who];
        }//end GetHand

        /// <summary>
        /// Sorts the players hand
        /// </summary>
        public static void SortHand() {
            hands[1].Sort();
        } // end SortHand
    }//end class
}//end namespace
