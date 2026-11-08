using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab03.Data;
using Lab03.Models;

namespace Lab03.Controllers
{
    public class WorkshopsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WorkshopsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View(new Rsvp());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Confirm(Rsvp model)
        {
            if (!ModelState.IsValid)
            {
                return View("RsvpForm", model);
            }

            ViewData["Message"] = $"Thanks for registering, {model.FullName}!";

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Registrations()
        {
            var registrations = await _context.Rsvps
                .AsNoTracking()
                .ToListAsync();

            return View(registrations);
        }
    }
}
