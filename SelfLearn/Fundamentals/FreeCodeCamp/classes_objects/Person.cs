using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes_objects
{
    public class Person
    {
        public string name;
        public int age;
    

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}