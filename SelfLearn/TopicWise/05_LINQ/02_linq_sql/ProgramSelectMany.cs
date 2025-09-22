using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_linq_sql
{
    internal class ProgramSelectMany
    {
        public static void print(dynamic a)
        {
            foreach (var item in a)
            {
                Console.Write($"{item}  \n");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {

            var data = from s in Student1.GetStudents().SelectMany(p =>p.Programming)
                       select s;
            print(data);
            
        }
    }
}


/* write a class group project , project id , project name , Groupofstudents(List)*/