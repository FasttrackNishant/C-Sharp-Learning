using System;

namespace _07_Polymorphism
{
    class Program
    {

        public void Add()
        {
            int a = 34;
            int b = 32;
            int c = a + b;
            Console.WriteLine($"{c}");

        }
        public void Add(int a, int b)
        {
            Console.WriteLine($"{a + b}");
        }

        public void Add(string a, string b)
        {
            Console.WriteLine($"{a + b}");

        }

        //this is not allowed
        //(signature bracket ke andar)
        // public int Add(int a, int b)
        // {
        //     return a + b;
        // }


        static void Main1(string[] args)
        {

            Program program = new Program();
            program.Add(3, 4);
            program.Add("jane", "smith");
            program.Add();


            //operator overloading

            NewClass obj1 = new NewClass();
            NewClass obj2 = new NewClass();
            obj1.str = "Rohan";
            obj1.num = 23;
            obj2.str = "Sea";
            obj2.num = 33;


            NewClass obj3 = new NewClass();
             //this is not allowed without overloading
            obj3 = obj1 + obj2;
            Console.WriteLine($"{obj3.str} " );
            Console.WriteLine($"{obj3.num} " );
             

        }
    }
}
