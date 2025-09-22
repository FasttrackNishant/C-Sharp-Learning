using System.Security.Cryptography;

namespace _02_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Simple Delegate
            // Single Cast

            Console.WriteLine("Single Cast Examples");

            Client client = new Client();
            SimpleCalculation calculation = new SimpleCalculation(client.Add);
            calculation(10, 30);


            // Single Cast With Return
            CalculationWithReturn calculationWithReturn = new CalculationWithReturn(client.getSum);
            int result = calculationWithReturn(10, 20);
            Console.WriteLine($"Result: {result}");

            Console.WriteLine("===================================");

            Console.WriteLine("Multi Cast Examples");

            // Multi Cast
            SimpleCalculation multiCast = new SimpleCalculation(client.Add);
            multiCast += new SimpleCalculation(client.Subtract);
            multiCast(20, 10);

            Console.WriteLine("===================================");

            Console.WriteLine("Multi Cast With Return Examples");

            // Multi Cast With Return => Only last method's return value is considered
            CalculationWithReturn multiCastWithReturn = new CalculationWithReturn(client.getSum);
            multiCastWithReturn += new CalculationWithReturn(client.getProduct);
            int multiCastResult = multiCastWithReturn(10, 20);
            Console.WriteLine($"Multi Cast Result: {multiCastResult}");


            Console.WriteLine("===================================");



            // Using Inbuilt Delegates
            Console.WriteLine("Inbuilt Delegates Examples");

            // Action Delegate

            Action<string> action = new Action<string>(client.DisplayMessage);

            action("Hello from Action Delegate!");


            // Func Delegate
            Func<int, int, int> func = new Func<int, int, int>(client.getSum);
            int funcResult = func(20, 30);
            Console.WriteLine($"Func Result: {funcResult}");


            // Predicate Delegate

            Predicate<int> predicate = new Predicate<int>(client.isEven);
            bool isEven = predicate(10);
            Console.WriteLine($"Is 10 Even? {isEven}");

        }
    }
}
