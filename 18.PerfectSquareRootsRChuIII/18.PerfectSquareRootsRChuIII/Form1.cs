/*
 * Created by: Romy I. Chu III
 * Created on: 25-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Perfect Squares with While Loop
 * This program... Finds the perfect squares in a given number.
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

namespace _18.PerfectSquareRootsRChuIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declares the local variables
            int endingValue;
            int value;
            Double sqrRootDouble;
            int sqrRootInt;

            //initializes the values
            value = 1;

            //Clears the list box
            lstPerfectSquares.Items.Clear();

            //Gets the user's number from the text box
            endingValue = Convert.ToInt32(nudInput.Value);

            //Checks and states any perfect squares
             while (value <= endingValue)
            {
                //Gets the square root of the number as a double
                sqrRootDouble = Math.Sqrt(value);

                //Gets the square root of the number as a integer
                sqrRootInt = Convert.ToInt32(Math.Sqrt(value));

                //Checks if it is a perfect root.
                if(sqrRootInt == sqrRootDouble)
                {
                    //if it is a perfect square, it adds it to the list
                    this.lstPerfectSquares.Items.Add(value + " is a perfect square.");
                }

                this.Refresh();
                value++;
            }
        }
    }
}
