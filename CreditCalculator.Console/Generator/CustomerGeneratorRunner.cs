using CreditCalculator.After.Domain;
using System.Text.Json;
using System.Xml.Serialization;

namespace CreditCalculator.Console.Generator
{
    public class CustomerGeneratorRunner
    {
        public void GenerateData()
        {
            // Generate and serialize customers to JSON
            File.WriteAllText("customers.json", JsonSerializer.Serialize(new CustomerGenerator().GenerateCustomers(10000)));

            // Generate and serialize customers to XML
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));
            using (StreamWriter streamWriter = new StreamWriter("customers.xml"))
            {
                xmlSerializer.Serialize(streamWriter, new CustomerGenerator().GenerateCustomers(10000));
            }
        }
    }
}
