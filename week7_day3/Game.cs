using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day3
{
    internal class Game
    {
        private IGameIO gameIO;
        private int MaxAttempts;
        private int MaxGuess;
        private int numberToGuess;
        private int attempts;

        private bool isCorrect = false;

        public Game(GameSetup setup)
        {
            attempts = setup.MaxAttempts;
            gameIO = setup.gameIO;
            MaxAttempts = setup.MaxAttempts;
            MaxGuess = setup.numberGenerator.GetMaxGuess();
            numberToGuess = setup.numberGenerator.GetNumberToGuess();
        }

        public void Run()
        {
            gameIO.Show("The number is " + numberToGuess); //cheat

            while (isGameValid())
            {
                Play();

                if (noAttemptsLeft())
                {
                    gameIO.Show("No Attempts left");
                    gameIO.Show("The correct number is " + numberToGuess);
                    gameIO.Show("The End");
                    return;
                }

                if (isCorrect)
                {
                    gameIO.Show("You finished with " + attempts + " attempts left!");
                    gameIO.Show("The End");
                    return;
                }
            }
        }

        public void Play()
        {
            gameIO.Show(attempts + " attempts remaining");
            gameIO.Show("Enter your guess between 0 and " + MaxGuess + ":");

            string userInput = gameIO.GetInput();
            bool isInputValid = gameIO.IsValidInput(userInput);

            if (isInputValid)
            {
                int guess = gameIO.FormatInput(userInput);
                CheckGuess(guess);
                attempts--;
            }
            else gameIO.Show("Invalid number, try again");
        }

        public void CheckGuess(int num)
        {
            if (num == numberToGuess)
            {
                gameIO.Show("Correct");
                isCorrect = true;
                return;
            }

            if (num < numberToGuess) {
                gameIO.Show("Too low");
            }
            
            else
            {
                gameIO.Show("Too high");
            }
        }
    
        private bool isGameValid()
        {
            return attempts > 0 && !isCorrect;
        }

        private bool noAttemptsLeft()
        {
            return attempts == 0;
        }
    }
}
