using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class Student
    {
       public string name ;
        public string id ; 
        public int year;
        public Student(string id, string name, int year)
        {
            this.name = name;
            this.id = id;
            this.year = year;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Student stud = new Student("", "", 2);
            stud.id = Console.ReadLine();
            stud.name = Console.ReadLine();
            stud.year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stud.id + " " + stud.name + " " + stud.year);
        }
    }
}
