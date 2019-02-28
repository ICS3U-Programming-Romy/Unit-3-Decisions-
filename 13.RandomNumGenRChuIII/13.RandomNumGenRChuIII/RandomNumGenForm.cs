/*
 * Created by: Romy I. Chu III
 * Created on: 28-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Random Number Generator
 * This program...Generates a random number when a button is clicked
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

namespace _13.RandomNumGenRChuIII
{
    public partial class frmRandomNumGen : Form
    {
        public frmRandomNumGen()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //declares the variables
            const int numMin = 1;
            const int numMax = 1000;
            int numRandom;
            Random ranNumGen = new Random();

            //Generates the random number
            numRandom = ranNumGen.Next(numMin, numMax + 1);

            //Changes the label to what the randomly generated number.
            lblNumber.Text = "Your number is :  " + Convert.ToString(numRandom);
        }
    }
}
