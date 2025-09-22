using System;

namespace _05_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Rajani");
            s.Id = 23;
            s.Name = "Jane";
            s.FatherName = "Smith";
            // due to private set it not allowed
            // s.StudentName = "Rohn ";

            // s.SubjectMarks = 34;
            Console.WriteLine($"{s.Id} {s.Name} {s.FatherName}");
            
        }
    }
}
