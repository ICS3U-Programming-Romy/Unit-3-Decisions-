/*
 * Created by: Romy I. Chu III
 * Created on: 02-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Alphabet Nested Loops
 * This program...displays the alphabet (A - Z) then the alphabet but not capitalized (a - z)
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

namespace _22.LettersNestedLoopsRChuIII
{
    public partial class frmLettersNestedLoops : Form
    {
        public frmLettersNestedLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declares the variables
            int unicodeLetterCaps;
            int unicodeLetterLowCase;

            //clears the list
            lstLetters.Items.Clear();

            //Lists all of the stuff and things
            for (unicodeLetterCaps = 65; unicodeLetterCaps <= 90; unicodeLetterCaps++)
            {
                for(unicodeLetterLowCase = 97; unicodeLetterLowCase <= 122; unicodeLetterLowCase++)
                {
                    //Converts the integers to their unicode value and adds them to the list box.
                    lstLetters.Items.Add(Char.ConvertFromUtf32(unicodeLetterCaps) + " -> " + Char.ConvertFromUtf32(unicodeLetterLowCase));
                }
            }
        }
    }
}
