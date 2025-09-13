// See https://aka.ms/new-console-template for more information

using Methods;

Console.WriteLine("Hello, World!");

Console.Write("This is text");

Product p1 = new Product();

p1.calculateTax();

TestHelper.Test(a:3);

int input = 10;

Parameters.CheckInput(ref input);
Console.WriteLine("input is "+ input);

Parameters.TestOut(out input);
Console.WriteLine("out is "+ input);

// this is new way of declaring
Parameters.TestOut(out int newInput);

Parameters.TestIn(in newInput);

// ref return 

Student s1 = new Student();
s1.printGrade();
ref int newGrade =ref s1.DoWork();
newGrade = 34;

s1.printGrade();

//Params
Parameters.TestParams(1,2,3,3,10,23);

// Local Function
Parameters.TestLocalFunction();

// Type Conversion
int a = 1000;
float b ;
byte bt;

Console.WriteLine(a);

b = (float)a;
Console.WriteLine(b);

bt = (byte)a;
Console.WriteLine(bt);

//Parsing

string str = "400";
int intStr =  int.Parse(str);
Console.WriteLine(intStr);

 str = "40i0";
// Try Parse
int result; 
bool testTryParse = int.TryParse(str, out result);
Console.WriteLine(testTryParse);
Console.WriteLine(result);