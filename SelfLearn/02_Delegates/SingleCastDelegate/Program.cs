using ClassLib1;

namespace SingleCastDelegate;

class Program
{
    public static void Main()
    {
        SampleDelegate s = new SampleDelegate();

        MyDelegateType myDelegate;

        myDelegate = new MyDelegateType(s.Add);

         Console.WriteLine(myDelegate.Invoke(3, 4));

        //th
    }
    
} 
