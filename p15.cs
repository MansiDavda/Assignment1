using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(remove_char("Atmiya University", 2));
            Console.WriteLine(remove_char("Atmiya University", 7));     
        }
       public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
        }
}
