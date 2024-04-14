using CreditCalculator.After.Application;
using RegistR.Attributes.Base;

namespace CreditCalculator.After.Infrastructure;

[Register<ICustomerCreditServiceClient>]
public class CustomerCreditServiceClient : ICustomerCreditServiceClient
{
    public decimal GetCreditLimit(string firstName, string lastName, DateTime dateOfBirth)
    {
        if (firstName == "John" && lastName == "Doe")
        {
            return 500.0m;
        }

        if (DateTime.Now.Year - dateOfBirth.Year > 40)
        {
            return 600.0m;
        }

        return 249.9m;
    }
}