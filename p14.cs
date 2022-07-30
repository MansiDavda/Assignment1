using System;
using System.Collections.Generic;
using System.Text;

namespace p14

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of celsius:");
            int a = Convert.ToInt32(Console.ReadLine());
            double k = a + 273.15;
            double f = 1.8 * (k - 273) + 32;
            Console.WriteLine("Kelvin:{0}",k);
            Console.WriteLine("Fahrenheit:{0}",f);

        }
    }
}
