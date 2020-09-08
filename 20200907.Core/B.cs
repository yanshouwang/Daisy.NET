using System;
using System.Collections.Generic;
using System.Text;

namespace _20200907.Core
{
    class B
    {
        public int Value { get; }

        public B(int value)
        {
            Value = value;
        }

        public static implicit operator A(B b)
        {
            return new A(b.Value.ToString());
        }
    }
}
