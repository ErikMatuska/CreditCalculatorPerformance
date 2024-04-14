using CreditCalculator.After.Application;
using CreditCalculator.After.Domain;
using RegistR.Attributes.Base;

namespace CreditCalculator.After.Infrastructure;

[Obsolete("Replaced with file providers")]
public class InMemoryCustomerRepository : ICustomerRepository
{
    private readonly List<Customer> _customers = [];

    public List<Customer> GetCustomers() => _customers.ToList();

    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }
}
