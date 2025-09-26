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
            var categories = new DataSet().categories; // assuming categories is similar to departments


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


            // Question : 2a : Category is the diffent table now having fk in the products table

            // SQL :
            // Select count(*) from products p inner join categories c on p.CategoryId = c.CategoryId where c.CategoryName = 'Electronics';


            // Linq: Query Syntax   
            // assume ther is categoyr table as well
            var electronicsCountJoin = (from p in products
                                        join c in departments on p.Category equals c.DeptName
                                        where c.DeptName == "Electronics"
                                        select p).Count();

            // Linq: Method Syntax
            var electronicsCountJoinMethod = products.Join(departments,
                                                          p => p.Category,
                                                          c => c.DeptName,
                                                          (p, c) => new { p, c })
                                                     .Where(pc => pc.c.DeptName == "Electronics")
                                                     .Count();



            // Question 3 : Get the details of the employee with the highest EmpId.

            // SQL
            // Select * from employees where EmpId = (Select max(EmpId) from employees);

            // Select * from employees order by EmpId desc limit 1;

            // Select Top 1 * from employees order by EmpId desc;

            // Linq: Query Syntax
            var highestEmpId = (from e in employees
                                orderby e.EmpId descending
                                select e).FirstOrDefault();

            // using limit
            var highestEmpIdLimit = (from e in employees
                                     orderby e.EmpId descending
                                     select e).Take(1).FirstOrDefault();


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

            // If Category was diff table
            // Select avg(p.price) from products p inner join categories c on p.CategoryId = c.CategoryId where c.CategoryName = 'Accessories';

            // Linq: Query Syntax
            var avgAccessoriesPrice = (from p in products
                                       where p.Category == "Accessories"
                                       select p.Price).Average();


            // If Category was diff table
            var avgAccessoriesPriceJoin = (from p in products
                                           join c in departments on p.Category equals c.DeptName
                                           where c.DeptName == "Accessories"
                                           select p.Price).Average();


            // Linq: Method Syntax
            var avgAccessoriesPriceMethod = products.Where(p => p.Category == "Accessories").Average(p => p.Price);

            // If Category was diff table
            var avgAccessoriesPriceJoinMethod = products.Join(categories,
                                                            p => p.CategoryId,
                                                            c => c.CategoryId,
                                                            (p, c) => new { p, c })
                                                       .Where(pc => pc.c.CategoryName == "Accessories")
                                                       .Average(pc => pc.p.Price);


            // Question 6 : List all employees along with their department names.

            // SQL
            // 



        }

    }
}
