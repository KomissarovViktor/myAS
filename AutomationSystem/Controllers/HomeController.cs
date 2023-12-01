using AutomationSystem.Areas.Identity.Data;
using AutomationSystem.Data;
using AutomationSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AutomationSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AutomationSystemContext _context;

        public HomeController(ILogger<HomeController> logger, AutomationSystemContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Categories()
        {
            var Categories = _context.FixCategories.ToList();
            IQueryable<Order> filteredOrders2 = from a in _context.Orders where a.Price >500 select a;
            var filteredOrders = _context.Orders.Where(order => order.Price>500).OrderBy(n => n);
            IQueryable < FixCategory > categories2= from a in _context.FixCategories where a.Id > 1 select a;
            return View(Categories);
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