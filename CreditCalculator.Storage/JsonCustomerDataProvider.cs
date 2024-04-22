using CreditCalculator.After.Domain;
using Newtonsoft.Json;

namespace CreditCalculator.Storage;

public class JsonCustomerDataProvider : ICustomerDataProvider
{
    public void AddCustomer(Customer customer)
    {
        throw new NotImplementedException();
    }

    public List<Customer> GetCustomers()
    {
        return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("customers.json"));
    }
}
