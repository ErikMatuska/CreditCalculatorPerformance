using CreditCalculator.After.Domain;

namespace CreditCalculator.After.Application
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        List<Customer> GetCustomers();
    }
}