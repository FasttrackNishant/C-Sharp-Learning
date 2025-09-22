using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_inheritance
{
    public class Employee
    {
        public int empId;
        public string empName;
        public int empAge;

        public void Show()
        {
            Console.WriteLine($"This is show message ");

        }

    }
}