using CreditCalculator.After.Application;
using CreditCalculator.After.Domain;
using RegistR.Attributes.Base;

namespace CreditCalculator.After.Infrastructure;

[Register<ICalculator>]
public class CreditLimitCalculator(ICustomerCreditServiceClient creditService) : ICalculator
{
    public (bool HasCreditLimit, decimal? CreditLimit) Calculate(
        Company company,
        Customer customer)
    {
        return company.Type switch
        {
            CompanyType.VeryImportantClient => (false, null),
            CompanyType.ImportantClient => (true, GetCreditLimit(customer) * 2),
            _ => (true, GetCreditLimit(customer))
        };
    }

    private decimal GetCreditLimit(Customer customer)
    {
        return creditService.GetCreditLimit(
            customer.FirstName,
            customer.LastName,
            customer.DateOfBirth);
    }
}