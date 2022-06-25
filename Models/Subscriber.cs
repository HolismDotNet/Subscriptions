namespace Subscriptions;

public class Subscriber : IEntity
{
    public Subscriber()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid UserGuid { get; set; }

    public dynamic RelatedItems { get; set; }
}
