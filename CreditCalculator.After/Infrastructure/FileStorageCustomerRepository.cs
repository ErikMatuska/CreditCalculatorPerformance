using CreditCalculator.After.Application;
using CreditCalculator.After.Domain;
using CreditCalculator.Storage;
using RegistR.Attributes.Base;

namespace CreditCalculator.After.Infrastructure;

[Register<ICustomerRepository>]
public class FileStorageCustomerRepository : ICustomerRepository
{
    private readonly ICustomerDataProvider _customerDataProvider;

    public FileStorageCustomerRepository(ICustomerDataProvider customerDataProvider)
    {
        _customerDataProvider = customerDataProvider;
    }

    public void AddCustomer(Customer customer)
    {
        _customerDataProvider.AddCustomer(customer);
    }

    public List<Customer> GetCustomers()
    {
        return _customerDataProvider.GetCustomers();
    }
}
