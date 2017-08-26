using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Low_Level_Objects_Library;

namespace Low_Level_Objects_Library {
     public class Hand : IEnumerable {
        private List<Card> hand = new List<Card>();

        public Hand() {
        }//end default constructor

        public Hand(List<Card> cards) {
            hand = cards;
        }//end Hand

        public int GetCount() {
            return hand.Count();
        }//end GetCount

        public Card GetCard(int index) {
           return hand[index];
        }//end GetCard

        public void Add(Card card) {
            hand.Add(card);
        }//end Add

        public bool Contains(Card card) {
            if (hand.Contains(card)) {
                return true;
            } else {
                return false;
            }//end if-else
        }//end Contains

        public bool Remove(Card card) {
            if (hand.Contains(card)) {
                hand.Remove(card);
                return true;
            } else {
                return false;
            }//end if-else
        }//end Remove

        public void RemoveAt(int index) {
            hand.RemoveAt(index);
        }//end RemoveAt

        public void Sort() {
            hand.Sort();
        }//end Sort

        public IEnumerator GetEnumerator() {
            return hand.GetEnumerator();
        }//end GetEnumerator
    }//end Hand class
}//end namespace
