namespace EmployeesApp.Application.Companies.Interfaces
{
    public interface ICompanyService
    {
        Task DeleteAsync(int companyId);
    }
}