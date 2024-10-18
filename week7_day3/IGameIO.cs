using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day3
{
    public interface IGameIO
    {
        public string GetInput();
        public void Show(string output);

        // needs more logic/abstraction to achieve intended - (not clear yet)
        public bool IsValidInput(string input);

        public int FormatInput(string input);
    }
}
