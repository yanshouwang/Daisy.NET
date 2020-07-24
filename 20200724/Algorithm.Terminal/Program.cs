using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong r = Math.Hanoi1(10);
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
