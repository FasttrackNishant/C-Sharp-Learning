using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_IntroToLINQ;

public class LinqOperations
{

    public static void RunLinqOperationChain()
    {
        var employees = new DataSet().employees;
        var products = new DataSet().Products;



        // Order by

        var orderedEmps = employees.OrderBy(e => e.EmpName).ThenBy(e => e.EmpId);

        PrintEmp(orderedEmps);


        // first
        // can give InvalidOperationException if no match found
        var firstEmp = employees.First(e => e.City == "Pune");
        Console.WriteLine($"\nFirst Employee from Pune: {firstEmp.EmpName}\n");

        // FirstOrDefault

        var firstOrDefaultEmp = employees.FirstOrDefault(e => e.City == "Noida");
        if (firstOrDefaultEmp == null)
        {
            Console.WriteLine("No Employee found from Noida\n");
        }
        else
        {
            Console.WriteLine($"First Employee from Noida: {firstOrDefaultEmp.EmpName}\n");
        }

        Console.WriteLine("==================================================================\n");


        // Last
        // can give InvalidOperationException if no match found
        var lastEmp = employees.Last(e => e.City == "Pune");
        Console.WriteLine($"Last Employee from Pune: {lastEmp.EmpName}\n");

        //LastOrDefault
        var lastOrDefaultEmp = employees.LastOrDefault(e => e.City == "Noida");
        if (lastOrDefaultEmp == null)
        {
            Console.WriteLine("No Employee found from Noida\n");
        }
        else
        {
            Console.WriteLine($"Last Employee from Noida: {lastOrDefaultEmp.EmpName}\n");
        }


        Console.WriteLine("==================================================================\n");

        // ElementAt
        // can give ArgumentOutOfRangeException if index is out of range
        var thirdEmp = employees.ElementAt(2);
        Console.WriteLine($"Third Employee: {thirdEmp.EmpName}\n");

        // ElementAtOrDefault
        var eleventhEmp = employees.ElementAtOrDefault(10);
        if (eleventhEmp == null)
        {
            Console.WriteLine("No Eleventh Employee found\n");
        }
        else
        {
            Console.WriteLine($"Eleventh Employee: {eleventhEmp.EmpName}\n");
        }

        Console.WriteLine("==================================================================\n");


        // Single
        // can give InvalidOperationException if no match found or more than one match found
        try
        {
            var singleEmp = employees.Single(e => e.EmpId == 1);
            Console.WriteLine($"Single Employee with EmpId 1: {singleEmp.EmpName}\n");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }


        // SinleOrDefault
        try
        {
            var singleOrDefaultEmp = employees.SingleOrDefault(e => e.EmpId == 11);
            if (singleOrDefaultEmp == null)
            {
                Console.WriteLine("No Employee found with EmpId 11\n");
            }
            else
            {
                Console.WriteLine($"Single Employee with EmpId 11: {singleOrDefaultEmp.EmpName}\n");
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("==================================================================\n");


        // Select

        var empNames = employees.Select(e => e.EmpName);
        Console.WriteLine("Employee Names:");
        foreach (var name in empNames)
        {
            Console.WriteLine(name);
        }

        // Aggegate Functions
        // They are not deferred, they execute immediately

        var totalEmployees = employees.Count();
        Console.WriteLine($"\nTotal Employees: {totalEmployees}");

        var maxPrice = products.Max(p => p.Price);
        Console.WriteLine($"\nMax Product Price: {maxPrice}");

        var minPrice = products.Min(p => p.Price);
        Console.WriteLine($"\nMin Product Price: {minPrice}");


        var avgPrice = products.Average(p => p.Price);
        Console.WriteLine($"\nAverage Product Price: {avgPrice}");

        Console.WriteLine("==================================================================\n");


    }


    public static void PrintEmp(IEnumerable<Employee> emp)
    {
        foreach (var e in emp)
        {
            Console.WriteLine($"{e.EmpId} - {e.EmpName} ({e.Job}) from {e.City}");
        }

    }

}

