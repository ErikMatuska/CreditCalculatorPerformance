using CreditCalculator.After.Application;
using Microsoft.AspNetCore.Mvc;

namespace CreditCalculator.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreditCalculatorController(CustomerService customerService) : ControllerBase
    {

        [HttpPost]
        public bool CreateCustomer(CustomerInput input) => customerService.AddCustomer(input.FirstName, input.LastName, input.Email, input.DateOfBirth, input.CompanyId);

        [HttpGet]
        public List<CustomerDto> GetCustomers(int page = 0, int size = 1000)
        {
            //// Paging should be done on the lowest level, eg. database, only for demo
            var customers = customerService.GetCustomers()
                .Skip(page * size)
                .Take(size);

            var customerDtos = customers.Select(c => new CustomerDto(c.FirstName, c.LastName, c.EmailAddress, c.DateOfBirth, c.Company.Id)).ToList();
            return customerDtos;
        }

        public record CustomerInput(string FirstName, string LastName, string Email, DateTime DateOfBirth, int CompanyId);

        public record CustomerDto(string FirstName, string LastName, string Email, DateTime DateOfBirth, int CompanyId);
    }
}
