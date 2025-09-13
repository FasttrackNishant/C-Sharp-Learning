using ClassLib1;

namespace MultiCasteDelegate;

class Program
{
    static void Main()
    {
        MultiCastSample ms = new MultiCastSample();
        MultiCasteDelegateType myMultiCastDelegate;

        myMultiCastDelegate = ms.Add;
        myMultiCastDelegate += ms.Multiple;

        myMultiCastDelegate.Invoke(40, 10);
    }
}