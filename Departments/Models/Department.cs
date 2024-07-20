using Microsoft.EntityFrameworkCore;

namespace Departments.Models
{
    public class Department
    {
        public Department(int id, HierarchyId path, string name)
        {
            this.Id = id;
            this.Path = path;  
            this.Name = name;
        }

        public int Id { get; set; }
        public HierarchyId Path { get; set; }
        public string Name { get; set; }
        public byte[]? Logo { get; set; }

    }
}
