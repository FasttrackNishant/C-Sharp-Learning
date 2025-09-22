using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_encapsulation
{
    public class Person
    {
        private string Name;
        private int Age;

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine($"Name is Required");
            }
            else
            {
                this.Name = Name;
            }
        }
        public string GetName()
        {
            return this.Name;
        }

        public void SetAge(int Age)
        {
            if (Age > 0)
            {
                this.Age = Age;
            }
            else
            {
                Console.WriteLine($"Age should be greate than 0 ");
            }
        }

        public void GetAge()
        {
            if (Age > 0)
            {
                Console.WriteLine($"Age is {this.Age}");
            }

        }

    }
}