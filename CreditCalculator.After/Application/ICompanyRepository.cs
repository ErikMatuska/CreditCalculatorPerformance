using CreditCalculator.After.Domain;

namespace CreditCalculator.After.Application
{
    public interface ICompanyRepository
    {
        Company GetById(int companyId);
    }
}