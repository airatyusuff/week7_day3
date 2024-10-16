using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day3
{
    internal class Game
    {
        private int MaxAttempts;
        private int numberToGuess;
        private IGameIO gameIO;
        public int attempts { get; private set; } = 5;
        public bool isCorrect { get; private set; } = false;

        public Game(GameSetup setup) {
            numberToGuess = setup.numberGenerator.GetNumberToGuess();;
            MaxAttempts = setup.MaxAttempts;
            gameIO = setup.gameIO;
        }

        public void Run()
        {
            Show("The number is " + numberToGuess);
            while (isGameValid())
            {
                Play();

                if (isEndOfGame())
                {
                    Show("The number is " + numberToGuess);
                    return;
                }
            }
        }

        public void Play()
        {
            Show(attempts + " attempts remaining");
            Console.Write("Enter your guess between 0 and 50: ");

            string userInput = gameIO.GetInput();
            bool isInputValid = gameIO.IsValidInput(userInput);

            if (isInputValid)
            {
                int guess = gameIO.FormatInput(userInput);
                CheckGuess(guess);
            }
            else Show("Invalid number, try again");
        }

        public void CheckGuess(int num)
        {
            if (num == numberToGuess)
            {
                Show("Correct");
                isCorrect = true;
                return;
            }

            attempts--;
            if (num < numberToGuess) {
                Show("Too low");
            }
            
            else
            {
                Show("Too high");
            }
        }
    
        private bool isGameValid()
        {
            return attempts > 0 && !isCorrect;
        }

        private bool isEndOfGame()
        {
            return attempts == 0 || isCorrect;
        }

        public void Show(string text)
        {
            Console.WriteLine(text);
        }
    }
}
