using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day3
{
    internal class RandomNumGenerator : INumberGenerator
    {
        public int GetNumberToGuess()
        {
            Random rnd = new Random();
            return rnd.Next(0, 50);
        }
    }
}
