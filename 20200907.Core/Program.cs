using System;

namespace _20200907.Core
{
    class Program
    {
        public string Str { get => "A"; }

        static void Main(string[] args)
        {
            var str1 = new ABC();
            var str2 = new ABC();
            var e1 = str1 == str2;
            var e2 = string.Equals(str1, str2);
            var e3 = string.ReferenceEquals(str1, str2);
            var code1 = str1.GetHashCode();
            var code2 = str2.GetHashCode();
            Console.WriteLine($"{e1},{e2},{e3}\r\n{code1}\r\n{code2}");
            object obj1 = str1;
            object obj2 = str2;
            var oe1 = obj1 == obj2;
            var oe2 = string.Equals(obj1, obj2);
            var oe3 = string.ReferenceEquals(obj1, obj2);
            var code3 = obj1.GetHashCode();
            var code4 = obj2.GetHashCode();
            Console.WriteLine($"{oe1},{oe2},{oe3}\r\n{code3}\r\n{code4}");
        }
    }

    class ABC
    {

    }
}
