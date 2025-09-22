using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_linq_sql
{

    /*complex query => linq query 
      too much complications => where query    
    */
    public class Program
    {

        public static void print(dynamic a)
        {
            foreach (var item in a)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        public static void Main1()
        {


            List<int> intList = new List<int> { 1, 23, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine($"using Linq Query");

            var data = from num in intList
                       where num > 5
                       select num;


            print(data);

            // linq where method lambda expression
            Console.WriteLine($"using lambda ");

            var answer = intList.Where(n => n > 5);
            print(answer);


            //using student object

            Console.WriteLine($"---------All Students------------");
            var AllStudents = from s in Student.GetStudents()
                              select s;
            print(AllStudents);

            // linq query
            Console.WriteLine($"All Girls");
            var resultGirl = from s in Student.GetStudents()
                             where s.Gender == "Female"
                             select s;
            print(resultGirl);

            //using lambda expression
            Console.WriteLine($"Using Lambd for Girls");
            var Girls = Student.GetStudents().Where(s => s.Gender == "Female");
            print(Girls);



            Console.WriteLine($"---------All Boys----------");
            var resultBoy = from s in Student.GetStudents()
                            where s.Gender == "Male"
                            select s;
            print(resultBoy);

            var BoyCount = resultBoy.Count();
            Console.WriteLine($"BoyCount - {BoyCount}");

            //using lambda for boys
            Console.WriteLine($"Using Lambda for Boys");
            var resultBoyLamba = Student.GetStudents().Where(s => s.Gender == "Male");
            print(resultBoyLamba);




            //group by

            // var data = Student.GetStudents().GroupBy





        }
    }
}