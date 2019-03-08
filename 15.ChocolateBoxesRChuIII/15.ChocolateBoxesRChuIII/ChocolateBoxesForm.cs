/*
 * Created by: Romy I. Chu III
 * Created on: 09-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program...has nested if else statements.
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

namespace _15.ChocolateBoxesRChuIII
{
    public partial class frmChocolateBoxes : Form
    {
        public frmChocolateBoxes()
        {
            InitializeComponent();
        }

        private void btnReward_Click(object sender, EventArgs e)
        {
            //declares variables
            int soldBoxes;

            //Gets the number from the numeric up-down box
            soldBoxes = (int)nudBoxCount.Value;

            //Determines the rewards
            if (soldBoxes >= 20)
            { 
                //if the student sells 20 or more they get top prize
                lblReward.Visible = true;
                lblReward.Text = "You get the Top Prize!!";
            }
            else
            {
                if (soldBoxes <= 10)
                {
                    //if the student sells 10 or less they get an honorable mention
                    lblReward.Text = "You Get an Honorable Mention!!";
                    lblReward.Visible = true;
                }
                else
                {
                    //if the student sells 10 or more, but less than 20 they get a small prize
                    lblReward.Text = "You Get a Small Prize!!";
                    lblReward.Visible = true;
                }
            }
        }
    }
}
