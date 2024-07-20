
using Departments.Models;

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

    //public class NotificationHandler(ApplicationDbContext dbContext) : INotificationHandler
    //{
    //    private readonly ApplicationDbContext _dbContext = dbContext;

    //    public async Task HandleNotificationsAsync()
    //    {
    //        // Check for scheduled reminders
    //        var reminders = _dbContext.Reminders.ToList();

    //        foreach (var reminder in reminders)
    //        {
    //            Console.WriteLine(string.Format("Send Reminder for Title: {0}, Time: {1}", reminder.Title, reminder.ReminderTime));

    //            // Logic to send email notifications.
    //        }
    //    }
    //}

    public class NotificationHandler: INotificationHandler
    {
        public async Task HandleNotificationsAsync()
        {
                Console.WriteLine("Send Reminders...");

                // Logic to send email notifications.
            
        }
    }
}
