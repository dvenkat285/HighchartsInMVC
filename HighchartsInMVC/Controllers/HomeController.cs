using HighchartsInMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HighchartsInMVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(SalesDbContext context)
        {
            Context = context;
        }

        public SalesDbContext Context { get; }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetChartData()
        {
            var data = Context.Sales
                .OrderBy(s => s.Id)
                .Select(s => new
                {
                    Months = s.Months,
                    SalesAmount = s.SalesAmount
                })
                .ToList();

            return Json(data);
        }

    }
}

