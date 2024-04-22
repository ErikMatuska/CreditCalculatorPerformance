using CreditCalculator.After.Application;
using CreditCalculator.After.Domain;
using CreditCalculator.Storage;
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

////public class FileStorageCustomerRepository : ICustomerRepository
////{
////    private readonly ICustomerDataProvider _customerDataProvider;

////    public FileStorageCustomerRepository(ICustomerDataProvider customerDataProvider)
////    {
////        this._customerDataProvider = customerDataProvider;
////    }

////    public void AddCustomer(Customer customer)
////    {
////        throw new NotImplementedException();
////    }

////    public List<Customer> GetCustomers()
////    {
////        throw new NotImplementedException();
////    }
////}
