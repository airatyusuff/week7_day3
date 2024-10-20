﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_day3
{
    public struct GameSetup
    {
        public int MaxAttempts { get; private set; }
        public INumberGenerator numberGenerator;
        public IGameIO gameIO;

        public GameSetup(INumberGenerator ng, IGameIO io, int num)
        {
            numberGenerator = ng;
            MaxAttempts = num;
            gameIO = io;
        }
    }
}
