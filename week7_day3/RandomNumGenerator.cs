using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day3
{
    public class RandomNumGenerator : INumberGenerator
    {
        public int GetNumberToGuess()
        {
            Random rnd = new Random();
            return rnd.Next(0, GetMaxGuess());
        }

        public int GetMaxGuess()
        {
            return 50;
        }
    }
}
