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
        public List<CustomerDto> GetCustomers()
        {
            var customers = customerService.GetCustomers();
            var customerDtos = customers.Select(c => new CustomerDto(c.FirstName, c.LastName, c.Email, c.DateOfBirth, c.CompanyId)).ToList();
            return customerDtos;
        }

        public record CustomerInput(string FirstName, string LastName, string Email, DateTime DateOfBirth, int CompanyId);

        public record CustomerDto(string FirstName, string LastName, string Email, DateTime DateOfBirth, int CompanyId);
    }
}
