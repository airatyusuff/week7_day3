using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day3
{
    internal struct DummyInputOutput: IGameIO
    {
        public int FormatInput(string input)
        {
            return 23;
        }

        public string GetInput()
        {
            return "23";
        }

        public void Show(string s)
        {
            
        }

        public bool IsValidInput(string input)
        {
            return true;
        }
    }
}
