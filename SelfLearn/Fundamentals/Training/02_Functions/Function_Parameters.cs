using System;
enum Department { HR, IT, Civil, Electrical, Accounts };

class Intro
{
    static void Main(string[] args)
    {
        GetEmployeeDetails(1, "Dev", "Nishant", 342.432m, Department.Accounts);
        Console.WriteLine();
        

        // named parameters
        GetEmployeeDetails(empId:34,firstName: "bill", lastName: "deo", salary:332.2m , dept:Department.HR);
    }

    public static void GetEmployeeDetails(int empId, string firstName, string lastName, decimal salary, Department dept)
    {
        Console.WriteLine("ID " + empId);
        Console.WriteLine("firstName " + firstName);
        Console.WriteLine("last Name " + lastName);
        Console.WriteLine("salary " + salary);
        Console.WriteLine("Department " + dept);

    }
}