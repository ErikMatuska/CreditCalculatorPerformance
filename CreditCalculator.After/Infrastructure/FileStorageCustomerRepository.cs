using CreditCalculator.After.Application;
using CreditCalculator.After.Domain;
using CreditCalculator.Storage;

namespace CreditCalculator.After.Infrastructure;

public class FileStorageCustomerRepository : ICustomerRepository
{
    private readonly ICustomerDataProvider _customerDataProvider;

    public FileStorageCustomerRepository(ICustomerDataProvider customerDataProvider)
    {
        _customerDataProvider = customerDataProvider;
    }

    public void AddCustomer(Customer customer)
    {
        throw new NotImplementedException();
    }

    public List<Customer> GetCustomers()
    {
        return _customerDataProvider.GetCustomers();
    }
}
