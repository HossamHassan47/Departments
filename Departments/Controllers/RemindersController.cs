using Departments.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Departments.Controllers
{
    public class RemindersController(ApplicationDbContext dbContext) : Controller
    {
        private readonly ApplicationDbContext _dbContext = dbContext;

        // GET: RemindersController
        public ActionResult Index()
        {
            List<Reminder> reminders = _dbContext.Reminders.ToList();

            return View(reminders);
        }

        // GET: RemindersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RemindersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RemindersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RemindersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RemindersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RemindersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RemindersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
