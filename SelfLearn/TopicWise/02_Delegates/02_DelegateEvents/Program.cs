
namespace _02_DelegateEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Events
            Console.WriteLine("Events Examples");

            Client client = new Client();

            // Simple Custom Delegate Event
            EventPublisher eventPublisher = new EventPublisher();
            eventPublisher.SimpleEvent += client.DisplayMessage;

            // Triggering the event
            eventPublisher.OnNotify("Hello, this is a simple event notification!");

            Console.WriteLine("===================================");

            // Using Anonymous Method
            eventPublisher.SimpleEvent += delegate (string message)
            {
                Console.WriteLine($"Anonymous Method Received: {message}");
            };

            eventPublisher.OnNotify("Hello, this is an anonymous method notification!");


            Console.WriteLine("===================================");

            // Using Lambda Expression
            eventPublisher.SimpleEvent += (message) =>
            {
                Console.WriteLine($"Lambda Expression Received: {message}");
            };

            eventPublisher.OnNotify("Hello, this is a lambda expression notification!");


            Console.WriteLine("===================================");


            Console.WriteLine("Using Inbuilt EventHandler Delegate");

            ActionEventPublisher actionEventPublisher = new ActionEventPublisher();
            actionEventPublisher.ActionEvent += client.DisplayMessage;
            actionEventPublisher.OnNotify("Hello, this is an Action event notification!");


            Console.WriteLine("===================================");

            Console.WriteLine("Using Inbuilt Func Delegate");

            FunctEventPublisher functEventPublisher = new FunctEventPublisher();
            functEventPublisher.FuncEvent += client.getSum;
            functEventPublisher.FuncEvent += client.getProduct;

            int funcResult = functEventPublisher.OnCalculate(10, 20);
            Console.WriteLine($"Func Event Result (last method's return): {funcResult}");


            Console.WriteLine("===================================");

            PredicateEventPublisher predicateEventPublisher = new PredicateEventPublisher();
            predicateEventPublisher.PredicateEvent += client.IsEven;
            bool isEven = predicateEventPublisher.OnCheck(10);

            Console.WriteLine($"Is 10 Even? {isEven}");


        }
    }
}
