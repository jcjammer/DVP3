﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        // NAME: Justin Casimir
        // CLASS AND TERM: MDV239-L
        // PROJECT: Tic Tac Toe


        //tracks if it is x or o
        int counter = 1;
        bool newClick = true;
        Button buttonHold = new Button();


        ImageList image = new ImageList();

        public frmTicTacToe()
        {
            InitializeComponent();


            if (blueToolStripMenuItem.Checked == true)
            {
                image = blueImages;
            }
            else
            {
                image = redImages;
            }



        }

        private void r1c1button_Click(object sender, EventArgs e)
        {
            buttonHold = r1c1button;

            buttonHold.ImageList = image;

            if (counter == 0)
            {
                buttonHold.ImageIndex = 0;
                counter++;
            }
            else if (counter == 1)
            {
                buttonHold.ImageIndex = 1;
                counter--;
            }


            //Disable button so it cannot be changed
            buttonHold.Click -= r1c1button_Click;
            newClick = false;

            VerifyBoard();


        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blueToolStripMenuItem.Checked = true;
            redToolStripMenuItem.Checked = false;

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redToolStripMenuItem.Checked = true;
            blueToolStripMenuItem.Checked = false;

        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newClick == true)
            {
                xToolStripMenuItem.Checked = true;
                oToolStripMenuItem.Checked = false;

                counter = 1;
            }
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newClick == true)
            {
                oToolStripMenuItem.Checked = true;
                xToolStripMenuItem.Checked = false;

                counter = 0;
            }
        }

        private void r1c2button_Click(object sender, EventArgs e)
        {
            buttonHold = r1c2button;

            buttonHold.ImageList = image;

            if (counter == 0)
            {
                buttonHold.ImageIndex = 0;
                counter++;
            }
            else if (counter == 1)
            {
                buttonHold.ImageIndex = 1;
                counter--;
            }


            //Disable button so it cannot be changed
            buttonHold.Click -= r1c2button_Click;
            newClick = false;

            VerifyBoard();
        }

        void VerifyBoard()
        {
            if (r1c1button.ImageIndex == 1 && r2c2button.ImageIndex == 1 && r3c3button.ImageIndex == 1)
            {
                MessageBox.Show("X WINS!");
                Disable();

            }

            if (r1c1button.ImageIndex == 0 && r2c2button.ImageIndex == 0 && r3c3button.ImageIndex == 0)
            {
                MessageBox.Show("O WINS!");
                Disable();

            }

            if (r1c3button.ImageIndex == 1 && r2c2button.ImageIndex == 1 && r3c1button.ImageIndex == 1)
            {
                MessageBox.Show("X WINS!");
                Disable();


            }

            if (r1c3button.ImageIndex == 0 && r2c2button.ImageIndex == 0 && r3c1button.ImageIndex == 0)
            {
                MessageBox.Show("O WINS!");
                Disable();

            }

            if (r1c1button.ImageIndex == 1 && r1c2button.ImageIndex == 1 && r1c3button.ImageIndex == 1)
            {
                MessageBox.Show("X WINS!");
                Disable();

            }

            if (r1c1button.ImageIndex == 0 && r1c2button.ImageIndex == 0 && r1c3button.ImageIndex == 0)
            {
                MessageBox.Show("O WINS!");
                Disable();


            }

            if (r2c1button.ImageIndex == 1 && r2c2button.ImageIndex == 1 && r2c3button.ImageIndex == 1)
            {
                MessageBox.Show("X WINS!");
                Disable();

            }

            if (r1c1button.ImageIndex == 0 && r1c2button.ImageIndex == 0 && r1c3button.ImageIndex == 0)
            {
                MessageBox.Show("O WINS!");
                Disable();

            }

            if (r3c1button.ImageIndex == 1 && r3c2button.ImageIndex == 1 && r3c3button.ImageIndex == 1)
            {
                MessageBox.Show("X WINS!");
                Disable();

            }

            if (r3c1button.ImageIndex == 1 && r3c2button.ImageIndex == 1 && r3c3button.ImageIndex == 1)
            {
                MessageBox.Show("O WINS!");
                Disable();

            }

            if (r1c1button.ImageIndex == 1 && r2c1button.ImageIndex == 1 && r3c1button.ImageIndex == 1)
            {
                MessageBox.Show("X WINS!");
                Disable();

            }

            if (r1c1button.ImageIndex == 0 && r2c1button.ImageIndex == 0 && r3c1button.ImageIndex == 0)
            {
                MessageBox.Show("O WINS!");
                Disable();

            }

            if (r1c2button.ImageIndex == 1 && r2c2button.ImageIndex == 1 && r3c2button.ImageIndex == 1)
            {
                MessageBox.Show("X WINS!");
                Disable();

            }

            if (r1c2button.ImageIndex == 0 && r2c2button.ImageIndex == 0 && r3c2button.ImageIndex == 0)
            {
                MessageBox.Show("O WINS!");
                Disable();

            }

            if (r1c3button.ImageIndex == 1 && r2c3button.ImageIndex == 1 && r3c3button.ImageIndex == 1)
            {
                MessageBox.Show("X WINS!");
                Disable();

            }

            if (r1c3button.ImageIndex == 0 && r2c3button.ImageIndex == 0 && r3c3button.ImageIndex == 0)
            {
                MessageBox.Show("O WINS!");
                Disable();

            }
        }

        private void r1c3button_Click(object sender, EventArgs e)
        {
            buttonHold = r1c3button;

            buttonHold.ImageList = image;

            if (counter == 0)
            {
                buttonHold.ImageIndex = 0;
                counter++;
            }
            else if (counter == 1)
            {
                buttonHold.ImageIndex = 1;
                counter--;
            }


            //Disable button so it cannot be changed
            buttonHold.Click -= r1c3button_Click;
            newClick = false;

            VerifyBoard();

        }

        private void r2c1button_Click(object sender, EventArgs e)
        {
            buttonHold = r2c1button;

            buttonHold.ImageList = image;

            if (counter == 0)
            {
                buttonHold.ImageIndex = 0;
                counter++;
            }
            else if (counter == 1)
            {
                buttonHold.ImageIndex = 1;
                counter--;
            }


            //Disable button so it cannot be changed
            buttonHold.Click -= r2c1button_Click;
            newClick = false;

            VerifyBoard();

        }

        private void r2c2button_Click(object sender, EventArgs e)
        {
            buttonHold = r2c2button;

            buttonHold.ImageList = image;

            if (counter == 0)
            {
                buttonHold.ImageIndex = 0;
                counter++;
            }
            else if (counter == 1)
            {
                buttonHold.ImageIndex = 1;
                counter--;
            }


            //Disable button so it cannot be changed
            buttonHold.Click -= r2c2button_Click;
            newClick = false;

            VerifyBoard();

        }

        private void r2c3button_Click(object sender, EventArgs e)
        {
            buttonHold = r2c3button;

            buttonHold.ImageList = image;

            if (counter == 0)
            {
                buttonHold.ImageIndex = 0;
                counter++;
            }
            else if (counter == 1)
            {
                buttonHold.ImageIndex = 1;
                counter--;
            }


            //Disable button so it cannot be changed
            buttonHold.Click -= r2c3button_Click;
            newClick = false;

            VerifyBoard();

        }

        private void r3c1button_Click(object sender, EventArgs e)
        {
            buttonHold = r3c1button;

            buttonHold.ImageList = image;

            if (counter == 0)
            {
                buttonHold.ImageIndex = 0;
                counter++;
            }
            else if (counter == 1)
            {
                buttonHold.ImageIndex = 1;
                counter--;
            }


            //Disable button so it cannot be changed
            buttonHold.Click -= r3c1button_Click;
            newClick = false;

            VerifyBoard();

        }

        private void r3c2button_Click(object sender, EventArgs e)
        {
            buttonHold = r3c2button;

            buttonHold.ImageList = image;

            if (counter == 0)
            {
                buttonHold.ImageIndex = 0;
                counter++;
            }
            else if (counter == 1)
            {
                buttonHold.ImageIndex = 1;
                counter--;
            }


            //Disable button so it cannot be changed
            buttonHold.Click -= r3c2button_Click;
            newClick = false;

            VerifyBoard();

        }

        private void r3c3button_Click(object sender, EventArgs e)
        {
            buttonHold = r3c3button;

            buttonHold.ImageList = image;

            if (counter == 0)
            {
                buttonHold.ImageIndex = 0;
                counter++;
            }
            else if (counter == 1)
            {
                buttonHold.ImageIndex = 1;
                counter--;
            }


            //Disable button so it cannot be changed
            buttonHold.Click -= r3c3button_Click;
            newClick = false;

            VerifyBoard();
        }

        void Disable()
        {
            r1c1button.Enabled = false;
            r1c2button.Enabled = false;
            r1c3button.Enabled = false;
            r2c1button.Enabled = false;
            r2c2button.Enabled = false;
            r2c3button.Enabled = false;
            r3c1button.Enabled = false;
            r3c2button.Enabled = false;
            r3c3button.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            r1c1button.ImageIndex = -1;
            r1c2button.ImageIndex = -1;
            r1c3button.Enabled = false;
            r2c1button.Enabled = false;
            r2c2button.Enabled = false;
            r2c3button.Enabled = false;
            r3c1button.Enabled = false;
            r3c2button.Enabled = false;
            r3c3button.Enabled = false;
        }
    }
}