namespace CreditCalculator.After.Application;

public interface IDateTimeProvider
{
    public DateTime Now { get; }
    public DateTime UtcNow { get; }
}
