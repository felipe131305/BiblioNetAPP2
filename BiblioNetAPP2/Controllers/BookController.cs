using BiblioNetAPP2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP2.Controllers
{
    public class BookController: Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }
            return View();
        }

    }
}
