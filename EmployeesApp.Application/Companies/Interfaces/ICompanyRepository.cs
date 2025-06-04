using EmployeesApp.Domain.Entities;

namespace EmployeesApp.Application.Companies.Interfaces
{
    public interface ICompanyRepository
    {
        Task<Company?> GetAsync(int companyId);
        void Remove(Company company);
    }
}