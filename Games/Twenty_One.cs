using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Low_Level_Objects_Library;
using Games_Logic_Library;

namespace Games {
    /// <summary>
    /// 
    /// </summary>
    public partial class Twenty_One : Form {
        TableLayoutPanel[] tableLayoutPanels;
        Label[] bustedLabels;
        Label[] pointsLabels;
        Label[] gamesWonLabels;

        public Twenty_One() {
            InitializeComponent();
            //testButton.Visible = false;
            // Re-show scores from previous games
            dGamesLabel.Text = Twenty_One_Game.GetNumOfGamesWon(0).ToString();
            pGamesLabel.Text = Twenty_One_Game.GetNumOfGamesWon(1).ToString();
            DisplayGuiHand(Twenty_One_Game.GetHand(0), dealerTableLayoutPanel);
            DisplayGuiHand(Twenty_One_Game.GetHand(1), userTableLayoutPanel);
            

            //ensures bust labels and points labels aren't visible at the start of a game
            pBust.Visible = false;
            dBust.Visible = false;
            pPointsLabel.Visible = false;
            dPointsLabel.Visible = false;
            //ensures the hit and stand button are not enabled before cards are dealt
            hitButton.Enabled = false;
            standButton.Enabled = false;
            //sets game up, initializing variables
            //Twenty_One_Game.SetUpGame();
            //code given in the assignment
            tableLayoutPanels = new TableLayoutPanel[Twenty_One_Game.NUM_OF_PLAYERS] { userTableLayoutPanel, dealerTableLayoutPanel };
            bustedLabels = new Label[Twenty_One_Game.NUM_OF_PLAYERS] { pBust, dBust };
            pointsLabels = new Label[Twenty_One_Game.NUM_OF_PLAYERS] { pPointsLabel, dPointsLabel };
            gamesWonLabels = new Label[Twenty_One_Game.NUM_OF_PLAYERS] { pGamesLabel, dGamesLabel };
            InitGui();
        }//end Twenty_One form constructor


