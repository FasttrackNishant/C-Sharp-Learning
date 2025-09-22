using System;
using _03_Access_Modifiers;

namespace _03_Access_2
{
    class Program : Class1
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            // c1.Show1();
            Program p1 = new Program();
            p1.ShowProtected();
        }
    }
}
