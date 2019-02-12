using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());               //size of the array
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)                       //condition 
                    Console.Write("[*]");
                Console.WriteLine();
            }
        }
    }
}