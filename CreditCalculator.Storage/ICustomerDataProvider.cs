using CreditCalculator.After.Domain;
using System.Text.Json.Serialization;

namespace CreditCalculator.Storage
{
    public interface ICustomerDataProvider
    {
        void AddCustomer(Customer customer);
        List<Customer> GetCustomers();
    }
}
