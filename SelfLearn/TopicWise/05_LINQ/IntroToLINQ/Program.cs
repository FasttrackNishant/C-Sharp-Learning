using _05_IntroToLINQ;

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


        List<int> scores = [85, 92, 78, 90, 88, 76, 95, 89, 84, 91];

        // Deferred : Query is not executed until we iterate over it
        IEnumerable<int> highScoreds = scores.Where(scores => scores > 85);

        // alternate

        IEnumerable<int> highScoresQuery = from score in scores
                                           where score > 85
                                           select score;



        // Here it will execute when we iterate over it

        Console.WriteLine("High Scores (Deferred Execution):");



        foreach (var score in highScoreds)
        {
            Console.Write(score+ " ");
        }

        Console.WriteLine("\n-------------------\n");

        Console.WriteLine("High Scores (Query Syntax):");

        foreach (var score in highScoresQuery)
        {
            Console.Write(score+ " ");
        }


        LinqOperations.RunLinqOperationChain();


        LinqQueryOperations.RunLINQQueryOperations();

    }
}