using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day3
{
    public interface INumberGenerator
    {
        public int GetNumberToGuess();
        public int GetMaxGuess();
    }
}
