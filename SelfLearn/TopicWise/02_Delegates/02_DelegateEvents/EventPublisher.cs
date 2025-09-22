namespace _02_DelegateEvents
{
    // Normal : Using Custom Delegate
    public delegate void NotifyEventHandler(string message);

    public class EventPublisher
    {
        private NotifyEventHandler SubscribeSimpleEvent;

        public event NotifyEventHandler SimpleEvent
        {
            add
            {
                SubscribeSimpleEvent += value;
            }
            remove
            {
                SubscribeSimpleEvent -= value;
            }
        }

        public void OnNotify(string message)
        {
            if (SubscribeSimpleEvent != null)
            {
                SubscribeSimpleEvent(message);
            }
        }

    }

    public class ActionEventPublisher
    {
        private Action<string> subscribeActionEvent;

        public event Action<string> ActionEvent
        {
            add
            {
                subscribeActionEvent += value;
            }
            remove
            {
                subscribeActionEvent -= value;
            }
        }

        public void OnNotify(string message)
        {
            if (subscribeActionEvent != null)
            {
                subscribeActionEvent(message);
            }
        }
    }


    public class FunctEventPublisher
    {
        private Func<int, int, int> subscribeFuncEvent;
        public event Func<int, int, int> FuncEvent
        {
            add
            {
                subscribeFuncEvent += value;
            }
            remove
            {
                subscribeFuncEvent -= value;
            }
        }
        public int OnCalculate(int a, int b)
        {
            if (subscribeFuncEvent != null)
            {
                return subscribeFuncEvent(a, b);
            }
            return 0;
        }
    }

    public class PredicateEventPublisher
    {
        private Predicate<int> subscribePredicateEvent;

        public event Predicate<int> PredicateEvent
        {
            add
            {
                subscribePredicateEvent += value;
            }
            remove
            {
                subscribePredicateEvent -= value;
            }
        }
        public bool OnCheck(int number)
        {
            if (subscribePredicateEvent != null)
            {
                return subscribePredicateEvent(number);
            }
            return false;
        }
    }
}