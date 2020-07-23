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
            double result= calculator.Sub(5, 4);
            Console.WriteLine(result);
        }
    }
}
