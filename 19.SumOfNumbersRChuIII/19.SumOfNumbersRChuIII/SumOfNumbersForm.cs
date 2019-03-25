/*
 * Created by: Romy I. Chu III
 * Created on: 25-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 - Sum of Numbers
 * This program... Calculates the sum of a number, inputted by the user, with all previous numbers.
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

namespace _19.SumOfNumbersRChuIII
{
    public partial class frmSumOfNumbers : Form
    {
        public frmSumOfNumbers()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declares the variables
            int sumAnswer;
            int sumNumber;
            int sumCounter;

            //Clears the list box
            this.lstNumbers.Items.Clear();

            //Initializes the answer to 0
            sumAnswer = 0;

            //gets the number from the text box
           sumNumber = Convert.ToInt32(this.txtUserInput.Text);

            //calculates the sum
            for (sumCounter = 1; sumCounter <= sumNumber; sumCounter++)
            {
                //Adds the counter number to the list
                this.lstNumbers.Items.Add(sumCounter);

                //Adds up the sum
                sumAnswer += sumCounter;
            }
            //Changes the label to display the sum
            this.lblAnswer.Text = "The sum of " + this.txtUserInput.Text + " and all previous numbers is : " + Convert.ToString(sumAnswer);
        }
    }
}
