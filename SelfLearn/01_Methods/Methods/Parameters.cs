namespace Methods;

public static  class Parameters
{
    
    
// Parameter Modifier
// parameter mein change kiya toh argmetn mein dikhega 

    public static  void CheckInput(ref int input)
    {
        input = 90;
    }

    public static void TestOut(out int input)
    {
        input = 50;
        Console.WriteLine("Out value in class " + input );
        input = 100;
    }

    public static void TestIn(in int input)
    {

        // input = 34; // wrong
    }
    
    // Params
    public static void TestParams(int a , params int[] values)
    {
        foreach (var value in values)
        {
            Console.Write(value + " ");
        }
    }


    public static int TestLocalFunction(int std = 3)
    {
        CallLocalFunction();

        void CallLocalFunction()
        {
            Console.WriteLine("std is "+ std);
            Console.WriteLine("hi from local function");
        }

        CallStaticLocalFunction();

        static void CallStaticLocalFunction()
        {
            Console.WriteLine("here no params accessible");
            // Console.WriteLine("std is "+ std);
        }

        return 3;
    }


}

// Operator Overloading

public static class TestHelper
{
    public static void Test(int a=34)
    {
        Console.WriteLine("One parameter: " + a);
    }

    public static void Test(int a = 19, int b = 30)
    {
        Console.WriteLine("Two parameters: " + a + ", " + b);
    }
}

// Ref reutrn

public class Student
{
    public int grade = 2;

    public void printGrade()
    {
        Console.WriteLine("grade is = " + this.grade);
    }

    public ref int DoWork()
    {
        return ref grade;
    }
    
}

