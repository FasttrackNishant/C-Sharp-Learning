using IntroToLINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_IntroToLINQ
{
    public class DataSet
    {

        public List<int> scores = new List<int> { 85, 92, 78, 90, 88, 76, 95, 89, 84, 91 };


        public List<Employee> employees = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "Nishant", Job = "Software", City = "Pune", DeptId = 3 },
            new Employee { EmpId = 2, EmpName = "Aditi", Job = "QA", City = "Mumbai", DeptId = 3 },
            new Employee { EmpId = 3, EmpName = "Rohan", Job = "HR Manager", City = "Delhi", DeptId = 1 },
            new Employee { EmpId = 4, EmpName = "Sneha", Job = "Business Analyst", City = "Pune", DeptId = 5 },
            new Employee { EmpId = 5, EmpName = "Arjun", Job = "Project", City = "Hyderabad", DeptId = 4 },
            new Employee { EmpId = 6, EmpName = "Meera", Job = "Software", City = "Chennai", DeptId = 3 },
            new Employee { EmpId = 7, EmpName = "Karan", Job = "DevOps", City = "Bangalore", DeptId = 3 },
            new Employee { EmpId = 8, EmpName = "Priya", Job = "UI/UX Designer", City = "Pune", DeptId = 4 },
            new Employee { EmpId = 9, EmpName = "Sahil", Job = "Data Scientist", City = "Mumbai", DeptId = 3 },
            new Employee { EmpId = 10, EmpName = "Ananya", Job = "Software Engineer", City = "Bangalore", DeptId = 3 }
        };

        public List<Product> Products = new List<Product>
                    {
            new Product { ProductId = 1, ProductName = "Laptop", Category = "Electronics", Price = 1200.00m },
            new Product { ProductId = 2, ProductName = "Smartphone", Category = "Electronics", Price = 800.00m },
            new Product { ProductId = 3, ProductName = "Tablet", Category = "Electronics", Price = 400.00m },
            new Product { ProductId = 4, ProductName = "Headphones", Category = "Accessories", Price = 150.00m },
            new Product { ProductId = 5, ProductName = "Smartwatch", Category = "Accessories", Price = 200.00m },
            new Product { ProductId = 6, ProductName = "Camera", Category = "Electronics", Price = 600.00m },
            new Product { ProductId = 7, ProductName = "Printer", Category = "Office Supplies", Price = 250.00m },
            new Product { ProductId = 8, ProductName = "Monitor", Category = "Electronics", Price = 300.00m },
            new Product { ProductId = 9, ProductName = "Keyboard", Category = "Accessories", Price = 100.00m },
            new Product { ProductId = 10, ProductName = "Mouse", Category = "Accessories", Price = 50.00m }
        };

        public List<Department> Departments = new List<Department>
        {
            new Department { DeptId = 1, DeptName = "Human Resources" },
            new Department { DeptId = 2, DeptName = "Finance" },
            new Department { DeptId = 3, DeptName = "IT" },
            new Department { DeptId = 4, DeptName = "Marketing" },
            new Department { DeptId = 5, DeptName = "Sales" }
        };


        public List<Order> orders = new List<Order> {

            new Order { OrderId = 1, ProductId = 1, Quantity = 2, OrderDate = new DateTime(2023, 1, 15) },
            new Order { OrderId = 2, ProductId = 3, Quantity = 1, OrderDate = new DateTime(2023, 2, 10) },
            new Order { OrderId = 3, ProductId = 2, Quantity = 5, OrderDate = new DateTime(2023, 3, 5) },
            new Order { OrderId = 4, ProductId = 5, Quantity = 3, OrderDate = new DateTime(2023, 4, 20) },
            new Order { OrderId = 5, ProductId = 4, Quantity = 4, OrderDate = new DateTime(2023, 5, 18) },
            new Order { OrderId = 6, ProductId = 6, Quantity = 2, OrderDate = new DateTime(2023, 6, 25) },
        };



    }

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

    }


    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }

    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public string City { get; set; }

        public int DeptId { get; set; } // Foreign Key to Department

    }

    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; } // Foreign Key to Product
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}

