using ProductApp.Models;
using System.Linq;
using System.Web.Mvc;

namespace ProductApp.Controllers
{
    public class ChartsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        public ActionResult BugFrequencyChart()
        {
            return View();
        }

        public JsonResult GetBugFrequencyData()
        {
            var data = db.SoftwareMetrics
                .GroupBy(m => m.BUG == 1 ? "Buggy" : "Clean")
                .Select(g => new
                {
                    Category = g.Key,
                    Count = g.Count()
                }).ToList();

            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ChartData1()
        {
            var data = db.SoftwareMetrics.ToList();
            var loc = data.Select(x => x.LOC).ToList();
            var bug = data.Select(x => x.BUG).ToList();
            return Json(new { loc, bug }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ChartData2()
        {
            var data = db.SoftwareMetrics.ToList();
            var rfc = data.Select(x => x.RFC).ToList();
            var cbo = data.Select(x => x.CBO).ToList();
            return Json(new { rfc, cbo }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ChartData3()
        {
            var data = db.SoftwareMetrics.ToList();
            var maxCc = data.Select(x => x.MAX_CC).ToList();
            var avgCc = data.Select(x => x.AVG_CC).ToList();
            return Json(new { maxCc, avgCc }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
