using System.Web.Mvc;
using System.Linq;
using ProductApp.Models; 

namespace ProductApp.Controllers 
{
    public class MetricsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        public ActionResult TestData()
        {
            return Content("Everything is working!");
        }
        public ActionResult BugSummary()
        {
            var bugCount = db.SoftwareMetrics.Count(m => m.BUG == 1);
            var noBugCount = db.SoftwareMetrics.Count(m => m.BUG == 0);

            return Json(new { bug = bugCount, no_bug = noBugCount }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult BugPie()
        {
            return View();
        }

    }
}
