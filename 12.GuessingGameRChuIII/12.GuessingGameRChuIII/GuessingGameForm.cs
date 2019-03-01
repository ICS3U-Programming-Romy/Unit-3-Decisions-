/*
 * Created by: Romy I. Chu III
 * Created on: 27-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #16 - Name of Program
 * This program...asks the user to to guess my secret number (a constant). 
 *                 If the user guesses correctly, a checkmark is shown with 
 *                 a ding sound. Otherwise, an X is shown with a dong sound.
 *(For day 17, It now generates a random number everytime the form is loaded).
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
        int correctGuess;
        Random randomNumGen = new Random();
        const int minValue = 1;
        const int maxValue = 15;

        public frmGuessingGame()
        {
            InitializeComponent();
            correctGuess = randomNumGen.Next(minValue, maxValue + 1);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            //Declares the Variables
            //const int number = 6;
            int numGuess;

            //Gets the number that the user put
            numGuess = int.Parse(txtInput.Text);

            //Check if the user got the number correct and displays if they did or did not.
            if (numGuess == correctGuess)
            {
                SoundPlayer ding = new SoundPlayer(@"Correct.wav");
                ding.Play();  //Plays sound
                lblAnswer.Show(); //Shows the lable
                picYesORNo.Show(); //Shows the image
                lblAnswer.Text = "Your Answer was Correct!"; //Changes text
                picYesORNo.Image = Properties.Resources.checkmark;

            }
            else
            {
                SoundPlayer dong = new SoundPlayer(@"Wrong.wav");
                dong.Play(); //Plays sound
                lblAnswer.Show(); //Shows the lable
                picYesORNo.Show(); //Shows the image
                lblAnswer.Text = "Your Answer was Incorrect"; //Changes text
                picYesORNo.Image = Properties.Resources.red_x;
            }
        }
    }
}
