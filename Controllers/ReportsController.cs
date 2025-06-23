using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace ProductApp.Controllers
{
    public class ReportsController : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();

        public ActionResult Trends()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetDailyEmployeeTrend(string department = null, string role = null, string location = null)
        {
            DateTime startDate = DateTime.Today.AddDays(-29);

            var query = _context.Employees
                .Include(e => e.Department) 
                .Where(e => e.DateOfJoining >= startDate);

            if (!string.IsNullOrEmpty(department))
                query = query.Where(e => e.Department.Name == department); 

            if (!string.IsNullOrEmpty(role))
                query = query.Where(e => e.Role == role);

            if (!string.IsNullOrEmpty(location))
                query = query.Where(e => e.Location == location);

            var grouped = query
                .GroupBy(e => DbFunctions.TruncateTime(e.DateOfJoining))
                .Select(g => new
                {
                    Date = g.Key.Value.ToString("yyyy-MM-dd"),
                    Count = g.Count()
                })
                .ToList();

            var result = Enumerable.Range(0, 30).Select(i =>
            {
                var date = DateTime.Today.AddDays(-29 + i).ToString("yyyy-MM-dd");
                var match = grouped.FirstOrDefault(g => g.Date == date);
                return new { Date = date, Count = match?.Count ?? 0 };
            });

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetEmployeeFilters()
        {
            var departments = _context.Departments
                .Select(d => d.Name) 
                .Distinct()
                .ToList();

            var roles = _context.Employees
                .Select(e => e.Role)
                .Distinct()
                .ToList();

            var locations = _context.Employees
                .Select(e => e.Location)
                .Distinct()
                .ToList();

            return Json(new
            {
                Departments = departments,
                Roles = roles,
                Locations = locations
            }, JsonRequestBehavior.AllowGet);
        }
    }
}
