using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_linq_introduction
{
    internal class Program
    {

        public static void print(dynamic a)
        {
            foreach (int item in a)
            {
                Console.Write($"{item} ");
            }
        }
        public static void Main(string[] args)
        {

            int[] age = { 12, 23, 56, 43, 67, 86, 444 };
            var a = from i in age where i > 20 select i;

            //sorting the result
            //select * from table where age > 20 order by age desc ; 

            var asc = from i in age where i > 20 orderby i select i; //asc
            var desc = from i in age where i > 20 orderby i descending select i; //desc

            Console.Write($"asc ");
            print(asc);
            Console.WriteLine($"desc");
            print(desc);


        }
    }
}