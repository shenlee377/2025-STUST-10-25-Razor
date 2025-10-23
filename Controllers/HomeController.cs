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
        new MealType(1,"���\"),
        new MealType(2,"�W�ȥ��\"),
    };
            List<Meal> meals = new List<Meal>
    {
        new Meal(1,1,"�ަ׺��ֳ��[�J","b1.avif"),
        new Meal(2,1,"�ަ׺��ֳ�","b2.avif"),
        new Meal(3,1,"�L�Ľަ׺��ֳ��[�J","b3.avif"),
        new Meal(4,1,"���ֳ�","b4.avif"),
        new Meal(5,1,"�C�����ֳ�","b5.avif"),
        new Meal(6,1,"�ަ׳J��","b6.avif"),
        new Meal(1,2,"�j���J","b1.avif"),
        new Meal(2,2,"���h���צN�h��","b2.avif"),
        new Meal(3,2,"�|�s�q���׳�","b3.avif"),
        new Meal(4,2,"���h�|�s�q���׳�","b4.avif"),
        new Meal(5,2,"������","b5.avif"),
        new Meal(6,2,"���h������","b6.avif"),
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
