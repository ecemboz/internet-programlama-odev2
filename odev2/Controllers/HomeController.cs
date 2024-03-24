using Microsoft.AspNetCore.Mvc;
using odev2.Models;
using System.Diagnostics;

namespace odev2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Listele", "Ogrenci");
        }

    }
}