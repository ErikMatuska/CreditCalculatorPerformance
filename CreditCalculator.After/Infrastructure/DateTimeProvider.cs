using CreditCalculator.After.Application;
using RegistR.Attributes.Base;

namespace CreditCalculator.After.Infrastructure;

[Register<IDateTimeProvider>]
public class DateTimeProvider : IDateTimeProvider
{
    public DateTime Now => DateTime.Now;

    public DateTime UtcNow => DateTime.UtcNow;
}
