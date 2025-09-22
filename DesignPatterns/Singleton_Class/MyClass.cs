using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton_Class
{
    sealed class MyClass
    {

        private MyClass()
        {
            //no logic to be written here 
        }

        private static MyClass instance;
        private static object instanceLock = new object();

        public static MyClass GetInstance()
        {
            //this is for the waiting time
            if (instance == null)
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MyClass();
                    }
                }
            }
            return instance;
        }
    }
}