using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            Home Home1 = new Home();
            Home1.Name = "Akia";
            Home1.Regno = 218012130;
            return View(Home1);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Home home)
        {
            if (ModelState.IsValid)
            {
                return Content("success");
            }
            else
            {
                return View(home);
            }
        }
    }
}