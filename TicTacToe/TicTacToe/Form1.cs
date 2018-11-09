using System;
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

        /* THINGS TO CONSIDER:
            - You must change the project name to conform to the required
              naming convention.
            - You must comment the code throughout.  Failure to do so could result
              in a lower grade.
            - All button names and other provided variables and controls must
              remain the same.  Changing these could result in a 0 on the project.
            - Selecting Blue or Red on the View menu should change the imageList
              attached to all buttons so that any current play will change the color
              of all button images.
            - Saved games should save to XML.  A game should load only from XML and
              should not crash the application if a user tries to load an incorrect 
              file.
        */


        //tracks if it is x or o
        int counter = 1;
        bool newClick = true;

        ImageList image = new ImageList();

        public frmTicTacToe()
        {
            InitializeComponent();

            if(blueToolStripMenuItem.Checked == true)
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
            r1c1button.ImageList = image;

            if (counter == 0)
            {
                r1c1button.ImageIndex = 0;
                counter++;
            }
            else if (counter == 1)
            {
                r1c1button.ImageIndex = 1;
                counter--;
            }
          
            
            //Disable button so it cannot be changed
             r1c1button.Enabled = false;
            newClick = false;

            //check();
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

        }
    }
}
