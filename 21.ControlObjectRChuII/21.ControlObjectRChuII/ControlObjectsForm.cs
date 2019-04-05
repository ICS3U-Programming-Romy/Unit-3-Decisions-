/*
 * Created by: Romy I. Chu III
 * Created on: 01-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program... that changes the properties of the objects that inherit from control.
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

namespace _21.ControlObjectRChuII
{
    public partial class frmControlObjects : Form
    {
        public frmControlObjects()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            //For every object in this form that is from the Control class......
            foreach (Control aControlObject in this.Controls)
            {
                //Change thier background color to Hot Pink
                aControlObject.BackColor = Color.HotPink;

                //And if the obejct is of type 'label'.......
                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Blue;         //Change the background color to Blue
                    aControlObject.ForeColor = Color.White;        //Change the text color to White
                    aControlObject.Location = new Point(110, 140); //Move the object to point (110, 140)
                    lblYes.Text = "This has changed";              //Change what the label says to "This has changed"
                }
            }
        }
    }
}
