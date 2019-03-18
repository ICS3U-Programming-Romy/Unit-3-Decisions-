/*
 * Created by: Romy I. Chu III
 * Created on: 18-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program... calculates the factorial of a number that the user inputted.
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

namespace _16.FactorialDoWhileRChuIII
{
    public partial class frmFactorialDoWhile : Form
    {
        public frmFactorialDoWhile()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declares the local variables
            Double facAnswer;
            Double facNumber;
            int facCounter;

            //Clears the listbox of any items
            this.lstNumbers.Items.Clear();

            //Gets the number from the text
            facNumber = Convert.ToDouble(this.txtfacNumber.Text);

            //sets the counter to 0 and the answer to 1
            facAnswer = 1;
            facCounter = 0;

            //Multiply the counter  by the next incremented number until it reaches the user's number.
            do
            {
                //increments the counter by 1
                facCounter++;

                //list the counter number in the list box.
                this.lstNumbers.Items.Add(facCounter);

                //multiply the counter by the answer.
                facAnswer *= facCounter; 

            } while (facCounter < facNumber);

            //Displays the answer to the user.
            this.lblAnswer.Text = facNumber + "! = " + Convert.ToString(facAnswer);
        }
    }
}
