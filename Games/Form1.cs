using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games {
    /// <summary>
    /// Matthew Holdsworth - 08576904
    /// Steven Robley - 02375061
    /// 
    /// Main Assignment (40%) - Games
    /// This program enables the user to select a game from a number of options to play.
    /// </summary>
    public partial class Form1 : Form {
        public Form1() {

            InitializeComponent();
            startButton.Enabled = false;
            groupBox1.Enabled = true;
            exitButton.Enabled = true;
            
        }//end Form1

        private void groupBox1_Enter(object sender, EventArgs e) {
            
        }//unused handler

        private void coinGameButton_CheckedChanged(object sender, EventArgs e) {
            startButton.Enabled = true;//enables start button
        }//end coinGameButton

        private void diceGameButton_CheckedChanged(object sender, EventArgs e) {
            startButton.Enabled = true;//enables start button
        }//end diceGameButton

        private void cardGameButton_CheckedChanged(object sender, EventArgs e) {
            startButton.Enabled = true;//enables start button
        }//end cardGameButton

        private void startButton_Click(object sender, EventArgs e) {
            if (coinGameButton.Checked == true) {
                Form GameForm = new Two_Up();//creates form
                GameForm.Show();//displays newly created form
            } else if (diceGameButton.Checked == true) {
                Form GameForm = new Which_Dice_Game();//creates form
                GameForm.Show();//displays newly created form
            } else if (cardGameButton.Checked == true) {
                Form GameForm = new Which_Card_Game();//creates form
                GameForm.Show();//displays newly created form
            }//end else-if
        }//end startButton

        private void exitButton_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Would you like to exit?", "Quit?" ,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);//displays yes/no messagebox
            if (result == DialogResult.Yes) {
                this.Close();//closes form if user clicks yes
            } else {
            }//end if-else -- do nothing if user clicks no
        }//end exitButton


    }//end class
}//end namespace
