using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();

            numberOfGuessesLabel.Text += Convert.ToString(Form1.numberOfGuesses);
            
            for (int x = 0; x < Form1.guesses.Count(); x ++)
            {
                //guessesLabel.Text = "";
                guessesLabel.Text += Form1.guesses[x] + ", ";
            }

            Form1.guesses.Sort();

            for (int x = 0; x < Form1.guesses.Count(); x++)
            {
                //sortedOrderLabel.Text = "";
                sortedOrderLabel.Text += Form1.guesses[x] + ", ";
            }

        }
    }
}
