using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasimirJustin_Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void HandleClientWindowSize()
        {
            //Modify ONLY these float values
            float HeightValueToChange = 1.4f;
            float WidthValueToChange = 6.0f;

            //DO NOT MODIFY THIS CODE
            int height = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Height / HeightValueToChange);
            int width = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Width / WidthValueToChange);
            if (height < Size.Height)
                height = Size.Height;
            if (width < Size.Width)
                width = Size.Width;
            this.Size = new Size(width, height);
        }

        //Everything is subscribed here this is where the Forms connect.
        private void buttonInput_Click(object sender, EventArgs e)
        {
            UserInput newWindow = new UserInput();

            newWindow.UpdateHave += Update_Have;
            newWindow.UpdateNeed += Update_Need;


            newWindow.Show();
        }

        // Updates the have list

        private void Update_Have(object sender, EventArgs e)
        {
            UserInput copyData = (UserInput)sender;

            listBoxHave.Items.Add(copyData.textBoxItem.Text);


        }
        
        // Updates the need list
        private void Update_Need(object sender, EventArgs e)
        {
            UserInput copyData = (UserInput)sender;

            listBoxNeed.Items.Add(copyData.textBoxItem.Text);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonHaveToNeed_Click(object sender, EventArgs e)
        {
            if (listBoxHave.SelectedItem != null)
            {
                listBoxNeed.Items.Add(listBoxHave.SelectedItem);
                listBoxHave.Items.Remove(listBoxHave.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item from the NEED list.");
            }
        }

        private void buttonNeedToHave_Click(object sender, EventArgs e)
        {
            if (listBoxNeed.SelectedItem != null)
            {
                listBoxHave.Items.Add(listBoxNeed.SelectedItem);
                listBoxNeed.Items.Remove(listBoxNeed.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item from the HAVE list.");
            }
        }
    }


}
