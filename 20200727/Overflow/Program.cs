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
            BadGuy badGuy = new BadGuy();
            badGuy.BadMethod();
        }
    }

    class BadGuy
    {
        public void BadMethod()
        {
            BadMethod();
        }
    }
}
