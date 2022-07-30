using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _27
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo f = new FileInfo("/home/students/abc.txt");
            Console.WriteLine("\nSize of a file: " + f.Length.ToString());
        }
    }
}
