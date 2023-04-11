using FinalProject_2nd_edition.DataModels;
using System.Collections.Generic;

namespace FinalProject_2nd_edition.Services
{
    public interface IAuthorService
    {
        List<Author> GetAll();

        public Author GetById(int? id);

        public bool AuthorExists(int id);

        public bool AuthorExists(string authorName);

        void Add(Author author);
        void Update(Author author);

        void Delete(Author author);
    }
}
