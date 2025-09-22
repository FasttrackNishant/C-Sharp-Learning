using System;
class Tutorial
{
    public static void Main(string[] args)
    {

        // int Radius = 10;
        // double A;
        // Area(ref Radius, out A); //call by refrence function 

        // Console.WriteLine("Area is " + A);

        // int length = 10;
        // int breadth = 2;
        // double result;

        // rect_Area(ref length, ref breadth, out result);
        // Console.WriteLine("Rect ares is " + result);
        // Console.ReadKey();
        

        int first = 10;
        int second = 20;

        Console.WriteLine("before " + first + " " + second);
        swapNumbers(ref first,ref second);
        Console.WriteLine("after " + first + " " + second);




    }
    public static void Area(ref int r, out double a)
    {
        a = Math.PI * r * r;

    }

    public static void rect_Area(ref int Length, ref int breadth, out double a)
    {
        a = Length * breadth;
    }

    public static void swapNumbers(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}

// ref - ref mein pointer ki tarf hain in c++

//out mein value bharke aati hain

/* out and ref , out main se khali jata hain then , 
function mein uski value fill hoti hain

// params keyword



*/