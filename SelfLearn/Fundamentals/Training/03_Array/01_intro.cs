using System;


class Hello
{
  static void Main(string[] args)
  {

    string[] friends = new string[5];


    // taking input for the array
    // for (int i = 0; i < 5; i++)
    // {
    //   friends[i] = Console.ReadLine();
    // }

    // for (int i = 0; i < friends.Length; i++)
    // {
    //   Console.WriteLine(friends[i]);
    // }


    // for each loop
    string[] fruits = { "first", "second", "third", "fourth" };
    foreach (string fruit in fruits)
    {
      Console.WriteLine("Sorted array is ", Array.Sort(fruits));
    }
  

  }
}
