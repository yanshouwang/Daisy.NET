using HelloWorld.Terminal.Vehicle;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

/// <summary>
/// 
/// </summary>
namespace HelloWorld.Terminal
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static ConcurrentBag<int> _values = new ConcurrentBag<int>();

        static void Main()
        {
            Add(0, "A");
            Console.ReadLine();
        }

        private static void Add(int a = 2, string b = "A", int c = 2)
        {

        }
    }

    class A
    {
        public int Value { get; set; }
    }
}
