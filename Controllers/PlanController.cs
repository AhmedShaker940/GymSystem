using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC02.Contexts;

namespace MVC02.Controllers
{
    public class PlanController : Controller
    {
        //Database Connection
        private GymDbContext context = new GymDbContext();
        public IActionResult IndexTest()
        {
            return View();
        }
        public async Task<IActionResult> Index()
        {
            var palns =  await context.Plans.ToListAsync();
            return View(palns);
        }
    }
}
