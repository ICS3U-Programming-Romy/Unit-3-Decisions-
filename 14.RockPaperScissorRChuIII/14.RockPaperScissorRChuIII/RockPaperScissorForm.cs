/*
 * Created by: Romy I. Chu III
 * Created on: 05-03-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program... Allows a person to play Rock, Paper, Scissors against a computer
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
            grbComputerChoice.Enabled = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Declares the variables
            int playerChoice, computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSOR = 3;

            //This gets the players choices, if the player's choice is null (nothing) it is set to 0
            #region Player Radio Buttons
            if (radPlayerRock.Checked == true)
            {
                playerChoice = ROCK;
            }
            else if (radPlayerPaper.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radPlayerScissor.Checked == true)
            {
                playerChoice = SCISSOR;
            }
            else
            {
                playerChoice = 0;
            }
            #endregion
            computerChoice = ranNumGen.Next(minValue, maxValue + 1);


            #region Computer Radio Buttons
            if (computerChoice == ROCK)
            {
                this.radComputerRock.Checked = true;
            }
            else if (computerChoice == PAPER)
            {
                this.radComputerPaper.Checked = true;
            }
            else if (computerChoice == SCISSOR)
            {
                this.radComputerScissor.Checked = true;
            }
            #endregion

            #region Win Lose Cases
            if (playerChoice == 0)
            {
                lblWinLose.Text = "Yo. Choose something. No one Wins!";
            }

            if (playerChoice == computerChoice)
            {
                lblWinLose.Text = "It's a Tie!!";
            }

            else if (playerChoice == ROCK)
            {
                if (computerChoice == PAPER)
                {
                    lblWinLose.Text = "You Lose!!!";
                }
                if (computerChoice == SCISSOR)
                {
                    lblWinLose.Text = "You Win !!!";
                }
            }
            else if (playerChoice == PAPER)
            {
                if (computerChoice == SCISSOR)
                {
                    lblWinLose.Text = "You Lose!!!";
                }
                if (computerChoice == ROCK)
                {
                    lblWinLose.Text = "You Win !!!";
                }
            }
            else if (playerChoice == SCISSOR)
            {
                if (computerChoice == ROCK)
                {
                    lblWinLose.Text = "You Lose!!!";
                }
                if (computerChoice == PAPER)
                {
                    lblWinLose.Text = "You Win !!!";
                }
            }
            #endregion
        }
    }
}
