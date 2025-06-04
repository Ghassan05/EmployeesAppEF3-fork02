using EmployeesApp.Application.Companies.Interfaces;
using EmployeesApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeesApp.Infrastructure.Persistance.Repositories
{
    public class CompanyRepository(ApplicationContext context) : ICompanyRepository
    {
        public async Task<Company?> GetAsync(int companyId) =>
            await context.Companies
            .Include(c => c.Employees)
            .SingleAsync(c => c.Id == companyId);

        public void Remove(Company company)
        {
            context.Companies.Remove(company);
        }
    }
}