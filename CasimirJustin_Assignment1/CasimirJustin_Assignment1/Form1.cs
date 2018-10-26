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

        private void buttonInput_Click(object sender, EventArgs e)
        {
            UserInput newWindow = new UserInput();

            newWindow.UpdateHave += Update_Have;
            newWindow.UpdateNeed += Update_Need;


            newWindow.Show();
        }

        private void Update_Have(object sender, EventArgs e)
        {
            UserInput copyData = (UserInput)sender;

            listBoxHave.Items.Add(copyData.textBoxItem.Text);


        }

        private void Update_Need(object sender, EventArgs e)
        {
            UserInput copyData = (UserInput)sender;

            listBoxNeed.Items.Add(copyData.textBoxItem.Text);

        }

    }


}
