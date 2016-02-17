/// Description: The program generates a random number between 1-100 which
///              the use must guess
/// Author:      Mr. T

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        //creates a random number between 1 and 100 and stores it in a global 
        //variable that can be used throughout the program 
        public static Random randNum = new Random();
        public static int rand = randNum.Next(1, 101);

        public static int numberOfGuesses;
        public static List<int> guesses = new List<int>();

        

        public Form1()
        {
            InitializeComponent();

            label1.Text = Convert.ToString(rand);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            // get the users guess and place into a variable
            int guess = Convert.ToInt16(inputBox.Text);
            numberOfGuesses += 1;

            // check guess against the random value and output appropriate message
            if (guess < rand)
            {
                outputLabel.Text = "Too Low!";
                guesses.Add(guess);
            }
            else if (guess > rand)
            {
                outputLabel.Text = "Too High!";
                guesses.Add(guess);
            }
            else
            {
                outputLabel.Text = "You Got it!";
                Refresh();
                Thread.Sleep(2000);
                guesses.Add(guess);

                Results rs = new Results();

                rs.Show();

            }

            // clear out the input box 
            inputBox.Text = "";
        }
    }
}
