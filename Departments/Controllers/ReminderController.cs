using Departments.Models;
using Microsoft.AspNetCore.Mvc;

namespace Departments.Controllers
{
    public class ReminderController(ApplicationDbContext dbContext) : Controller
    {
        private readonly ApplicationDbContext _dbContext = dbContext;

        public IActionResult Index()
        {
            List<Reminder> reminders = _dbContext.Reminders.ToList();

            return View(reminders);
        }
    }
}
