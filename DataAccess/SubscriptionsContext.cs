namespace Subscriptions;

public class SubscriptionsContext : DatabaseContext
{
    public override string ConnectionStringName => "Subscriptions";

    public DbSet<Subscriptions.Subscriber> Subscribers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
