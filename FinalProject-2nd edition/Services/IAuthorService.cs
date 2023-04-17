using FinalProject_2nd_edition.DataModels;
using System.Collections.Generic;

namespace FinalProject_2nd_edition.Services
{
    public interface IAuthorService
    {
        List<Author> GetAll(string searchString, int skip, int take);

        public Author GetById(int? id);
        public int GetCount();

        public bool AuthorExists(int id);

        public bool AuthorExists(string authorName);

        void Add(Author author);
        void Update(Author author);

        void Delete(Author author);
    }
}
