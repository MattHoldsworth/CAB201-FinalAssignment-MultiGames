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

namespace Games
{
    public partial class Two_Up : Form
    {
        public Two_Up()
        {
            InitializeComponent();
            label1.Visible = false;
            playButton.Visible = false;
            Two_Up_Game.SetUpGame();
            UpdateImage();
        }//end Two_Up form constructor

        private void UpdateImage()
        {
            UpdatePictureBoxImage(pictureBox1, Two_Up_Game.IsHeads(1));//updates picturebox1 with coin image
            UpdatePictureBoxImage(pictureBox2, Two_Up_Game.IsHeads(2));//updates picturebox2 with coin image
        }//end UpdateImage

        private void UpdatePictureBoxImage(PictureBox whichPB, bool isHeads)
        {
            whichPB.Image = Images.GetCoinImage(isHeads);//gets coin image depending on coin face
        }//end UpdatePictureBoxImage

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();//closes the Two Up form
        }//end cancelButton

        private void playButton_Click(object sender, EventArgs e)
        {
            throwButton.Enabled = true;//enables the 'throw' button
            playButton.Visible = false;//makes 'play' button invisible
        }//end playButton

        private void throwButton_Click(object sender, EventArgs e)
        {
            Two_Up_Game.InitCounter();
            throwButton.Enabled = false;//disables 'throw' button again
            timer1.Start();
        }//end throwButton

        private void timer1_Tick(object sender, EventArgs e)
        {
            Two_Up_Game.IncrementCounter();
            bool heads = true;
            bool tails = false;
            int counter = Two_Up_Game.GetCounter();
            if ((counter == 1) || (counter == 3) || (counter == 5) || (counter == 7) || (counter == 9))
            {
                UpdatePictureBoxImage(pictureBox1, heads);
                UpdatePictureBoxImage(pictureBox2, heads);
            }
            else if ((counter == 2) || (counter == 4) || (counter == 6) || (counter == 8))
            {
                UpdatePictureBoxImage(pictureBox1, tails);
                UpdatePictureBoxImage(pictureBox2, tails);
            }
            else
            {
                timer1.Stop();
                Two_Up_Game.TossCoins();//tosses the coins
                UpdateImage();//updates the images with correct images
                label1.Text = Two_Up_Game.TossOutcome();//updates label1 with the outcome of the toss
                label1.Visible = true;//makes label1 visible
                label3.Text = Two_Up_Game.GetPlayersScore().ToString();//updates player's score when outcome is heads
                label5.Text = Two_Up_Game.GetComputersScore().ToString();//updates computer's score when outcome is tails
                playButton.Visible = true;//makes 'play' button visible
            }
        }
    }//end class
}//end namespace
