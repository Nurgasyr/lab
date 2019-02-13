using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
         public static void Main(string[] args)
        {
            DirectoryInfo fs = new DirectoryInfo(@"C:\Users\NUR\source\repos\week2\Task3");                                           //directory
            PrintInfo(fs, 0);                                                                                                  //get all files and directories
        }

        private static void PrintInfo(FileSystemInfo fs, int k)
        {
            string s = new string(' ', k);                                                                                      //k space 
            Console.WriteLine(s + fs.Name);

            if (fs.GetType() == typeof(DirectoryInfo))
            {
                var y = fs as DirectoryInfo;
                foreach (var x in y.EnumerateFileSystemInfos())
                {
                    PrintInfo(x , k + 3);                                                                                  //recursion
                }
            }
        }
    }
}
