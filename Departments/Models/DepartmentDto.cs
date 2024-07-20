namespace Departments.Models
{
    public class DepartmentDto
    {
        public Department Department { get; set; }

        public List<Department>? SubDepartments { get; set; }

        public List<Department>? ParentDepartments { get; set; }
    }
}
