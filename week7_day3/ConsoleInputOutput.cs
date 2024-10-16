using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace week7_day3
{
    internal struct ConsoleInputOutput: IGameIO
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void Show(string text)
        {
            Console.WriteLine(text);
        }
        public bool IsValidInput(string input)
        {
            if (int.TryParse(input, out _))
            {
                return true;
            }
            return false;
        }

        public int FormatInput(string input)
        {
            return Convert.ToInt32(input);
        }
    }
}
