using Microsoft.AspNetCore.Mvc;
using Lab03.Models;

namespace Lab03.Controllers
{
    public class WorkshopsController : Controller
    {
        private static readonly List<Rsvp> registrations = new();

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

            registrations.Add(model);

            ViewData["Message"] = $"Thanks for registering, {model.FullName}!";

            return View(model);
        }

        [HttpGet]
        public IActionResult Registrations()
        {
            return View(registrations);
        }
    }
}
