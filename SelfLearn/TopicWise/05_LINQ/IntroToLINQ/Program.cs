namespace IntroToLINQ;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees =
        [
            new Employee { EmpId = 1, EmpName = "Nishant", Job = "Software", City = "Pune" },
            new Employee { EmpId = 2, EmpName = "Aditi", Job = "QA", City = "Mumbai" },
            new Employee { EmpId = 3, EmpName = "Rohan", Job = "HR Manager", City = "Delhi" },
            new Employee { EmpId = 4, EmpName = "Sneha", Job = "Business Analyst", City = "Pune" },
            new Employee { EmpId = 5, EmpName = "Arjun", Job = "Project", City = "Hyderabad" },
            new Employee { EmpId = 6, EmpName = "Meera", Job = "Software", City = "Chennai" },
            new Employee { EmpId = 7, EmpName = "Karan", Job = "DevOps", City = "Bangalore" },
            new Employee { EmpId = 8, EmpName = "Priya", Job = "UI/UX Designer", City = "Pune" },
            new Employee { EmpId = 9, EmpName = "Sahil", Job = "Data Scientist", City = "Mumbai" },
            new Employee { EmpId = 10, EmpName = "Ananya", Job = "Software Engineer", City = "Bangalore" }
        ];


        var result = employees.Where(emp => emp.Job == "Software");

        foreach (Employee emp in result)
        {
            Console.WriteLine(emp);
        }

        //  Order by 
        IOrderedEnumerable<Employee> sortedData = employees.OrderBy(emp => emp.EmpId);

        foreach (var VARIABLE in COLLECTION)
        {
            
        }
        

    }
}