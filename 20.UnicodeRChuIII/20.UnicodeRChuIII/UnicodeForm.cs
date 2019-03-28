/*
 * Created by: Romy I. Chu III
 * Created on: 28-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #24 - Unicode
 * This program...Displays all of the unicode value of all of the capital letters.
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

namespace _20.UnicodeRChuIII
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            //Declares the variables
            int UnicodeCounter;
            const int MAX_VALUE = 90;
            String Value;

            
            //clears the list box
            lstLetters.Items.Clear();
            
            //Writes out all of the values
            for (UnicodeCounter = 65; UnicodeCounter <=MAX_VALUE; UnicodeCounter++)
            {
                //Converts the counter's current number to the unicode value
                String UnicodeValue = Char.ConvertFromUtf32(UnicodeCounter);

                Value = UnicodeCounter + " is " + UnicodeValue + " in Unicode.";

                //adds it to the list box
                lstLetters.Items.Add(Value);
            }
            
        }
    }
}
