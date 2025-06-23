using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        private AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            var products = db.Products.ToList(); // fetch from Oracle
            return View(products); // pass to view
        }
    }
}
