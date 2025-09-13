namespace GenericIntroConsole;

class Program
{
    static void Main(string[] args)
    {
        User<int, int> user = new User<int, int>();
        user.RegisterationStatus = 34232;
        user.Age = 30;

        Console.WriteLine(user.RegisterationStatus);

        User<bool, string> user1 = new User<bool, string>();
        user1.RegisterationStatus = false;
        user1.Age = "30-40";

        Console.WriteLine(user1.RegisterationStatus);
        Console.WriteLine(user1.Age);

        Console.WriteLine(user.RegisterationStatus);
        Console.WriteLine(user.Age);

        // Generic Constraints

        GraduateGenericConstraints st = new GraduateGenericConstraints() { Marks = 34 };
        MarksPrinter<GraduateGenericConstraints> mp = new MarksPrinter<GraduateGenericConstraints>();
        mp.Stu = new GraduateGenericConstraints() { Marks = 80 };
        mp.Stu = st;
        mp.PrintMarks();

        Employee emp = new Employee() { Salary = 1000 };
        Student student = new Student() { Marks = 100 };

        Data dt = new Data();
        dt.PrintData(emp);
    }
}