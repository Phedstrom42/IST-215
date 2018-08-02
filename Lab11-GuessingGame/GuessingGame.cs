using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11_GuessingGame
{
    public partial class GuessingGame : Form
    {

        private int randomNum;
        private int usersGuess;
        private int prevUsersGuess;
        private int numOfGuesses;

        Random random = new Random();

        public GuessingGame()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //Reset all outputs and reset colors
            txtGuess.Text = string.Empty;
            lblAnswer.Text = string.Empty;
            rTxtOutput.Text = string.Empty;
            lblNumOfGuessesValue.Text = string.Empty;
            lblGameStatus.Text = "New Game in Progess...";

            changeColor(Color.FromKnownColor(KnownColor.Control));

            txtGuess.Enabled = true;
            btnNewGame.Enabled = false;

            randomNum = random.Next(1, 1000);
            lblAnswer.Text = $"{randomNum}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                //Suppresses key press sound
                e.SuppressKeyPress = true;

                while (checkForValidInput(txtGuess.Text))
                {
                    usersGuess = Convert.ToInt32(txtGuess.Text);
                    lblNumOfGuessesValue.Text = $"{++numOfGuesses}";

                    if (usersGuess == randomNum)
                    {
                        numberGuessed();
                        break;
                    }
                    else
                    {
                        compareNumbers();
                        prevUsersGuess = usersGuess;
                        break;
                    }
                }//End of While
            }//End of if
        }//End of txtGuess_KeyDown(object, KeyEventArgs)

        private void compareNumbers()
        {
            rTxtOutput.Text += (usersGuess < randomNum) ? $"{usersGuess} - Too low, guess a bit higher\n" 
                                                        : $"{usersGuess} - Too high, guess a bit lower\n";

            if (numOfGuesses > 1)
            {
                if (Math.Abs(usersGuess - randomNum) < Math.Abs(prevUsersGuess - randomNum))
                {
                    changeColor(Color.LightBlue);
                }
                else
                {
                    changeColor(Color.Orange);
                } 
            }

        }

        private void numberGuessed()
        {
            if (usersGuess == randomNum && numOfGuesses <= 10)
            {
                lblGameStatus.Text = "Congratulations. Yout have guessed the number.";
                changeColor(Color.LightGreen);

                txtGuess.Enabled = false;
                btnNewGame.Enabled = true;

            }
            else
            {
                lblGameStatus.Text = "You have guessed the number. But you could do better.";
                changeColor(Color.Firebrick);

                txtGuess.Enabled = false;
                btnNewGame.Enabled = true;
            }
        }

        private void changeColor(Color newColor)
        {
            lblDirections.BackColor = newColor;
            btnNewGame.BackColor = newColor;
            lblEnterGuess.BackColor = newColor;
            lblAnswer.BackColor = newColor;
            lblNumOfGuesses.BackColor = newColor;
            this.BackColor = newColor;
        }

        private bool checkForValidInput(string input)
        {
            try
            {
                if (Convert.ToInt32(input) < 1 || Convert.ToInt32(input) > 1000)
                {
                    rTxtOutput.Text += "Invalid input. Enter a number between 1-1000.\n";
                    return false;
                }
            }
            catch (FormatException)
            {
                rTxtOutput.Text += "Invalid input. Enter a number between 1-1000.\n";
                return false;
            }
            return true;
        } //End of checkForValidInput(string)

    }
}
