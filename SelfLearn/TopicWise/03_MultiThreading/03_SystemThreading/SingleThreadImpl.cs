using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SystemThreading
{
    public class SingleThreadImpl
    {

        public void MethodA()
        {
            for (int i = 0; i < 5; i++)
            {
                {
                    Console.WriteLine("Method A");
                    Thread.Sleep(1000);
                }
            }
        }

        public void MethodB()
        {
            for (int i = 0; i < 5; i++)
            {
                {
                    Console.WriteLine("Method B");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
