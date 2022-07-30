using System;
using System.Collections.Generic;
using System.Text;

namespace p6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter three values");
            int a = Convert.ToInt32 (Console.ReadLine());
            int b = Convert.ToInt32 (Console.ReadLine());
            int c = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Answer="+a*b*c);

        }
    }
}
 