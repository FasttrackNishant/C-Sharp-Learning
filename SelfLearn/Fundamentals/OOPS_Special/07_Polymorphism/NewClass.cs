using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_Polymorphism
{
    public class NewClass
    {
        public string str;
        public int num;


        //make funtion

        public static NewClass operator +(NewClass obj1, NewClass obj2)
        {
            NewClass obj3 = new NewClass();
            obj3.str = obj1.str +" "+ obj2.str;
            obj3.num = obj1.num + obj2.num;
            return obj3;
        }

    }
}