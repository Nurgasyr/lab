using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,a;
            n = Convert.ToInt32(Console.ReadLine());                         //input sum of numbers
            List<int> array = new List<int>();                               //creat an array 
            for(int i = 0; i < n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());                     //input numbers
                array.Add(a);                                                //add in the array
            }
            for(int i = 0; i < n; i++)                                       
            {
                for (int j = 0; j < 2; j++)                                 // to double numbers 
                {
                    Console.Write(array[i]+" ");                             //output the numbers
                }
            }
        }
    }
}
