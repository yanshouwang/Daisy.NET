using System;
using Tools;

namespace HelloWorld.TerminalCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator calculator = new Calculator();
            double sum = calculator.Sub(5.0, 1.2);
            Console.WriteLine(sum);
        }
    }
}
