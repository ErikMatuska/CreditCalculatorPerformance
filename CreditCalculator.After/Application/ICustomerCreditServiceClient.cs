namespace CreditCalculator.After.Application
{
    public interface ICustomerCreditServiceClient
    {
        decimal GetCreditLimit(string firstName, string lastName, DateTime dateOfBirth);
    }
}