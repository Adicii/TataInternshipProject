using System.Linq;
using System.Web.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    public class SoftwareMetricsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            var metrics = db.SoftwareMetrics.ToList();
            return View(metrics);
        }
    }
}
