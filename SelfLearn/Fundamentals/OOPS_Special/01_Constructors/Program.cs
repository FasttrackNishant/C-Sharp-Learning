using System;

namespace _01_constructors
{
    class Program
    {

        public Program()
        {
            Console.WriteLine($"Default constructor is called");

        }

        public Program(string str)
        {
            Console.WriteLine("This is" + str);
        }

        public Program(int number)
        {
            Console.WriteLine($"Number {number}");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            Program p1 = new Program("hello");
            Program p2 = new Program(34);

            Person person = new Person("Rohan", "34");
            Console.WriteLine($"{person.getName()}");


        }


    }

    class Person
    {
        public string Name;
        public string Age;

        public Person(string Name, string Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string getName()
        {
            return this.Name;
        }

        public string getAge()
        {
            return this.Age;
        }

        //destrctors
        ~Person()
        {
            Console.WriteLine($"Destor called ");
        }

    }

}
