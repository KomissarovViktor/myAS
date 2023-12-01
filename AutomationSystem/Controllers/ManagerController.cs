using AutomationSystem.Areas.Identity.Data;
using AutomationSystem.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AutomationSystem.Controllers
{
    [Authorize(Roles ="Manager")]
    public class ManagerController : Controller
    {
        private readonly AutomationSystemContext _context;
        private readonly UserManager<AutomationSystemUser> _userManager;
        public ManagerController(AutomationSystemContext context, UserManager<AutomationSystemUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OrderManaging()
        {
            var filteredOrders2 = _context.Orders.ToList();

            ViewBag.Sum = _context.Orders.Sum(o => (double)o.Price);
            foreach (var order in filteredOrders2)
            {
                order.FixCategory = _context.FixCategories.FirstOrDefault(f => f.Id == order.FixCategoryId);
                order.Technik = _context.Techniks.FirstOrDefault(t => t.Id == order.TechnikId);
            }
            ViewBag.FixCategories= _context.FixCategories.ToList();
            return View(filteredOrders2);
        }
        public IActionResult CategoryManaging()
        {
            var categories = _context.FixCategories.ToList();
            return View(categories);
        }

    }
}
