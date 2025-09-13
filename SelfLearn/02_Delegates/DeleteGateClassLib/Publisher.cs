namespace ClassLib1;

// public delegate void EventDelegate(int a, int b);

public class Publisher
{
    // private EventDelegate myDelegate;
    //
    // //event 
    // public event EventDelegate myEvent
    // {
    //     add { myDelegate += value; }
    //     remove { myDelegate -= value; }
    // }
    //
    // public void RaiseEvent(int a, int b)
    // {
    //     if (myDelegate is not null)
    //     {
    //         this.myDelegate(a, b);
    //     }
    // } 

    // auto implemented events -> ShortCut to Write the method
    //event 
    // public event EventDelegate myEvent;

    public void RaiseEvent(int a, int b)
    {
        if (myEvent is not null)
        {
            this.myEvent(a, b);
        }
    }

    // Func
    // public event Func<int, int, int> myEvent;

    //Action : it doesn't require return value
    public event Action<int, int> myEvent;

    // Predicate : one param , bool return

    public event Predicate<int> pEvent;

    public bool RaisePEvent(int a)
    {
        if (this.pEvent != null)
        {
            bool result = this.pEvent(a);
            return result;
        }
        else
        {
            return false;
        }
    }
}