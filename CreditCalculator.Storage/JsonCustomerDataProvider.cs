using CreditCalculator.After.Domain;
using Newtonsoft.Json;

namespace CreditCalculator.Storage;

public class JsonCustomerDataProvider : ICustomerDataProvider
{
    public List<Customer> GetCustomers()
    {
        return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("customers.json"));
    }
}
