namespace NotAlmaUygulamasi.Controllers
{
    using global::NotAlmaUygulamasi.Data;
    using global::NotAlmaUygulamasi.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    namespace NotAlmaUygulamasi.Controllers
    {
        public class NotesController : Controller
        {
            private readonly ApplicationDbContext _context;

            public NotesController(ApplicationDbContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
                var notes = _context.Notes.ToList();
                return View(notes);
            }

            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Create(Note note)
            {
                if (ModelState.IsValid)
                {
                    _context.Notes.Add(note);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(note);
            }
        }
    }

}
