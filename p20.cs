using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("\nInput an integer:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input another integer:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x == 20 || y == 20 || (x + y == 20));
        }
    }
}
