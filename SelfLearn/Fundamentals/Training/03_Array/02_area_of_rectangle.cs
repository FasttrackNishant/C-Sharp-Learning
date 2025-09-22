using System;

class Area
{

    static int AreaOfRectangle(int length, int breadth)
    {
        return length * breadth;
    }

    static int AreaOfCircle(int radius)
    {
        return Math.PI * radius * radius;
    }

    static void Main(string[] args)
    {


        int length, breadth = 0;
        float radius = 0;

        Console.WriteLine("Enter the lenght of Triangle ");
        length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the breadth of Triangle ");
        breadth = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the radius of Circle");
        radius = float.Parse(Console.ReadLint());

        Console.WriteLine(" Area of rectangle is " + AreaOfRectangle(length, breadth));
        Console.WriteLine(" Area of circle is " + AreaOfCircle(radius));
    }



}