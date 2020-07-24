using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Terminal
{
    static class Math
    {
        public static int LoopSum()
        {
            int result = 0;
            for (int i = 0; i <= 100; i++)
            {
                result += i;
            }
            return result;
        }

        public static int RecurSum(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                int r = RecurSum(n - 1) + n;
                return r;
            }
        }

        public static ulong Hanoi1(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Hanoi1(n - 1) + 1 + Hanoi1(n - 1);
            }
        }

        public static ulong Hanoi2(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return 2 * Hanoi2(n - 1) + 1;
            }
        }
    }
}
