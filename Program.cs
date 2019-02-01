using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        string Name {get;set;}
        int id { get; set; }
        int Year { get; set; }
        public Student(string name,int id)
        {
            Name = name;id = 18;
            Year = 2019;
        }
        public void NewYear()
        {
            Console.WriteLine("Student:{0};id:{1};Year:{2}", Name, id,Year++);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Student s1 = new
                Student("Nurgasyr Tleuov", 1);
            s1.NewYear();
        }
    }
}
