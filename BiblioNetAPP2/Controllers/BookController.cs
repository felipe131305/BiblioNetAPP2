using BiblioNetAPP2.Models;
using BiblioNetAPP2.Services;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP2.Controllers
{
    public class BookController : Controller

    {
        private readonly IRepositorieBook repositorieBook;

        public BookController(IRepositorieBook repositorieBook)
        {
            this.repositorieBook = repositorieBook;
        }
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
            book.Description = "ejemplo";
            book.AuthorId = 1;
            book.pages = 20;
            book.publicationDate = "2022-03-22";
            book.RegisterDate = "2022-03-22";
            book.CategoryId = 1;
            repositorieBook.Create(book);
            return View();
        }

    }
}
