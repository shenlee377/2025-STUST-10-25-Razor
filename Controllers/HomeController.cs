using _2025_10_23.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _2025_10_23.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<MealType> mealtypes = new List<MealType>() {
        new MealType(1,"¦­À\"),
        new MealType(2,"¶W­È¥þÀ\"),
    };
            List<Meal> meals = new List<Meal>
    {
        new Meal(1,1,"½Þ¦×º¡ºÖ³ù¥[³J","b1.avif"),
        new Meal(2,1,"½Þ¦×º¡ºÖ³ù","b2.avif"),
        new Meal(3,1,"µL¼Ä½Þ¦×º¡ºÖ³ù¥[³J","b3.avif"),
        new Meal(4,1,"º¡ºÖ³ù","b4.avif"),
        new Meal(5,1,"«C½­º¡ºÖ³ù","b5.avif"),
        new Meal(6,1,"½Þ¦×³J³ù","b6.avif"),
        new Meal(1,2,"¤j³Á§J","b1.avif"),
        new Meal(2,2,"Âù¼h¤û¦×¦N¤h³ù","b2.avif"),
        new Meal(3,2,"¥|¯s¥q¤û¦×³ù","b3.avif"),
        new Meal(4,2,"Âù¼h¥|¯s¥q¤û¦×³ù","b4.avif"),
        new Meal(5,2,"³Á­»Âû","b5.avif"),
        new Meal(6,2,"Âù¼h³Á­»Âû","b6.avif"),
    };

            ViewBag.meals = meals;
            return View(mealtypes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
