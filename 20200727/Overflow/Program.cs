using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class BadGuy
    {
        public void BadMethod()
        {
            int a = 100;
            BadMethod();
        }
    }
}
