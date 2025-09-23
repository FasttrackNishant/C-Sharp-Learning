using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SystemThreading
{

    class RaceCondition
    {
        static int SharedCounter = 0;

        public static void printSharedCounter()
        {
            Console.WriteLine($"Final Counter Value: {SharedCounter}");
        }

        public static void IncrementCounter()
        {
            for (int i = 0; i < 100000; i++)
            {
                SharedCounter++;
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
