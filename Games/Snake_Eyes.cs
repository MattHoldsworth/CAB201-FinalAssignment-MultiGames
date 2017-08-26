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
    public partial class Snake_Eyes : Form
    {
        public Snake_Eyes()
        {
            InitializeComponent();
            dummyTextLabel.Visible = false;
            playButton.Enabled = false;
            Snake_Eyes_Game.SetUpGame();
            UpdateImage();
        }//end Snake_Eyes form constructor

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (Snake_Eyes_Game.GetPlayersPoints() > Snake_Eyes_Game.GetHousePoints())
            {
                MessageBox.Show("You won! Well done.");
                this.Close();
            }
            else if (Snake_Eyes_Game.GetPlayersPoints() < Snake_Eyes_Game.GetHousePoints())
            {
                MessageBox.Show("House won! Better luck next time.");
                this.Close();
            }
            else
            {
                MessageBox.Show("It was a draw!");
                this.Close();
            }//end if-else
        }//end cancelButton

        private void playButton_Click(object sender, EventArgs e)
        {
            rollButton.Enabled = true;
            playButton.Visible = false;
            Snake_Eyes_Game.SetUpGame();
        }//end playButton

        private void rollButton_Click(object sender, EventArgs e)
        {
            Snake_Eyes_Game.InitCounter();
            timer1.Enabled = true;
            timer1.Start();
            rollButton.Enabled = false;
        }//end rollButton

        private void UpdateImage()
        {
            UpdatePictureBoxImage(pictureBox1, Snake_Eyes_Game.GetDieFaceValue(1));//updates picturebox1 with die image
            UpdatePictureBoxImage(pictureBox2, Snake_Eyes_Game.GetDieFaceValue(2));//updates picturebox2 with die image
        }//end UpdateImage

        private void UpdatePictureBoxImage(PictureBox whichPB, int faceValue)
        {
            whichPB.Image = Images.GetDieImage(faceValue);//gets die image depending on facevalue
        }//endUpdatePictureBoxImage


        private void Snake_Eyes_Load(object sender, EventArgs e){
        }//unintentional event-handler

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool temp1;
            bool temp2;
            string output;
            string headline;
            int counter;
            Random random = new Random();

            Snake_Eyes_Game.IncrementCounter();//increments counter
            counter = Snake_Eyes_Game.GetCounter();//gets counter

            int faceValue = random.Next(1, 6);//creates random number between 1 and 6

            if (counter < 9)
            {
                UpdatePictureBoxImage(pictureBox1, faceValue);//updates pictureBox1 with random face value
                UpdatePictureBoxImage(pictureBox2, faceValue);//updates pictureBox2 with random face value
            }
            else
            {
                timer1.Stop();//stops timer
                Snake_Eyes_Game.RollDice();//rolls dice
                if (Snake_Eyes_Game.RollCount() < 2)//if rollcount is less than 2
                {
                    temp1 = Snake_Eyes_Game.FirstRoll();//execute FirstRoll()
                    if (temp1 == false)
                    {
                        playButton.Enabled = true;
                        playButton.Visible = true;
                    }
                    else
                    {
                        rollButton.Enabled = true;
                    }//end if
                }
                else if (Snake_Eyes_Game.RollCount() >= 2)
                {
                    rollButton.Enabled = true;
                    temp2 = Snake_Eyes_Game.AnotherRoll();
                    if (temp2 == false)
                    {
                        playButton.Enabled = true;
                        playButton.Visible = true;
                        rollButton.Enabled = false;
                    }
                    else
                    {
                        rollButton.Enabled = true;
                    }//end if
                }//end else-if

                UpdateImage();//updates dice images with new face values
                output = Snake_Eyes_Game.GetRollOutcome();//creates output variable
                dummyTextLabel.Text = output;//displays output in dummy label
                dummyTextLabel.Visible = true;//makes dummy label visible
                headline = Snake_Eyes_Game.GetRollHeadline();//creates headline variable
                firstRollLabel.Text = headline;//displays headline on form
                playersScoreLabel.Text = Snake_Eyes_Game.GetPlayersPoints().ToString();//displays players points on form
                houseScoreLabel.Text = Snake_Eyes_Game.GetHousePoints().ToString();//displays house points on form
            }//end else
        }
    }//end class
}//end namespace
