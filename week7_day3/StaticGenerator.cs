using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day3
{
    public class StaticGenerator : INumberGenerator
    {
        public int GetMaxGuess()
        {
            return 23;
        }

        public int GetNumberToGuess()
        {
            return 23;
        }
    }
}
