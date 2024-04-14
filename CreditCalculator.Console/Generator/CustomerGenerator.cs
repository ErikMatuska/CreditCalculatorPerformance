using Bogus;
using CreditCalculator.After.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCalculator.Console.Generator
{

    public class CustomerGenerator
    {
        public List<Customer> GenerateCustomers(int count)
        {
            var faker = new Faker();
            var customers = new List<Customer>();

            for (int i = 0; i < count; i++)
            {
                var customer = new Customer
                {
                    FirstName = faker.Name.FirstName(),
                    LastName = faker.Name.LastName(),
                    EmailAddress = faker.Internet.Email(),
                    Company = new Company()
                    {
                        Id = faker.UniqueIndex,
                        Type = CompanyType.RegularClient
                    },
                    CreditLimit = faker.Random.Decimal(1000, 10000),
                    DateOfBirth = faker.Date.Past(30, DateTime.Now.AddYears(-21)),
                    HasCreditLimit = true
                };

                customers.Add(customer);
            }

            return customers;
        }
    }
}
