using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_array_default
{
    public class Program
    {

        public static void Main(string[] args)
        {

            int[] numbers = { 23, 4, 5, 3, 4, 6, 544, 2, 3, 677, 90 };


            // ye wala exception deta hain 
            // var data = numbers.Single(n => n > 1000);
            // Console.WriteLine($"{data}");
            // invalid opeation exception , jav value nahi milti condition match hone wali then operation mein exception aata hain 

            //single or default -> data variable value will be assign to if the data not matches
            var data1 = numbers.SingleOrDefault(n => n > 1000);
            Console.WriteLine($"{data1}");

            //fruits assignment
            List<string> Fruits = new List<string>() { "Mango", "Apple", "Banana", "Orange" };
            var FruitResult = Fruits.SingleOrDefault(f => f.Contains("z"));
            Console.WriteLine($"FruitResult {FruitResult}");
            Console.WriteLine($"{FruitResult?.Length}");

            //firstordefault
            var ResultFirstFruit = Fruits.FirstOrDefault(f => f.EndsWith("ge"));
            Console.WriteLine($"ResultFirstFruit {ResultFirstFruit}");


            //first
            //this will also give exception -> Sequence contains no matching property
            int[] Numbers = { 2, 78, 5, 46, 32 };

            try
            {
                var divisible = Numbers.First(n => n % 7 == 0);
                Console.WriteLine($"First divisible : {divisible}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            var divisibleFirstOrDeafult = Numbers.FirstOrDefault(n => n % 7 == 0);
            Console.WriteLine($"divisibleFirstOrDeafult {divisibleFirstOrDeafult}");


            var Emp = Employee.GetEmployees().Where(e => e.Salary > 40000).ToArray();
            if (Emp.Length > 0)
            {
                Console.WriteLine($"{Emp[0].FirstName}");
            }
            else
            {
                Console.WriteLine($"No Employee Found");

            }



        }
    }
}

