using System;
using System.Collections.Generic;
using System.Text;

namespace p10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter three values");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            int a = (x + y) * z;
            int b = (x * y) + (y * z);
            Console.WriteLine("X + Y * Z = {0}",a);
            Console.WriteLine("(X * Y) + (Y * Z) = {0}", b);

        }
    }
}
