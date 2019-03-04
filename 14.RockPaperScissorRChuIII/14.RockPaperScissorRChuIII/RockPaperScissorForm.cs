/*
 * Created by: First Last
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program...
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

namespace _14.RockPaperScissorRChuIII
{
    public partial class frmRockPaperScissor : Form
    {
        const int minValue = 1;
        const int maxValue = 3;
        Random ranNumGen;

        public frmRockPaperScissor()
        {
            InitializeComponent();
            ranNumGen = new Random();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Declares the variables
            int playerChoice, computerChoice;
            const int rock = 1;
            const int paper = 2;
            const int scissor = 3;

            //This gets the players choices, if the player's choice is null (nothing) it is set to 0
            #region Player Radio Buttons
            if (radPlayerRock.Checked == true)
            {
                playerChoice = rock;
            }
            else if (radPlayerPaper.Checked == true)
            {
                playerChoice = paper;
            }
            else if (radPlayerScissor.Checked == true)
            {
                playerChoice = scissor;
            }
            else
            {
                playerChoice = 0;
            }
            #endregion
            computerChoice = ranNumGen.Next(minValue, maxValue + 1);


            #region Computer Radio Buttons
            if (computerChoice == rock)
            {
                this.radComputerRock.Checked = true;
            }
            else if (computerChoice == paper)
            {
                this.radComputerPaper.Checked = true;
            }
            else if (computerChoice == scissor)
            {
                this.radComputerScissor.Checked = true;
            }
            #endregion


            if (playerChoice == computerChoice)
            {
                lblWinLose.Text = "It's a Tie!!";
            }

            else if (playerChoice == rock)
            {
                if (computerChoice == paper)
                {
                    lblWinLose.Text = "You Lose!!!";
                }
                if (computerChoice == scissor)
                {
                    lblWinLose.Text = "You Win !!!";
                }
            }
            else if (playerChoice == paper)
            {
                if (computerChoice == scissor)
                {
                    lblWinLose.Text = "You Lose!!!";
                }
                if (computerChoice == rock)
                {
                    lblWinLose.Text = "You Win !!!";
                }
            }
            else if (playerChoice == scissor)
            {
                if (computerChoice == rock)
                {
                    lblWinLose.Text = "You Lose!!!";
                }
                if (computerChoice == paper)
                {
                    lblWinLose.Text = "You Win !!!";
                }
            }
        }
    }
}
