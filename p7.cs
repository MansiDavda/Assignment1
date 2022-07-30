using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two values");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            c = a + b;
            Console.WriteLine("{0}+{1}={2}" , a, b, c);
            c = a - b;
            Console.WriteLine("{0}-{1}={2}" , a, b, c);
            c = a * b;
            Console.WriteLine("{0}*{1}={2}" , a, b, c);
            c = a / b;
            Console.WriteLine("{0}/{1}={2}" , a, b, c);
            c = a % b;
            Console.WriteLine("{0}%{1}={2}" , a, b, c);
        }
    }
}
