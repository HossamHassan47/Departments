using Departments.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public ActionResult Details(int? id)
        {
            Reminder? reminder = _dbContext.Reminders.Find(id);

            if (id == null || id == 0 || reminder == null)
            {
                return NotFound();
            }

            return View(reminder);
        }

        // GET: RemindersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RemindersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Reminder reminder)
        {
            try
            {
                _dbContext.Reminders.Add(reminder);
                _dbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RemindersController/Edit/5
        public ActionResult Edit(int? id)
        {
            Reminder? reminder = _dbContext.Reminders.Find(id);

            if (id == null || id == 0 || reminder == null)
            {
                return NotFound();
            }

            return View(reminder);
        }

        // POST: RemindersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, Reminder reminder)
        {
            try
            {
                Reminder? _reminder = _dbContext.Reminders.Find(id);

                if (id == null || id == 0 || _reminder == null)
                {
                    return NotFound();
                }

                _reminder.Title= reminder.Title;
                _reminder.ReminderTime = reminder.ReminderTime;

                _dbContext.Reminders.Update(_reminder);
                _dbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RemindersController/Delete/5
        public ActionResult Delete(int? id)
        {
            Reminder? reminder = _dbContext.Reminders.Find(id);

            if (id == null || id == 0 || reminder == null)
            {
                return NotFound();
            }

            return View(reminder);
        }

        // POST: RemindersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int? id, Reminder reminder)
        {
            try
            {
                Reminder? _reminder = _dbContext.Reminders.Find(id);

                if (id == null || id == 0 || _reminder == null)
                {
                    return NotFound();
                }

                _reminder.Title = reminder.Title;
                _reminder.ReminderTime = reminder.ReminderTime;

                _dbContext.Reminders.Remove(_reminder);
                _dbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
