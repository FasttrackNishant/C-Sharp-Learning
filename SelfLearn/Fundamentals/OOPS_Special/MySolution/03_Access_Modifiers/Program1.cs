using System;

namespace _03_Access_Modifiers
{

    public class Class1
    //class1 is public it means can be accessed anywhere

    // internal class Class1
    //can be used within only in the same namespace
    {
        // private void Show1()
        //not accessible due to protection level 

        //can not be accessed other than this class
        public void Show1()
        {
            Console.WriteLine($"This is public method ");
        }

        protected void ShowProtected()
        {
            Console.WriteLine($"This is protected method");

        }

        internal void ShowInternal()
        {
            Console.WriteLine($"This is internal method");

        }

        public void Show2()
        {
            Class1 class1 = new Class1();
            class1.Show1();
        }
    }

    class Program : Class1
    {
        static void Main(string[] args)
        {
            // Class1 c1 = new Class1();
            // c1.Show1();

            Program p1 = new Program();
            p1.Show1();
            p1.ShowProtected();
            p1.ShowInternal();

            //internal can be used here
        }
    }


}
