using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SystemThreading
{
    internal class RaceConditionLock
    {
        static int SharedCounter = 0;

        private static readonly object _lock = new object();

        public static void printSharedCounter()
        {
            Console.WriteLine($"Final Counter Value: {SharedCounter}");
        }

        public static void IncrementCounter()
        {
            try
            {

                for (int i = 0; i < 1000000; i++)
                {
                    //Monitor.Enter(_lock);

                    //or 

                    lock (_lock)
                    {
                        SharedCounter++;
                    }
                }
            }
            finally
            {
                Monitor.Exit(_lock);
            }
        }

        // created threads list
        public static List<Thread> threads = new List<Thread>();

        public static void StartThread()
        {
            for (int i = 0; i < 2; i++)
            {
                Thread thread = new Thread(IncrementCounter);
                threads.Add(thread);
                thread.Start();
            }
        }
    }
}
