using ProductApp.Models;
using System.Linq;
using System.Web.Mvc;

namespace ProductApp.Controllers
{
    public class EmployeeController : Controller
    {
        private AppDbContext db = new AppDbContext();

        public JsonResult GetEmployees()
        {
            var employees = db.Employees
                              .Select(e => new
                              {
                                  e.Id,
                                  e.Name,
                                  e.Salary,
                                  e.DepartmentId,
                                  DepartmentName = e.Department.DepartmentName
                              })
                              .ToList();

            return Json(employees, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            var employees = db.Employees.Include("Department").ToList();
            return View(employees); 
        }
    }
}
