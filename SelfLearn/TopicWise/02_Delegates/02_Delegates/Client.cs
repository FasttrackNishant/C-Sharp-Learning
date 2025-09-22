using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Delegates
{
    public class Client
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Addition: {a + b}");
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine($"Subtraction: {a - b}");
        }

        public int getSum(int a, int b)
        {
            return a + b;
        }

        public int getProduct(int a, int b)
        {
            return a * b;
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine($"Message Received: {message}");
        }

        public bool isEven(int number)
        {
            return number % 2 == 0;
        }
    }

}
