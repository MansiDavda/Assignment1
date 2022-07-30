using System;
using System.Collections.Generic;
using System.Text;

namespace p13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if(j==1||j==3||i==1||i==a)
                    
                        Console.Write(a);
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
}
