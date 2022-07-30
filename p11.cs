using System;
using System.Collections.Generic;
using System.Text;

namespace p11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                a = -a;
                Console.WriteLine("You look older than {0}", a);
            }
            else
            {
                Console.WriteLine("You look older than {0}", a);
            }

        }
    }
}
