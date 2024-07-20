
using Departments.Models;
using Microsoft.EntityFrameworkCore;

namespace Departments.Services
{
    public class NotificationService : BackgroundService
    {
        private readonly INotificationHandler _notificationHandler;

        public NotificationService(INotificationHandler notificationHandler)
        {
            _notificationHandler = notificationHandler;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await _notificationHandler.HandleNotificationsAsync();

                // Send notifications each minute
                await Task.Delay(TimeSpan.FromMinutes(1));
            }
        }
    }

    public interface INotificationHandler
    {
        Task HandleNotificationsAsync();
    }

    public class NotificationHandler : INotificationHandler
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public NotificationHandler(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        public async Task HandleNotificationsAsync()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Send Reminders Started at " + DateTime.Now);

            using IServiceScope scope = _scopeFactory.CreateScope();
            ApplicationDbContext _dbContext = scope.ServiceProvider.GetService<ApplicationDbContext>();

            // Check for scheduled reminders
            var _now = DateTime.Now;

            var reminders = _dbContext.Reminders
                .Where(r =>
                    r.ReminderTime.Date == _now.Date && // Same Date
                    r.ReminderTime.Hour == _now.Hour && // Same Hour
                    r.ReminderTime.Minute == _now.Minute // Same Minute
                    ).ToList();

            foreach (var reminder in reminders)
            {
                Console.WriteLine(string.Format("Reminder sent for Title: {0}, Time: {1}", reminder.Title, reminder.ReminderTime));

                // Logic to send email notifications.
            }

            Console.WriteLine("Send Reminders Ended");
        }
    }
}
