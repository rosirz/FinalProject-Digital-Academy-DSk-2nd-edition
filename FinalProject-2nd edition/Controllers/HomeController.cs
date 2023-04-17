using FinalProject_2nd_edition.DataModels;
using FinalProject_2nd_edition.Models;
using FinalProject_2nd_edition.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_2nd_edition.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService bookService;

        public HomeController(ILogger<HomeController> logger, IBookService bookService)
        {
            _logger = logger;
            this.bookService = bookService;
        }

        public IActionResult Index()
        {
            var books = this.bookService.GetLastAdded();
            var model = new BookViewModel_List()
            {
                List = GetListofBooksViewModel(books),
                
            };
            return View(model);
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

        private BookViewModel GetBookViewModel(Book book)
        {
            var model = new BookViewModel()
            {
                BookId = book.BookId,
                Name = book.Name,
                PictureUrl = book.PictureUrl,
                Description = book.Description,
                AuthorId = book.AuthorId,
                Author = book.Author,
                GenreId = book.GenreId,
                Genre = book.Genre,
                AuthorList = book.AuthorList,
                GenreList = book.GenreList

            };
            return model;
        }
        private ICollection<BookViewModel> GetListofBooksViewModel(List<Book> sourse)
        {
            var books = new List<BookViewModel>();
            foreach (var g in sourse)
            {
                books.Add(GetBookViewModel(g));
            }
            return books;
        }
    }
}
