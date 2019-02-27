/*
 * Created by: Romy I. Chu III
 * Created on: 27-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #16 - Name of Program
 * This program...asks the user to to guess my secret number (a constant). 
 *                 If the user guesses correctly, a checkmark is shown with 
 *                 a ding sound. Otherwise, an X is shown with a dong sound.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _12.GuessingGameRChuIII
{
    public partial class frmGuessingGame : Form
    {
        public frmGuessingGame()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            //Declares the Variables
            const int number = 6;
            int numGuess;

            //Gets the number that the user put
            numGuess = int.Parse(txtInput.Text);

            //Check if the user got the number correct and displays if they did or did not.
            if (numGuess == number)
            {
                lblAnswer.Show(); //Shows the lable
                picYesORNo.Show(); //Shows the image
                lblAnswer.Text = "Your Answer was Correct!"; //Changes text
                picYesORNo.Image = Properties.Resources.checkmark;
                SoundPlayer ding = new SoundPlayer(@"Correct.wav");
                ding.Play();  //Plays sound

            }
            else
            {
                lblAnswer.Show(); //Shows the lable
                picYesORNo.Show(); //Shows the image
                lblAnswer.Text = "Your Answer was Incorrect"; //Changes text
                picYesORNo.Image = Properties.Resources.red_x;
                SoundPlayer dong = new SoundPlayer(@"Wrong.wav");
                dong.Play(); //Plays sound
            }
        }
    }
}
