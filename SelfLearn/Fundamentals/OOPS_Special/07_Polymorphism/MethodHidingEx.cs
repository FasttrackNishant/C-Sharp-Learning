using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_Polymorphism
{

    class Employee
    {
        public string firstName = "Jane";
        public string lastName = "Smith";
        public void PrintFullName()
        {
            Console.WriteLine($"{firstName} {lastName} Main");
        }

    }

    class PartTimeEmployee :Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine($"{firstName} {lastName} PartTime");
        }

    }

    class FullTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            base.PrintFullName();   
            Console.WriteLine($"{firstName} {lastName} FullTime");
        }

    }
    public class MethodHidingEx
    {
        public static void Main(string[] args)
        {
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.firstName = "John";
            partTimeEmployee.lastName = "Steve";
            partTimeEmployee.PrintFullName();

        }
    }
}