namespace Subscriptions;

public class Repository
{
    public static Write<Subscriptions.Subscriber> Subscriber
    {
        get
        {
            return new Write<Subscriptions.Subscriber>(new SubscriptionsContext());
        }
    }
}
