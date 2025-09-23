using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_IntroToLINQ
{
    public static class LinqPracticeQuestions
    {
        public static void RunPracticeQuestion()
        {
            var employees = new DataSet().employees;
            var products = new DataSet().Products;
            var departments = new DataSet().Departments;


            // Lets Practice Question Wise all Three SQL , Linq Query , Linq Method Syntax

            //-- Level 1 : Basics

            // Question 1 : List all employees from the city "Pune".

            // SQL : 
            // Select * from employees where city = 'Pune';

            // Linq: Query Syntax
            var puneEmp = from e in employees
                          where e.City == "Pune";

            // Linq: Method Syntax
            var puneEmpMethod = employees.Where(e => e.City == "Pune");



            // Question 2 : Find the total number of products in the "Electronics" category.

            // SQL
            // Select count(*) from products where category = 'Electronics';

            // Linq: Query Syntax
            var electronicsCount = (from p in products
                                    where p.Category == "Electronics"
                                    select p).Count();

            // Linq: Method Syntax
            var electronicsCountMethod = products.Count(p => p.Category == "Electronics");


            // Question 3 : Get the details of the employee with the highest EmpId.

            // SQL
            // Select * from employees where EmpId = (Select max(EmpId) from employees);

            // Linq: Query Syntax
            var highestEmpId = (from e in employees
                                orderby e.EmpId descending
                                select e).FirstOrDefault();


            // Linq: Method Syntax
            var highestEmpIdMethod = employees.OrderByDescending(e => e.EmpId).FirstOrDefault();


            // Question 4 : List all products with a price greater than 500.

            // SQL
            // Select * from products where price > 500;

            // Linq: Query Syntax
            var expensiveProducts = from p in products
                                    where p.Price > 500
                                    select p;

            // Linq: Method Syntax

            var expensiveProductsMethod = products.Where(p => p.Price > 500);


            // Question 5 : Find the average price of products in the "Accessories" category.

            // SQL
            // Select avg(price) from products where category = 'Accessories';

            // Linq: Query Syntax
            var avgAccessoriesPrice = (from p in products
                                       where p.Category == "Accessories"
                                       select p.Price).Average();


            // Linq: Method Syntax
            var avgAccessoriesPriceMethod = products.Where(p => p.Category == "Accessories").Average(p => p.Price);


            // Question 6 : List all employees along with their department names.

            // SQL
            // 



        }

    }
}
