using System;

namespace _02_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployees Rohan = new PermanentEmployees();
            Rohan.empId =34;

            VisitingEmployees John = new VisitingEmployees();
            John.empId = 22;

            Console.WriteLine($"{Rohan.empId} {John.empId}");
            John.Show();


            // single inheritance

            DerivedClass dc1 = new DerivedClass();
            dc1.Show1();

        }
    }

    class BaseClass
    {
        public void Show1()
        {
            Console.WriteLine($"This is base class called");
            
        }

    }

    class DerivedClass :BaseClass
    {
        public void Show2()
        {
            Console.WriteLine($"This is DerivedClass called ");
            
        }
    }
}
