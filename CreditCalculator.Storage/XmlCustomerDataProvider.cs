using CreditCalculator.After.Domain;
using System.Xml.Serialization;

namespace CreditCalculator.Storage
{
    public class XmlCustomerDataProvider : ICustomerDataProvider
    {
        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            // Specify the path to the XML file
            string filePath = "customers.xml";

            // Create an instance of XmlSerializer for the Customer type
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

            // Read the XML file using File.ReadAllText
            var xmlData = File.ReadAllText(filePath);

            // Create a StringReader to read the XML data
            using (StringReader stringReader = new StringReader(xmlData))
            {
                // Deserialize the XML data into a List<Customer> object
                customers = (List<Customer>)serializer.Deserialize(stringReader);
            }

            return customers;
        }
    }
}
