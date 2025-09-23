namespace _03_SystemThreading;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {

        //multiThread();

        //ThreadJoin();


        // Race Condition

        //RaceCondition.StartThread();
        //RaceCondition.printSharedCounter();

        RaceConditionLock.StartThread();
        RaceConditionLock.printSharedCounter();


    }


    static void multiThread()
    {
        SingleThreadImpl singleThread = new SingleThreadImpl();
        //singleThread.MethodA();
        //singleThread.MethodB();

        // MultiThreading

        Thread threadA = new Thread(singleThread.MethodA);

        Thread threadB = new Thread(singleThread.MethodB);

        threadA.Start();
        threadB.Start();
    }

    static void ThreadJoin()
    {
        // MultiThreading

        SingleThreadImpl singleThread = new SingleThreadImpl();

        Thread threadA = new Thread(singleThread.MethodA);

        Thread threadB = new Thread(singleThread.MethodB);

        threadA.Start();
        threadB.Start();

        // if we did not use join then it will not stop it will execute till the end

        threadA.Join();

        WriteLine("Thread A Completed");

        threadB.Join();

        WriteLine("Thread B Completed");


        WriteLine("Main Thread Completed");

    }
}