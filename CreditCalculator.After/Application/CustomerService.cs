using CreditCalculator.After.Domain;
using CreditCalculator.After.Infrastructure;
using RegistR.Attributes.Base;

namespace CreditCalculator.After.Application;

[Register]
public class CustomerService(
    ICompanyRepository companyRepository,
    ICustomerRepository customerRepository,
    ICalculator creditLimitCalculator,
    IDateTimeProvider dateTimeProvider)
{
    public bool AddCustomer(
        string firstName,
        string lastName,
        string email,
        DateTime dateOfBirth,
        int companyId)
    {
        if (!IsValid(firstName, lastName, email, dateOfBirth, dateTimeProvider))
        {
            return false;
        }

        var company = companyRepository.GetById(companyId);

        var customer = new Customer
        {
            Company = company,
            DateOfBirth = dateOfBirth,
            EmailAddress = email,
            FirstName = firstName,
            LastName = lastName
        };

        (customer.HasCreditLimit, customer.CreditLimit) = creditLimitCalculator.Calculate(company, customer);

        if (customer.IsUnderCreditLimit())
        {
            return false;
        }

        customerRepository.AddCustomer(customer);

        return true;
    }

    private static bool IsValid(string firstName, string lastName, string email, DateTime dateOfBirth, IDateTimeProvider dateTimeProvider)
    {
        const int minimumAge = 21;

        return !string.IsNullOrEmpty(firstName) &&
               !string.IsNullOrEmpty(lastName) &&
               email.Contains('@') &&
               email.Contains('.') &&
               CalculateAge(dateOfBirth, dateTimeProvider.Now) >= minimumAge;
    }

    private static int CalculateAge(DateTime dateOfBirth, DateTime now)
    {
        var age = now.Year - dateOfBirth.Year;
        if (dateOfBirth.Date > now.AddYears(-age))
            age--;

        return age;
    }
}