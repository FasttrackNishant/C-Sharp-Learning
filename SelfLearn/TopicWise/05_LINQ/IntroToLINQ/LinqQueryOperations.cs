using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_IntroToLINQ
{
    public static class LinqQueryOperations
    {
        public static void RunLINQQueryOperations()
        {
            var employees = new DataSet().employees;
            var products = new DataSet().Products;
            var departments = new DataSet().Departments;

            // LINQ Query Operations

            // Basics

            // Select

            var emps = from e in employees
                       select e;


            LinqOperations.PrintEmp(emps);

            Console.WriteLine("\n-------------------\n");


            // Select One

            var emp = from e in employees
                      where e.EmpId == 3
                      select e;

            Console.WriteLine($"Employee with ID 3: {emp.First().EmpName}\n");

            // Where
            var puneEmps = from e in employees
                           where e.City == "Pune"
                           select e;


            Console.WriteLine("Employees from Pune:");

            LinqOperations.PrintEmp(puneEmps);


            // GroupBy
            var groupedByCity = from e in employees
                                where e.City == "Pune"
                                group e by e.City;

            foreach (var group in groupedByCity)
            {
                Console.WriteLine($"\nCity: {group.Key}");
                LinqOperations.PrintEmp(group);
            }

            // join

            var empWithDept = from e in employees
                              join d in departments
                              on e.DeptId equals d.DeptId
                              select new
                              {
                                  e.EmpName,
                                  e.Job,
                                  e.City,
                                  Department = d.DeptName
                              };

            Console.WriteLine("\nEmployees with Departments:");
            foreach (var item in empWithDept)
            {
                Console.WriteLine($"Name: {item.EmpName}, Job: {item.Job}, City: {item.City}, Department: {item.Department}");
            }

            // Employee with second max 

            var secondHighestSalary = (from e in employees
                                       orderby e.EmpId descending
                                       select e).Distinct().Skip(1).FirstOrDefault();

            if (secondHighestSalary != null)
            {
                Console.WriteLine($"\nEmployee with Second Highest ID: {secondHighestSalary.EmpName}, ID: {secondHighestSalary.EmpId}\n");
            }
            else
            {
                Console.WriteLine("\nNo Employee found for Second Highest ID\n");
            }

           



           




            






            // Question 2 : List all products with category "Electronics" and price greater than 500.

            var filteredProducts = from p in products
                                   where p.Category == "Electronics" && p.Price > 500
                                   select p;




            // Question 3 : Group employees by their job titles and list the count of employees in each job title.

            // SQL Query for this:

            // Select job, count(*) from employees group by job;

            // Linq : query

            var groupedByJobTitle = from e in employees
                                    group e by e.Job into jobGroup
                                    select new
                                    {
                                        JobTitle = jobGroup.Key,
                                        EmployeeCount = jobGroup.Count()
                                    };


            // Linq : Method Syntax
            var groupedByJobTitleMethod = employees.GroupBy(e => e.Job)
                                                    .Select(g => new
                                                    {
                                                        JobTitle = g.Key,
                                                        EmployeeCount = g.Count()
                                                    });









        }
    }
}