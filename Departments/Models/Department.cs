using Microsoft.EntityFrameworkCore;

namespace Departments.Models
{
    public class Department
    {
        public Department(HierarchyId path, string name)
        {
            this.Path = path;  
            this.Name = name;
        }

        public int Id { get; set; }
        public required HierarchyId Path { get; set; }
        public required string Name { get; set; }
        public byte[]? Logo { get; set; }

    }
}
