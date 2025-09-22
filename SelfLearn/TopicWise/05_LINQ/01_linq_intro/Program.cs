using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Versioning;
using System.Threading.Tasks;

namespace _01_linq_intro
{
    internal class Program
    {
        public static void print(dynamic a)
        {
            foreach (var item in a)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {

            int[] numbers = { 23, 454, 32, 76, 43, 87, 443 };
            var result1 = from n in numbers select n;
            print(result1);

            //second example second char i chahiye
            string[] digits = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var result2 = from d in digits where d[1] == 'i' select d;
            var reverseChar = (from d in digits where d[1] == 'i' select d).Reverse();
            var evenResult = from n in numbers
                             where n > 50 && n % 2 == 0
                             select n;

            print(result2);
            print(reverseChar);
            print(evenResult);

            //musicina
            string[] singers = { "Asha Bhosale", "Amit Kumar", "Udit Narayan", "Kishor Kumar" };
            var resultStartWith = from s in singers
                                  where s.StartsWith("A")
                                  select s;

            var resultEndsWith = from s in singers
                                 where s.EndsWith("Kumar")
                                 select s;

            var resultContains = from s in singers
                                 where s.Contains("Na")
                                 select s;

            print(resultStartWith);
            print(resultEndsWith);
            print(resultContains);

            /*
                intersect , union , max , min , sum , count , except  , 
            */

            string[] words = { "belief", "receive", "achieve", "relieve" };
            //any is like or operator
            bool resultAny = words.Any(w => w.Contains("ei"));
            Console.WriteLine($"{resultAny}");

            //all is like and operator 
            bool resultAll = words.All(w=> w.Contains("ei"));
            Console.WriteLine($"{resultAll}");

        }
    }
}