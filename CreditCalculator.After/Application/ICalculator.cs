using CreditCalculator.After.Domain;

namespace CreditCalculator.After.Application
{
    public interface ICalculator
    {
        (bool HasCreditLimit, decimal? CreditLimit) Calculate(Company company, Customer customer);
    }
}