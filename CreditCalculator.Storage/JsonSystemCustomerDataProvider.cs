using CreditCalculator.After.Domain;
using Newtonsoft.Json;

namespace CreditCalculator.Storage;

public class JsonSystemCustomerDataProvider : ICustomerDataProvider
{
    public void AddCustomer(Customer customer)
    {
        //// Sample code, should contain some error handling and result processing

        var current = GetCustomers();

        current.Add(customer);

        File.WriteAllText("customers.json", JsonConvert.SerializeObject(current));
    }

    public List<Customer> GetCustomers()
    {
        return System.Text.Json.JsonSerializer.Deserialize<List<Customer>>(File.ReadAllText("customers.json"));
    }
}
