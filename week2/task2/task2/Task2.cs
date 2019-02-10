using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {   
        public static bool prime(int a)
        {   if (a == 1)
                return false;
            for(int i = 2; i < Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                { 
                  return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
          // FileStream f = new FileStream(@"C:\Users\NUR\source\repos\week2\task2\task2\bin\Debug\input.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader("input.txt");
            string s = sr.ReadToEnd();
            StreamWriter sw = new StreamWriter("output.txt");
            sr.Close();
            string[] arr = s.Split();
            for(int i = 0; i < arr.Length; i++)
            {
                if (prime(int.Parse(arr[i])) == true)
                    sw.Write(arr[i] + " ");
                    
                }
            sw.Close();
        }
    }
}
