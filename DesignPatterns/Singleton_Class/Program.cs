using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MyClass mc = new MyClass();
            MyClass obj = MyClass.GetInstance();
            MyClass obj2 = MyClass.GetInstance();


        }

    }
}