

namespace _02_DelegateEvents
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

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine($"Message Received: {message}");
        }
    }

}
