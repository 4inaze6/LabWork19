﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class OperationSubstract : IStrategy
    {
        public int DoOperation(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}