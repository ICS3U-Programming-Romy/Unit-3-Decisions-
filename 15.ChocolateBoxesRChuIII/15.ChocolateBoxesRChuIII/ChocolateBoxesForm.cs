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
                lblReward.Visible = true;
                lblReward.Text = "You get the Top Prize!!";
            }
            else
            {
                if (soldBoxes <= 10)
                {
                    lblReward.Text = "You Get an Honorable Mention!!";
                    lblReward.Visible = true;
                }
                else
                {
                    lblReward.Text = "You Get a Small Prize!!";
                    lblReward.Visible = true;
                }
            }
        }
    }
}
