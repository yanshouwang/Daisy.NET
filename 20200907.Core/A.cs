using System;
using System.Collections.Generic;
using System.Text;

namespace _20200907.Core
{
    class A
    {
        public string Str { get; }

        public A(string str)
        {
            Str = str;
        }

        public static explicit operator B(A a)
        {
            var value = int.Parse(a.Str);
            return new B(value);
        }
    }
}
