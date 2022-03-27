using Microsoft.AspNetCore.Mvc;
using TreatFlavor.Models;
using System.Linq;

namespace TreatFlavor.Controllers
{
    public class HomeController : Controller
    {
      public readonly FlavorTreatContext _db;
    public HomeController(FlavorTreatContext db)
    {
      _db = db;
    }

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      public ActionResult Contact()
      {
        return View();
      }

      public ActionResult About()
      {
        return View();
      }
    public ActionResult Search(string Search)
    {
      var treats = _db.Treats.Where(treat => (treat.Name.Contains(Search) || (treat.Name == Search))).ToList();
      ViewBag.Treats = treats;
      return View();
    }
    }
}