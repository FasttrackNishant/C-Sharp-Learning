using System;

namespace _06_Static_Property
{


    class Program
    {
        static void Main(string[] args)
        {
            University._UniversityName = "Pune";
            Console.WriteLine($"Data is : {University._UniversityName}");
            
            
        }
    }
}
