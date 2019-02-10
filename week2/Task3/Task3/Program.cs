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
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\NUR\source\repos\Task3");                                           //directory
            PrintInfo(dir, 0);                                                                                                  //get all files and directories
        }

        static void PrintInfo(FileSystemInfo fs, int k)
        {
            string s = new string(' ', k);                                                                                      //k space 
            Console.WriteLine(s + fs.Name);

            if (fs.GetType() == typeof(DirectoryInfo))
            {
                FileSystemInfo[] fss = ((DirectoryInfo)fs).GetFileSystemInfos();
                for (int i = 0; i < fss.Length; ++i)
                {
                    PrintInfo(fss[i], k + 3);                                                                                  //recursion
                }
            }
        }
    }
}
