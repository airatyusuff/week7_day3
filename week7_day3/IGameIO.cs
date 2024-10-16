using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day3
{
    internal interface IGameIO
    {
        public string GetInput();
        public void Show(string output);

        public bool IsValidInput(string input);

        public int FormatInput(string input);
    }
}