        /// <summary>
        /// Code given in the assignment
        /// </summary>
        /// <param name="hand"></param>
        /// <param name="tableLayoutPanel"></param>
        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel) {
            tableLayoutPanel.Controls.Clear();  // Remove any cards already being shown.
            foreach (Card card in hand) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Tell the PictureBox to use all the space inside its square.
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = Images.GetCardImage(card);
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }//end foreach
        }//end DisplayGuiHand

        /// <summary>
        /// Sets up the GUI to continue if previous game was canceled.
        /// </summary>
        private void InitGui() {
            if (Twenty_One_Game.Continue()) {
                int userTotal = 0;
                int compTotal = 0;
                int decrementScoreBy = 10;
                dealButton.Enabled = false;
                hitButton.Enabled = true;
                standButton.Enabled = true;
                userTotal = Twenty_One_Game.CalculateHandTotal(1);
                compTotal = Twenty_One_Game.CalculateHandTotal(0);
                userTotal = userTotal - (Twenty_One_Game.GetNumOfUserAcesWithValueOne() * decrementScoreBy);
                pPointsLabel.Text = userTotal.ToString();
                dPointsLabel.Text = compTotal.ToString();
                pPointsLabel.Visible = true;
                dPointsLabel.Visible = true;
                aceLabel.Text = Twenty_One_Game.GetNumOfUserAcesWithValueOne().ToString();
            }// end if
        }// end initGui


        /*// <summary>
        /// Test button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testButton_Click(object sender, EventArgs e) {
            const int testNumOfCardsForDealer = 2;
            const int testNumOfCardsForPlayer = 8;
            CardPile testCardPile = new CardPile(true);
            testCardPile.Shuffle();
            Hand testHandForDealer = new Hand(testCardPile.DealCards(testNumOfCardsForDealer));
            Hand testHandForPlayer = new Hand(testCardPile.DealCards(testNumOfCardsForPlayer));
            DisplayGuiHand(testHandForDealer, dealerTableLayoutPanel);
            DisplayGuiHand(testHandForPlayer, userTableLayoutPanel);
        }//end testButton*/


        /// <summary>
        /// Displays a message to the user and closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e) {
            if (Twenty_One_Game.GetNumOfGamesWon(0) < Twenty_One_Game.GetNumOfGamesWon(1)) {
                MessageBox.Show("Congratulations you won, " + Twenty_One_Game.GetNumOfGamesWon(1) + " to " + Twenty_One_Game.GetNumOfGamesWon(0) + ".");
            } else if (Twenty_One_Game.GetNumOfGamesWon(1) < Twenty_One_Game.GetNumOfGamesWon(0)) {
                MessageBox.Show("Sorry you lost, " + Twenty_One_Game.GetNumOfGamesWon(0) + " to " + Twenty_One_Game.GetNumOfGamesWon(1) + ".");
            } else {
                MessageBox.Show("Scores were tied, " + Twenty_One_Game.GetNumOfGamesWon(0) + " to " + Twenty_One_Game.GetNumOfGamesWon(1) + ".");
            }
            //Twenty_One_Game.ResetTotals();
                this.Close();
        }//end cancelButton


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dealButton_Click(object sender, EventArgs e) {
            int dealerTotal;
            int userTotal;
            int decrementScoreBy = 10;

            //resets ace label value
            aceLabel.Text = "0";
            Twenty_One_Game.SetNumOfAcesValuedOneToZero();
            //ensures the bust labels are not visible at the start of a second game
            dBust.Visible = false;
            pBust.Visible = false;
            Twenty_One_Game.DealOneCardTo(0);//deals one card to dealer
            Twenty_One_Game.DealOneCardTo(0);//deals second card to dealer
            Twenty_One_Game.DealOneCardTo(1);//deals one card to user
            Twenty_One_Game.DealOneCardTo(1);//deals second card to user
            //displays images of dealer and users hands
            DisplayGuiHand(Twenty_One_Game.GetHand(0), dealerTableLayoutPanel);
            DisplayGuiHand(Twenty_One_Game.GetHand(1), userTableLayoutPanel);
            //resets the GUI buttons for next play
            dealButton.Enabled = false;
            hitButton.Enabled = true;
            standButton.Enabled = true;
            //Calculates hand total for dealer then the user
            dealerTotal = Twenty_One_Game.CalculateHandTotal(0);
            userTotal = Twenty_One_Game.CalculateHandTotal(1);

            foreach (Card card in Twenty_One_Game.GetHand(1)) {
                if (card.GetFaceValue() == FaceValue.Ace) {
                    //displays message box asking user whether to count ace as 1
                    DialogResult dialogResult = MessageBox.Show("Count Ace as 1?", "You got an Ace!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) {
                        //increments numofuseraceswithvalueone if user clicks yes
                        Twenty_One_Game.IncrementNumofUserAcesWithValueOne();
                        //updates aceLabel with the number of aces
                        aceLabel.Text = Twenty_One_Game.GetNumOfUserAcesWithValueOne().ToString();
                    }//end nested if
                }//end if
            }//end foreach

            
            //decrements user total by the number of aces multipled by the decrement value of 10
            userTotal = userTotal - (Twenty_One_Game.GetNumOfUserAcesWithValueOne() * decrementScoreBy);
            //changes totals to strings and change label text to totals
            dPointsLabel.Text = dealerTotal.ToString();
            pPointsLabel.Text = userTotal.ToString();
            //makes points labels visible
            pPointsLabel.Visible = true;
            dPointsLabel.Visible = true;
        }//end dealButton


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hitButton_Click(object sender, EventArgs e) {
            int userTotal;
            int decrementScoreBy = 10;

            Card card = Twenty_One_Game.DealOneCardTo(1);//deals one card to user
            DisplayGuiHand(Twenty_One_Game.GetHand(1), userTableLayoutPanel); //display users hand
            userTotal = Twenty_One_Game.CalculateHandTotal(1); //calculate adjusted user total
            //decrement user total by ace decrement value if user responded yes

            if (card.GetFaceValue() == FaceValue.Ace) {
                    //show messagebox asking user if they want to count their ace as one
                    DialogResult dialogResult = MessageBox.Show("Count Ace as 1?", "You got an Ace!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) {
                        //updates number of user aces with value 1 and appropriate label
                        Twenty_One_Game.IncrementNumofUserAcesWithValueOne();
                        aceLabel.Text = Twenty_One_Game.GetNumOfUserAcesWithValueOne().ToString();
                    }//end nested if
                }//end if

           
            userTotal = userTotal - (Twenty_One_Game.GetNumOfUserAcesWithValueOne() * decrementScoreBy);
            //changes usertotal to a string and change points label text to total
            pPointsLabel.Text = userTotal.ToString();

            if (userTotal <= 21) {
                //sets bust labels to not visible and hitbutton to enabled while the user keeps playing
                pBust.Visible = false;
                hitButton.Enabled = true;
            } else {
                //if total is greater than 21, sets bust label to visible, disables play and stand buttons and enables deal button
                pBust.Visible = true;
                hitButton.Enabled = false;
                standButton.Enabled = false;
                dealButton.Enabled = true;
                //increments dealers games won total and updates appropriate label to show the new score
                Twenty_One_Game.IncrementGamesWon(0);
                dGamesLabel.Text = Twenty_One_Game.GetNumOfGamesWon(0).ToString();
                Twenty_One_Game.ResetTotals();
            }//end if-else

        }//end hitButton


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void standButton_Click(object sender, EventArgs e) {
            
            hitButton.Enabled = false;
            standButton.Enabled = false;
            int dealerTotal = Twenty_One_Game.GetTotalPoints(0);
            int userTotal = Twenty_One_Game.GetTotalPoints(1);
            // gets the user total from the GUI to avoid ace bug
            int.TryParse(pPointsLabel.Text, out userTotal);

            //while the dealer total is less than the user total and less than 21, keeping dealing cards to dealer
            while ((dealerTotal < 21) && (userTotal > dealerTotal)) {
                Twenty_One_Game.PlayForDealer();
                dealerTotal = Twenty_One_Game.CalculateHandTotal(0);
                DisplayGuiHand(Twenty_One_Game.GetHand(0), dealerTableLayoutPanel);
                dPointsLabel.Text = dealerTotal.ToString();
            }

            if (dealerTotal > 21) {
                Twenty_One_Game.IncrementGamesWon(1);//adds a point to the users score
                pGamesLabel.Text = Twenty_One_Game.GetNumOfGamesWon(1).ToString();//outputs a new score to form
                dBust.Visible = true;
                dealButton.Enabled = true;
                Twenty_One_Game.ResetTotals();
            } else if (dealerTotal > userTotal) {
                Twenty_One_Game.IncrementGamesWon(0);//adds a point to the dealers score
                dGamesLabel.Text = Twenty_One_Game.GetNumOfGamesWon(0).ToString();//outputs new score to form
                dealButton.Enabled = true;
                Twenty_One_Game.ResetTotals();
            } else if (dealerTotal == userTotal) {
                MessageBox.Show("It was a Tie");
                dealButton.Enabled = true;
                Twenty_One_Game.ResetTotals();
            }//end if-else

        }//end standButton
    }//end class
}//end namespace
