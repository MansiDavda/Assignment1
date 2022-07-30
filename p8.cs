using System;
using System.Collections.Generic;
using System.Text;

namespace p8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter value");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int b= a * i;
                Console.WriteLine("{0}*{1}={2}",a,i,b);
            }
        }
    }
}
