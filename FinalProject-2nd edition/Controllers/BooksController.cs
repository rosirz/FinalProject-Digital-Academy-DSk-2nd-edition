using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject_2nd_edition.Data;
using FinalProject_2nd_edition.DataModels;
using FinalProject_2nd_edition.Services;
using FinalProject_2nd_edition.Models;

namespace FinalProject_2nd_edition.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService bookService;

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        // GET: Books
        public IActionResult Index()
        {
            var books = this.bookService.GetAll();
            var model = new BookViewModel_List()
            {
                List = GetListofBooksViewModel(books)
            };
            return View(model);
        }

        // GET: Books/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = this.bookService.GetById(id);
            var model = GetBookViewModel(book);
            if (book == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            var book = new Book();
            book.AuthorList = (ICollection<SelectListItem>)this.bookService.CreateAuthorDropDownList();
            book.GenreList = (ICollection<SelectListItem>)this.bookService.CreateGenreDropDownList();
            var model = GetBookViewModel(book);
            return View(model);
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("BookId,Name,Description,GenreId,AuthorId")] BookViewModel book)
        {
            if (ModelState.IsValid)
            {
                var bookToAdd = GetBookDataModel(book);
                if (BookExists(bookToAdd.Name))
                {
                    ModelState.AddModelError("name", "The book already exists");
                }
                //var bookToAdd = GetBookDataModel(book);
                else
                {
                    this.bookService.Add(bookToAdd);
                    this.bookService.AddBookInAuthor(bookToAdd);
                    this.bookService.AddBookInGenre(bookToAdd);
                    this.bookService.AddInAuthorGenre(bookToAdd);

                    return RedirectToAction(nameof(Index));
                }
            }
            
            return View(book);
        }
        public ActionResult AddAuthor(string authorName, string authorDescription)
        {
            var author = new Author();
            author.Name = authorName;
            author.Details = authorDescription;
            this.bookService.AddAuthor(author);
            var id = author.AuthorId;
            return Ok(new
            {
                Id = id,
                Name = authorName,
            });
        }

        public IActionResult AddGenre(string genreName)
        {
            var genre = new Genre();
            genre.Name = genreName;
            this.bookService.AddGenre(genre);
            var id = genre.GenreId;
            return Ok(new
            {
                Id = id,
                Name = genreName,
            });
        }

        // GET: Books/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = this.bookService.GetById(id);
            book.AuthorList = (ICollection<SelectListItem>)this.bookService.CreateAuthorDropDownList();
            book.GenreList = (ICollection<SelectListItem>)this.bookService.CreateGenreDropDownList();
            var model = GetBookViewModel(book);

            if (book == null)
            {
                return NotFound();
            }
           
            return View(model);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("BookId,Name,Description,GenreId,AuthorId")] BookViewModel book)
        {
            if (id != book.BookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this.bookService.Update(GetBookDataModel(book));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
           
            return View(book);
        }

        // GET: Books/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = this.bookService.GetById(id);
            var model = GetBookViewModel(book);
            if (book == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = this.bookService.GetById(id);
            this.bookService.Delete(book);
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return this.bookService.BookExists(id);
        }

        private bool BookExists(string bookName)
        {
            return this.bookService.BookExists(bookName);
        }

        private Book GetBookDataModel (BookViewModel book)
        {
            return new Book
            {
                BookId = book.BookId,
                Name = book.Name,
                Description = book.Description,
                AuthorId = book.AuthorId,
                Author = book.Author,
                GenreId = book.GenreId,
                Genre = book.Genre,
                AuthorList = book.AuthorList,
                GenreList = book.GenreList

            };
        }
        
        private BookViewModel GetBookViewModel(Book book)
        {
            var model = new BookViewModel()
            {
                BookId = book.BookId,
                Name = book.Name,
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
