using ClassLib1;

namespace EventsConsole;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Subscriber subscriber = new Subscriber();
        Publisher publisher = new Publisher();

        // publisher.myEvent += subscriber.Add;

        // anonymous methods 
        publisher.myEvent += delegate(int a, int b) { Console.WriteLine("a+b : {0}", a + b); };

        //For func
        // publisher.myEvent += (a, b) => a + b;

        publisher.pEvent += (a) => a > 10;
        
        publisher.RaiseEvent(4, 3);

        Console.WriteLine(publisher.RaisePEvent(3));
    }
}