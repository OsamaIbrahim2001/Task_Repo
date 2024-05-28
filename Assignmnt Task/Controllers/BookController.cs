using Assignmnt_Task.Models;
using Assignmnt_Task.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace Assignmnt_Task.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationContext _context;
        public BookController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Book> books = _context.Books.ToList();
            return View(books);
        }
        public  ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }
    }
}
