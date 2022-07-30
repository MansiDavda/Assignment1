using System;
using System.Collections.Generic;
using System.Text;

namespace p12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}",a);
            Console.WriteLine("{0}{0}{0}{0}", a);
            Console.WriteLine("{0} {0} {0} {0}", a);
            Console.WriteLine("{0}{0}{0}{0}", a);

        }
    }
}
