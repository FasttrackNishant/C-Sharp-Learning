using System;
class Tutorial
{

    public static dynamic averageOfArray(int[] arr)
    {
        int sum = 0;
        foreach (int index in arr)
        {
          
            sum+=index;

        }

        return sum / arr.Length;
    }

    public static void Main(string[] args)
    {

        int size = 0;
        Console.WriteLine("Enter the size of an array");
        size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Average of Array is " + averageOfArray(arr));

    }
}