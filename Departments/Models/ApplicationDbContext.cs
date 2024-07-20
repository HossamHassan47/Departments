using Microsoft.EntityFrameworkCore;

namespace Departments.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Reminder> Reminders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department(1, HierarchyId.Parse("/"), "Root Department"),
                new Department(2, HierarchyId.Parse("/1/"), "Department 01"),
                new Department(3, HierarchyId.Parse("/2/"), "Department 02"),
                new Department(4, HierarchyId.Parse("/3/"), "Department 03"),
                new Department(5, HierarchyId.Parse("/4/"), "Department 04"),
                new Department(6, HierarchyId.Parse("/5/"), "Department 05"),
                new Department(7, HierarchyId.Parse("/1/1/"), "Department 06"),
                new Department(8, HierarchyId.Parse("/1/2/"), "Department 07"),
                new Department(9, HierarchyId.Parse("/1/3/"), "Department 08"),
                new Department(10, HierarchyId.Parse("/1/4/"), "Department 09"),
                new Department(11, HierarchyId.Parse("/1/5/"), "Department 10"),
                new Department(12, HierarchyId.Parse("/3/1/"), "Department 11"),
                new Department(13, HierarchyId.Parse("/3/2/"), "Department 12"),
                new Department(14, HierarchyId.Parse("/4/1/"), "Department 13"),
                new Department(15, HierarchyId.Parse("/1/1/1/"), "Department 14"),
                new Department(16, HierarchyId.Parse("/1/3/1/"), "Department 15"),
                new Department(17, HierarchyId.Parse("/1/5/1/"), "Department 16"),
                new Department(18, HierarchyId.Parse("/3/2/1/"), "Department 17"),
                new Department(19,HierarchyId.Parse("/3/2/2/"), "Department 18"),
                new Department(20,HierarchyId.Parse("/4/1/1/"), "Department 19"),
                new Department(21,HierarchyId.Parse("/4/1/2/"), "Department 20"),
                new Department(22,HierarchyId.Parse("/4/1/3/"), "Department 21"),
                new Department(23,HierarchyId.Parse("/1/3/1/1/"), "Department 22"),
                new Department(24,HierarchyId.Parse("/1/5/1/1/"), "Department 23"),
                new Department(25,HierarchyId.Parse("/3/2/1/1/"), "Department 24"),
                new Department(26,HierarchyId.Parse("/3/2/1/2/"), "Department 25"),
                new Department(27,HierarchyId.Parse("/3/2/1/3/"), "Department 26"),
                new Department(28,HierarchyId.Parse("/4/1/2/1/"), "Department 27"),
                new Department(29,HierarchyId.Parse("/4/1/3/1/"), "Department 28"),
                new Department(30, HierarchyId.Parse("/3/2/1/1/1/"), "Department 29")
                );
        }
    }
}
