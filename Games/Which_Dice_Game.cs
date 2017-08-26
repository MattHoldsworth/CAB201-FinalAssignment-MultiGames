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
    public partial class Which_Dice_Game : Form {

        public Which_Dice_Game() {
            InitializeComponent();
        }//end Which_Dice_Game

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBox1.Text == "Snake Eyes") {
                Form GameForm = new Snake_Eyes();//creates form
                GameForm.Show();//displays newly created form
            }
            else if (comboBox1.Text == "Ship Captain and Crew") {
                Form GameForm = new Ship_Captain_Crew();//creates form
                GameForm.Show();//displays newly created form
            }//end if-else
        }//end comboBox1

        private void button1_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Would you like to exit?", "Quit?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);//displays yes/no messagebox
            if (result == DialogResult.Yes){
                Application.Exit();//closes form if user clicks yes
            } else {
            }//end if-else -- do nothing if user clicks no
        }//end button1_Click

    }//end class
}//end namespace
