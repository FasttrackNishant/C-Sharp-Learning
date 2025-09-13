using ClassLib1;

namespace MultiCastDelegateConsole;

class Program
{
    static void Main(string[] args)
    {
        MultiCastSample ms = new MultiCastSample();
        MultiCasteDelegateType myMultiCastDelegate;

        myMultiCastDelegate = ms.Add;
        myMultiCastDelegate += ms.Multiple;

        myMultiCastDelegate.Invoke(40, 10);
    }
}
