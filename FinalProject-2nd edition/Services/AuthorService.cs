using FinalProject_2nd_edition.Data;
using FinalProject_2nd_edition.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject_2nd_edition.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly ApplicationDbContext db;

        public AuthorService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void Add(Author author)
        {
            this.db.Add(author);
            this.db.SaveChanges();
;        }

        public bool AuthorExists(int id)
        {
            return db.Authors.Any(x => x.AuthorId == id);
        }

        public bool AuthorExists(string authorName)
        {
            return db.Authors.Any(x => x.Name == authorName);
        }

        public void Delete(Author author)
        {
            this.db.Remove(author);
            this.db.SaveChanges();
        }

        public List<Author> GetAll(string searchString, int skip, int take)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                return (List<Author>)this.db.Authors
                    .Where(a => a.Name.Contains(searchString))
                    .OrderBy(x => x.Name)
                    .Skip(skip)
                    .Take(take)
                    .ToList();
            }
            else
            {
                return this.db.Authors
                        .OrderBy(x => x.Name)
                        .Skip(skip)
                        .Take(take)
                        .ToList();
            }
        }

        public int GetCount() => this.db.Authors.Count();
        public Author GetById(int? id)
        {
            return this.db.Authors
                .Include(x => x.Books)
                .Include(x => x.AuthorGenres)
                .ThenInclude(x => x.Genre)
                .FirstOrDefault(x => x.AuthorId == id);
        }

        public void Update(Author author)
        {
            this.db.Update(author);
            this.db.SaveChanges();
        }
    }
}
