using System;
class Tutorial
{
    static void Main(string[] args)
    {

        GetDetailsOfStudent('M', "roy", "joy", "sahil", "ramesh", "rajesh");
        Console.ReadKey();

    }

    public static void GetDetailsOfStudent(char gender, params string[] students)
    {

        if (gender == 'f' || gender == 'F')
        {
            Console.WriteLine("count of girl students is " + students.Length);
        }
        else if (gender == 'm' || gender == 'M')
        {
            Console.WriteLine("count  of boys in class " + students.Length);
        }


        foreach (var item in students)
        {
            Console.WriteLine(item + " ");

        }

    }
}