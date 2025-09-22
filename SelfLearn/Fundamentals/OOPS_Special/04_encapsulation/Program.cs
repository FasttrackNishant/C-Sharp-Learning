using System;

namespace _04_encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            // this is not allowed
            // p.Name = "Rohan";
            // p.Age = -34;
            // Console.WriteLine($"Values are {p.Name} {p.Age}");

            p.SetName("Rohan");
            // p.SetAge(-34);
            p.SetAge(34);
            string name = p.GetName();


            //accessing
            Console.WriteLine($"{name}");
            p.GetAge();

 

        }
    }
}
