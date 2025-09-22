using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_Polymorphism
{
    class Parent
    {
        public void Show()
        { 
            Console.WriteLine($"Parent Class Method");            
        }
    }

    class Child : Parent
    {
        // this will call child
        public new void Show()
        {
            // base.Show();
            Console.WriteLine($"Child Class Method");
        }

    }

    public class MethodHiding
    {
        static void Main2(string [] args)
        {
            Child child = new Child();
            child.Show();

            //second one - casting();
            ((Parent)child).Show();


            //third one 
            //here p will call the parent method
            Parent p = new Child();
            p.Show();
            /* parent class can have the refrence of the child object 
                when we create the object of child class parent is also created 
            */


        }
    }
}