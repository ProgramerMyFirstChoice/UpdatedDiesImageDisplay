using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiesImageDisplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplayDice_Click(object sender, EventArgs e)
        {
            // Create A Random Number object

            Random randomNumber = new Random();

            // Generate random using Next() Method in the random object
            // in the range of 1 to 6

            int randomNumberOfDice = randomNumber.Next(1, 7);

            // Assign the number generated to text box

            txtDiceValue.Text = randomNumberOfDice.ToString();

            if (randomNumberOfDice == 1)
            {
                pictureDice.Image = Properties.Resources.die1;
            }
            else if (randomNumberOfDice == 2)
            {
                pictureDice.Image = Properties.Resources.die2;
            }
            else if (randomNumberOfDice == 3)
            {
                pictureDice.Image = Properties.Resources.die3;
            }
            else if (randomNumberOfDice == 4)
            {
                pictureDice.Image = Properties.Resources.die4;
            }
            else if (randomNumberOfDice == 5)
            {
                pictureDice.Image = Properties.Resources.die5;
            }
            else
            {
                pictureDice.Image = Properties.Resources.die6;
            }   
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
