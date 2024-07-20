using Microsoft.AspNetCore.Mvc;

namespace Departments.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
