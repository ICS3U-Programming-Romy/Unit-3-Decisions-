/*
 * Created by: Romy I. Chu III
 * Created on: 19-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Walking Man Program
 * This program... that displays images in a flip-book-like manner using a while loop.
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

//This allows me to use the sleep timer
using System.Threading;

namespace _17.WalkingManRChuIII
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            //Declares the varibales and constants
            const byte MAX_FRAMES = 10;
            int picFrameCounter = 1;

            //This loop changes the image based on the frame counter.
            while (picFrameCounter < MAX_FRAMES + 1)
            {
                if (picFrameCounter == 1){
                    this.picMan.Image = Properties.Resources.walk1;
                }
                else if (picFrameCounter == 2)
                {
                    this.picMan.Image = Properties.Resources.walk2;
                }

                else if (picFrameCounter == 3)
                {
                    this.picMan.Image = Properties.Resources.walk3;
                }

                else if (picFrameCounter == 4)
                {
                    this.picMan.Image = Properties.Resources.walk4;
                }

                else if (picFrameCounter == 5)
                {
                    this.picMan.Image = Properties.Resources.walk5;
                }

                else if (picFrameCounter == 6)
                {
                    this.picMan.Image = Properties.Resources.walk6;
                }

                else if (picFrameCounter == 7)
                {
                    this.picMan.Image = Properties.Resources.walk7;
                }

                else if (picFrameCounter == 8)
                {
                    this.picMan.Image = Properties.Resources.walk8;
                }

                else if (picFrameCounter == 9)
                {
                    this.picMan.Image = Properties.Resources.walk9;
                }

                else
                {
                    this.picMan.Image = Properties.Resources.walk10;
                }

                //Adds 1 to the counter
                picFrameCounter++;

                //This refreshes the form
                this.Refresh();

                //This pauses the loop for 100 miliseconds
                Thread.Sleep(100);
            }
        }
    }
}
