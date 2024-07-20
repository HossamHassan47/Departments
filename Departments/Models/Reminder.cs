using Microsoft.EntityFrameworkCore;

namespace Departments.Models
{
    public class Reminder
    {
        public Reminder()
        {
            
        }
        public Reminder(int id, string title, DateTime reminderTime)
        {
            this.Id = id;  
            this.Title = title;
            this.ReminderTime = reminderTime;
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime ReminderTime { get; set; }
    }
}
