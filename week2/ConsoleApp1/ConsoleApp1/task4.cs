using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    class task4
    {
        static void Main(string[] args)
        {
            string file = "input.txt";
            string path = @"C:\Users\NUR\source\repos\ConsoleApp1\ConsoleApp1\path\" + file;
            string path1 = @"C:\Users\NUR\source\repos\ConsoleApp1\ConsoleApp1\path1\" + file;
            //creat file
            FileStream fs = new FileStream(@"C:\Users\NUR\source\repos\ConsoleApp1\ConsoleApp1\path\input.txt", FileMode.Create, FileAccess.Write);
            //copy file
            fs.Close();
            File.Copy(path, path1);
            //
            File.Delete(@"C:\Users\NUR\source\repos\ConsoleApp1\ConsoleApp1\path\input.txt");
        }
    }
}
