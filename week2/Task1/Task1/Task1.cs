using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\NUR\Desktop\1.txt");
            String s = sr.ReadToEnd();
           // char[] arr = s.ToCharArray();
            bool pl = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                    pl = false;
            }
            if (pl == false)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }

        }
    }
}
