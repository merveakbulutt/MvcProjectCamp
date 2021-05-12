using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class StatisticsController : Controller
    {
        Context c = new Context();

        public ActionResult Index()
        {
            var query1 = c.Categories.Count().ToString();
            ViewBag.q1 = query1;

            var query2=c.Headings.Count(x => x.HeadingName == "Yazılım").ToString();
            ViewBag.q2 = query2;

            var query3 = c.Writers.Count(x => x.WriterName.Contains("a"));
            ViewBag.q3 = query3;

            var query4 = c.Categories.Where(u => u.CategoryId == (c.Headings.GroupBy(x => x.CategoryId)
           .OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault())).Select(k => k.CategoryName).FirstOrDefault();
            ViewBag.q4 = query4;

            var query5 = c.Categories.Count(x => x.CategoryStatus == true) - c.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.q5 = query5;

            return View();
        }
    }
}