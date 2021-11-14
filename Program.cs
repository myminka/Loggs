using Loggs;
using System;

namespace Loggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 0;

            Calculator calculator = new Calculator();
            calculator.Calculate(a, b);
            a = 3;
            b = 1;

            calculator.Calculate(a, b);
        }
    }
}
