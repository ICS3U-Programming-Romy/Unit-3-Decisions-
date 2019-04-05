/*
 * Created by: Romy I. Chu III
 * Created on: 03-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
 * This program...Can take sequential number inputs and finds the average of all of the numbers inputted
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

namespace _23.RunningAverageRChuIII
{
    public partial class frmRunningAverage : Form
    {
        public frmRunningAverage()
        {
            InitializeComponent();
        }

        //Declaring some global variables
        int numOfNumbers = 0;
        double Total;
        double sumAverage;

        private void btnCalcualte_Click(object sender, EventArgs e)
        {
            //Declare and initialize a varible to the value of the number in the text box
            double currentNum = Convert.ToDouble(txtInput.Text);

            if (currentNum == -1)
            {
                btnCalcualte.Enabled = false;     //Disables the calculate button
                txtInput.Text = "";               //Clears the textbox
                txtInput.Enabled = false;         //Disables the text box
                lblTheAverage.Text = "Good bye!"; //Says good bye.
                currentNum = 0;                   //changes currentNum to 0  
            }

            else if (currentNum < 0 && currentNum > 100)
            {
                lblTheAverage.Text = "Please enter a valid number"; //tells the user to enter a valid number
                currentNum = 0;//changes currentNum to 0  
            } 

            else
            {
                //Increments the number of numbers counter
                numOfNumbers++;

                //Adds the current number (the number from the text box), to tge Current total.
                Total += currentNum;

                //Calculates the average, Divides the total by the number of numbers.
                sumAverage = Total / numOfNumbers;

                //Changes the label to display the average
                lblTheAverage.Text = "The running average is : " + Convert.ToString(String.Format("{0:0.00}", sumAverage));
            }
        }
    }
}
