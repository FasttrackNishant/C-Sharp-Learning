using System;
class exercise
{

    static int calculateSum(int arr)
    {
        int sum = 0;
        foreach (int number in arr)
        {
            sum += number;
        }

        return sum;
    }

    static void Main(string[] args)
    {

        Console.WriteLine("Hello this ");

        int[] marks = new int[5];
        int sum = 0;

        Console.WriteLine("size of array is " + marks.Length);

        for (int i = 0; i < marks.Length; i++)
        {
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("sum is " + calculateSum(marks));

    }
}