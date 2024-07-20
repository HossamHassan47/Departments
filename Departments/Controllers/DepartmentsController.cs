using Departments.Models;
using Microsoft.AspNetCore.Mvc;

namespace Departments.Controllers
{
    public class DepartmentsController(ApplicationDbContext dbContext) : Controller
    {
        private readonly ApplicationDbContext _dbContext = dbContext;

        public IActionResult Index()
        {
            List<Department> departments = _dbContext.Departments.ToList();

            return View(departments);
        }

        public IActionResult Details(int? id)
        {
            Department? department = _dbContext.Departments.Find(id);

            if (id == null || id == 0 || department == null)
            {
                return NotFound();
            }

            // Get Sub Departments
            List<Department> subDepartments = this.FindSubDepartments(id).ToList();

            // Get Parent Departments
            List<Department> parentDepartments = this.FindParentDepartments(id).ToList();

            // Prepare View Model
            DepartmentDto departmentDto = new DepartmentDto
            {
                Department = department,
                SubDepartments = subDepartments,
                ParentDepartments = parentDepartments
            };

            return View(departmentDto);
        }

        private IQueryable<Department> FindSubDepartments(int? id)
        {
            return _dbContext.Departments.Where(
                descendent => descendent.Path.GetAncestor(1) == _dbContext.Departments.Single(ancestor => ancestor.Id == id).Path);
        }

        private IQueryable<Department> FindParentDepartments(int? id)
        {
            return _dbContext.Departments.Where(
                ancestor => _dbContext.Departments
                    .Single(
                        descendent =>
                            descendent.Id == id
                            && ancestor.Id != descendent.Id)
                    .Path.IsDescendantOf(ancestor.Path))
                .OrderByDescending(ancestor => ancestor.Path.GetLevel());
        }
    }
}
