using AutomationSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace AutomationSystem.Controllers
{
    public class OrderController : Controller
    {
        private readonly AutomationSystemContext _context;
        public OrderController(AutomationSystemContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Order()
        { 
            return View();
        }

    }
}
