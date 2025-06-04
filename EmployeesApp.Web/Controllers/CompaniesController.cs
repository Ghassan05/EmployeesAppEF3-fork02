using EmployeesApp.Application.Companies.Interfaces;
using EmployeesApp.Application.Employees.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApp.Web.Controllers
{
    [Route("company")]
    public class CompaniesController(ICompanyService companyService) : Controller
    {
        [HttpGet("delete/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                await companyService.DeleteAsync(id);
                return Content($"Company deleted");
            }
            catch (Exception)
            {
                return Content($"Company not found");
            }
        }

    }
}
