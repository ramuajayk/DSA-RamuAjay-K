using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Fibonacci
    {
        public int Fib(int input)
        {
            if (input == 1)
                return input;
            else
            {
                return input * Fib(input -1);
            }
        }

    }
}
