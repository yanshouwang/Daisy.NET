using System;
using System.Collections.Generic;
using Tools;

namespace HelloWorld.TerminalCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new Dictionary<string, int>()
            {
                ["ABC"] = 0,
                ["BCD"] = 1,
                ["XYZ"] = 1,
            };
            values.Remove("BCD");
            values.Add("DICK", 10);
            foreach (var value in values)
            {
                Console.WriteLine(value.Key);
            }
        }
    }
}
