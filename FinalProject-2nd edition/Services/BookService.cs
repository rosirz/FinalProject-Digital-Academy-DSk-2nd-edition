using FinalProject_2nd_edition.Data;
using FinalProject_2nd_edition.DataModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject_2nd_edition.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext db;

        public BookService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void Add(Book book)
        {
            this.db.Books.Add(book);
            this.db.SaveChanges();
        }

        public void AddAuthor(Author author)
        {
            this.db.Authors.Add(author);
            this.db.SaveChanges();
        }

        public void AddBookInAuthor(Book book)
        {
            var author = this.db.Authors.FirstOrDefault(a => a.AuthorId == book.AuthorId);
            author.Books.Add(book);
            this.db.SaveChanges();
        }

        public void AddBookInGenre(Book book)
        {
            var genre = this.db.Genres.FirstOrDefault(g => g.GenreId == book.GenreId);
            genre.Books.Add(book);
            this.db.SaveChanges();
        }

        public void AddGenre(Genre genre)
        {
            this.db.Genres.Add(genre);
            this.db.SaveChanges();
        }

        public void AddInAuthorGenre(Book book)
        {
            var author = this.db.Authors.FirstOrDefault(a => a.AuthorId == book.AuthorId);
            var genre = this.db.Genres.FirstOrDefault(g => g.GenreId == book.GenreId);
            var source = new AuthorGenres()
            {
                AuthorId = author.AuthorId,
                GenreId = genre.GenreId,
                Author = author,
                Genre = genre
            };
            if (AuthorGenreExists(source))
            {
                return;
            }
            else
            {
                this.db.AuthorGenres.Add(source);
                this.db.SaveChanges();
            }

        }

        public bool AuthorGenreExists(AuthorGenres source)
        {
            if (this.db.AuthorGenres.Find(source.Author.AuthorId, source.Genre.GenreId) != null)
            {
                return true;
            }
            return false;
        }

        public bool BookExists(int id)
        {
            return this.db.Books.Any(b => b.BookId == id);
        }

        public bool BookExists(string bookName)
        {
            return this.db.Books.Any(b => b.Name == bookName);
        }

        public void Delete(Book book)
        {
            this.db.Books.Remove(book);
            this.db.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return this.db.Books
                .Include(x => x.Author)
                .Include(x => x.Genre)
                .OrderByDescending(x => x.GenreId)
                .ToList();
        }

        public Book GetById(int? id)
        {
            return this.db.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .FirstOrDefault(b => b.BookId == id);
        }

        public void Update(Book book)
        {
            this.db.Update(book);
            this.db.SaveChanges();
        }

        public IEnumerable<SelectListItem> CreateAuthorDropDownList()
        {
            var book = new Book();
            book.AuthorList = this.db.Authors
                                  .Select(a => new SelectListItem()
                                  {
                                      Value = a.AuthorId.ToString(),
                                      Text = a.Name
                                  })
                                  .ToList();

            return book.AuthorList;

        }
        public IEnumerable<SelectListItem> CreateGenreDropDownList()
        {
            var book = new Book();
            book.GenreList = this.db.Genres
                                  .Select(a => new SelectListItem()
                                  {
                                      Value = a.GenreId.ToString(),
                                      Text = a.Name
                                  })
                                          .ToList();
            return book.GenreList;
        }

       
    }
}
