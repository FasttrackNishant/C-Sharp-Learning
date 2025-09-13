namespace GenericIntroConsole;

public abstract class GenericConstraints
{
    public abstract int Marks { get; set; }
}

public class GraduateGenericConstraints : GenericConstraints
{
    public override int Marks { get; set; }
}

public class PgGenericConstraints : GenericConstraints
{
    public override int Marks { get; set; }
}

public class MarksPrinter<T> where T : GenericConstraints
{
    public T Stu;

    public void PrintMarks()
    {
        GenericConstraints temp = (GenericConstraints)Stu;
        Console.WriteLine("Marks are " + temp.Marks);
    }
}