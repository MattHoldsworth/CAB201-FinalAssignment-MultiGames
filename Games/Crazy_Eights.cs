using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Games_Logic_Library;
using Low_Level_Objects_Library;
using System.Threading;

namespace Games {
    public partial class Crazy_Eights : Form {
        TableLayoutPanel[] tableLayoutPanels;
        Suit eightsuit;
        public Crazy_Eights() {
            InitializeComponent();
            Crazy_Eights_Game.SetUpGame();
            tableLayoutPanels = new TableLayoutPanel[Crazy_Eights_Game.NUM_OF_PLAYERS] {pTableLayoutPanel, cTableLayoutPanel};
        }

        /// <summary>
        /// Displays the draw pile
        /// </summary>
        private void DisplayDrawPile() {
            drawPile.Image = Images.GetBackOfCardImage();
        }

        /// <summary>
        /// Displays the discard pile;
        /// </summary>
        private void DisplayDiscardPile() {
            Card card = Crazy_Eights_Game.CurrentDiscard();
            discardPile.Image = Images.GetCardImage(card);
        }

        /// <summary>
        /// Displays the players' hands
        /// </summary>
        /// <param name="hand"></param>
        /// <param name="tableLayoutPanel"></param>
        /// <param name="who"></param>
        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel, int who) {
            tableLayoutPanel.Controls.Clear();  // Remove any cards already being shown.
            foreach (Card card in hand) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(72, 95);
                // Tell the PictureBox to use all the space inside its square.
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = Images.GetCardImage(card);
                // Add the PictureBox object to the tableLayoutPanel.
                // Allow the user to click on a card in their hand.
                if (who == 1) {
                // Set event-handler for Click on this PictureBox.
                    pictureBox.Click += new EventHandler(pictureBox_Click);
                // Tell the PictureBox which Card object it is a picture of.
                    pictureBox.Tag = card;
                }
                tableLayoutPanel.Controls.Add(pictureBox);

            }//end foreach
        }//end DisplayGuiHand

        private void pictureBox_Click(object sender, EventArgs e) {
            // Which card was clicked?
            PictureBox clickedPictureBox = (PictureBox)sender;
            Card clickedCard = (Card)clickedPictureBox.Tag;
            TryToPlayCard(clickedCard);

        }

        /// <summary>
        /// Checks if card player clicked on is valid, plays it then passes turn to CPU
        /// </summary>
        /// <param name="clickedCard"></param>
        private void TryToPlayCard(Card clickedCard) {
            Card discard = Crazy_Eights_Game.CurrentDiscard();
            Suit discardSuit = discard.GetSuit();
            // check for crazy eight suit
            if (discard.GetFaceValue() == FaceValue.Eight) {
                discardSuit = eightsuit;
            }
            // Check if card is valid and play it
            if (Crazy_Eights_Game.IsGoodClick(clickedCard, discardSuit)) {
                // Update GUI with new cards
                discardPile.Image = Images.GetCardImage(clickedCard);
                DisplayDrawPile();
                DisplayGuiHand(Crazy_Eights_Game.GetHand(1), pTableLayoutPanel, 1);
                //MessageBox.Show(clickedCard.ToString(false, true), "Clicked");
                
                // Check for empty hand after turn
                if (Crazy_Eights_Game.EmptyHand(1)) {
                    MessageBox.Show("Player wins!", "Game Over");
                    this.Close();
                } // end if
                // CPU Go
                if (clickedCard.GetFaceValue() == FaceValue.Eight) {
                    using (Eight_suit eight_suit = new Eight_suit()) {
                        if (eight_suit.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                            eightsuit = eight_suit.SelectedSuit;
                            //instructionLabel.Text = "Last crazy eights suit is" + eightsuit.ToString();
                        } else {
                            Card card = Crazy_Eights_Game.CurrentDiscard();
                            eightsuit = card.GetSuit();
                        }
                    }
                }
                CpuGo();
            } else {
                MessageBox.Show(clickedCard.ToString(false, true) + " is not a valid option.", "Clicked");
            } // end if
        } // end TryToPlayCard

        /// <summary>
        /// Refreshes the form then pauses
        /// </summary>
        private static void RefreshTheFormThenPause() {
            // form display any recent changes to any Controls
            Application.DoEvents();

            // Wait, then continue.
            const int HALF_SECOND = 500; // milliseconds.
            Thread.Sleep(HALF_SECOND);
        } //end RefreshTheFormThenPause

        private void dealButton_Click(object sender, EventArgs e) {
            dealButton.Enabled = false;
            // deal 8 to each if handsize is 0, or deal 1 and pass
            if (Crazy_Eights_Game.DealStart()) {
                for (int i = 0; i <= 7; i++) {
                    Crazy_Eights_Game.DealOneCardTo(0);//deals one card to dealer
                    Crazy_Eights_Game.DealOneCardTo(1);//deals one card to user
                } // end for
                  //displays images of dealer and users hands
                DisplayGuiHand(Crazy_Eights_Game.GetHand(0), cTableLayoutPanel, 0);
                DisplayGuiHand(Crazy_Eights_Game.GetHand(1), pTableLayoutPanel, 1);
                DisplayDrawPile();
                discardPile.Image = Images.GetCardImage(Crazy_Eights_Game.DealOneCard());
            } else {
                // check for max hand size, then a tied game, and deal if not
                if (!Crazy_Eights_Game.MaxHand(1)) {
                    Crazy_Eights_Game.DealOneCardTo(1);
                    DisplayGuiHand(Crazy_Eights_Game.GetHand(1), pTableLayoutPanel, 1);
                } else if (Crazy_Eights_Game.MaxHand(0)) {
                    MessageBox.Show("Neither player can play, game is a tie!", "Game Over");
                    this.Close();
                } else {
                    MessageBox.Show("Handsize limit reached, passing turn.", "Deal");
                } // end if
                // pass turn to CPU
                CpuGo();
            } // end if
        } // end dealButton_Click

        /// <summary>
        /// Performs the CPU's turn then passes back to the player
        /// </summary>
        private void CpuGo() {
            RefreshTheFormThenPause();
            Card discard = Crazy_Eights_Game.CurrentDiscard();
            Suit discardSuit = discard.GetSuit();
            // check for player selected crazy eight suit
            if (discard.GetFaceValue() == FaceValue.Eight) {
                discardSuit = eightsuit;
            } // end if
            // reset the discard suit for players next turn if the CPU played something
            if (Crazy_Eights_Game.ComputerTurn(discardSuit)) {
                eightsuit = Crazy_Eights_Game.CurrentDiscard().GetSuit();
                discardSuit = Crazy_Eights_Game.CurrentDiscard().GetSuit();
            } // end if
            // check for tied game
            if (Crazy_Eights_Game.MaxHand(1) && Crazy_Eights_Game.MaxHand(0) && !Crazy_Eights_Game.PlayerHasMove(discardSuit)) {
                MessageBox.Show("Neither player can play, game is a tie!", "Game Over");
                this.Close();
            } // end if
            DisplayGuiHand(Crazy_Eights_Game.GetHand(0), cTableLayoutPanel, 0);
            DisplayDiscardPile();
            // Checks for empty hand after turn
            if (Crazy_Eights_Game.EmptyHand(0) && !Crazy_Eights_Game.EmptyHand(1)) {
                MessageBox.Show("Computer Wins!", "Game Over");
                this.Close();
            } // end if
            // Pass back to player
            if (!Crazy_Eights_Game.PlayerHasMove(discardSuit)) {
                dealButton.Enabled = true;
            } // end if
        } // end CpuGo

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        } // end cancelButton_Click

        private void sortButton_Click(object sender, EventArgs e) {
            Crazy_Eights_Game.SortHand();
            DisplayGuiHand(Crazy_Eights_Game.GetHand(1), pTableLayoutPanel, 1);

        } // end sortButton_Click
    } // end class
} // end namespace
