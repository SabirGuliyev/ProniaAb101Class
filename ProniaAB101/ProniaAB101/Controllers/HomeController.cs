using Microsoft.AspNetCore.Mvc;
using ProniaAB101.DAL;

namespace ProniaAB101.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
    }
}
