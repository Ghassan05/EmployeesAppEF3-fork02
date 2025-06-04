using EmployeesApp.Application.Companies.Interfaces;
using EmployeesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Application.Companies.Services
{
    public class CompanyService(IUnitOfWork unitOfWork) : ICompanyService
    {
        public async Task DeleteAsync(int companyId)
        {
            var company = await unitOfWork.Companies.GetAsync(companyId) ??
                throw new Exception($"No company found with id: {companyId}");

            foreach (var employee in company.Employees)
                unitOfWork.Employees.Remove(employee);

            unitOfWork.Companies.Remove(company);
            await unitOfWork.PersistAllAsync();
        }
    }
}
