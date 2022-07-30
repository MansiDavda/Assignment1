using System;
using System.Collections.Generic;
using System.Text;

namespace p4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -1 + 4 * 6;
            
            Console.WriteLine(a);

            a = (35 + 5)%7;
            Console.WriteLine(a);

            a = 14 - 4 * 6 / 11;
            Console.WriteLine(a);

            a = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine(a);
        }
    }
}
