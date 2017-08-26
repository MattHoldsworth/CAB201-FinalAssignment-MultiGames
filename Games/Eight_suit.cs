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
    public partial class Eight_suit : Form {

        public Low_Level_Objects_Library.Suit SelectedSuit { get; set; }
        public Eight_suit() {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            SelectedSuit = Low_Level_Objects_Library.Suit.Clubs;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            SelectedSuit = Low_Level_Objects_Library.Suit.Diamonds;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            SelectedSuit = Low_Level_Objects_Library.Suit.Hearts;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) {
            SelectedSuit = Low_Level_Objects_Library.Suit.Spades;
        }
    }
}
