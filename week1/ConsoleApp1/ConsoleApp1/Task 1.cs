using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 
{
    class Program
    {   
        static void Main(string[] args)
        {
            int n;                                 
            int b;
            int cnt=0;
            List<int> array = new List<int>();                    //creat an array 
            n=Convert.ToInt32(Console.ReadLine());                //input sum of numbers
            for(int i = 0; i < n; i++)                            
            {                   
             b=Convert.ToInt32(Console.ReadLine());                //input numbers
                if (Func(b))                                       //test to prime
                {
                    cnt++;                                         //sum of primes
                    array.Add(b);                                  //add in array of primes
                }
             }
            Console.WriteLine(cnt);                                 
            for (int i = 0; i < cnt; i++)
            {
                Console.Write(array[i]+ " ");
            }
        }
        static bool Func(int b)
        {
            if (b == 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(b); i++)                     //Math.Sqrt(b) - square root of b  
            {
                if (b % i == 0)
                    return false;
            }
               return true;
        }
    }
}
