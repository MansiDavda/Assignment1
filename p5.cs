using System;
using System.Collections.Generic;
using System.Text;

namespace p5
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 5,b = 6,c;
           Console.WriteLine("before swapping.....\na={0}\nb={1}", a , b);
           c = b;
           b = a;
           a = c;
           Console.WriteLine("after swapping.....\na={0}\nb={1}", a, b);
        }
    }
}
