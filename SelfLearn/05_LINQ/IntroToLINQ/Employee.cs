namespace IntroToLINQ;

public class Employee
{
    public int EmpId { get; set; }

    public string EmpName { get; set; }

    public string Job { get; set; }

    public string City { get; set; }

    public override string ToString()
    {
        return $"{EmpId} - {EmpName} ({Job}) from {City}";
    }
}