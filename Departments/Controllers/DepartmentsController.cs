using Departments.Models;
using Microsoft.AspNetCore.Mvc;

namespace Departments.Controllers
{
    public class DepartmentsController (ApplicationDbContext dbContext) : Controller
    {
        private readonly ApplicationDbContext _dbContext = dbContext;

        public IActionResult Index()
        {
            List<Department> departments = _dbContext.Departments.ToList();


            return View(departments);
        }
    }
}
