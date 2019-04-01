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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.HotPink;

                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Blue;
                    aControlObject.ForeColor = Color.White;
                    aControlObject.Location = new Point(110, 140);
                    lblYes.Text = "This has changed";
                }
            }
        }
    }
}
