using System;

namespace structures
{

    struct Person
    {
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            System.Console.WriteLine("Structure Constructor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person;
            person.name = "hello"; 
            person.age = 34;

            Console.WriteLine($"{person.name} {person.age}");

            string newName = returnPerson(out int newAge); 
            Console.WriteLine($"{newAge} {newName}");


            Person personnew = returnStructPerson();
            Console.WriteLine($"{personnew.name} {personnew.age}");


            

        }

        static string returnPerson(out int age)
        {
            Console.WriteLine("Write Name ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());
            return name;

        }

        static Person returnStructPerson ()
        {
            Person person ;
            person.name ="new roy";
            person.age = 34;

            return person;

        }


    }
}
