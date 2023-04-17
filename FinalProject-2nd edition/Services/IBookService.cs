using FinalProject_2nd_edition.DataModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FinalProject_2nd_edition.Services
{
    public interface IBookService
    {
        public List<Book> GetAll(string searchString, int skip, int take);

        public List<Book> GetLastAdded();

        public Book GetById(int? id);

        public int GetCount();

        public bool BookExists(int id);

        public bool BookExists(string bookName);

        

        public bool AuthorGenreExists(AuthorGenres source);

        void Add(Book book);

        void AddBookInAuthor(Book book);

        void AddBookInGenre(Book book);

        void AddInAuthorGenre(Book book);

        void AddAuthor(Author author);

        void AddGenre(Genre genre);

        void Update(Book book);

        void Delete(Book book);

        public IEnumerable<SelectListItem> CreateAuthorDropDownList();

        public IEnumerable<SelectListItem> CreateGenreDropDownList();



    }
}
