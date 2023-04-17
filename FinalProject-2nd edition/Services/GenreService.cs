using FinalProject_2nd_edition.Data;
using FinalProject_2nd_edition.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject_2nd_edition.Services
{
    public class GenreService : IGenreService

        
    {
        private readonly ApplicationDbContext db;

        public GenreService(ApplicationDbContext db)
        {
          this.db = db;      
        } 

        public void Add(Genre genre)
        {
            this.db.Genres.Add(genre);
            this.db.SaveChanges();
            
        }

        public void Delete(Genre genre)
        {
            this.db.Remove(genre);
            this.db.SaveChanges();
        }

        public List<Genre> GetAll(string searchString, int skip, int take)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                return this.db.Genres
                    .Where(g => g.Name.Contains(searchString))
                    .OrderBy(x => x.Name)
                    .Skip(skip)
                    .Take(take)
                    .ToList();
            }
            else
            {
                return this.db.Genres
                    .OrderBy(x => x.Name)
                    .Skip(skip)
                    .Take(take)
                    .ToList();
            }
        }

        public int GetCount() => this.db.Genres.Count();

        public Genre GetById(int? id)
        {
            return this.db.Genres
                .Include(x=>x.Books)
                .Include(x=>x.AuthorGenres)
                .ThenInclude(x=>x.Author)
                .FirstOrDefault(x => x.GenreId == id);
        }

        public void Update(Genre genre)
        {
            this.db.Update(genre);
            this.db.SaveChanges();
        }

        public bool GenreExists(int id)
        {
            return db.Genres.Any(e => e.GenreId == id);
        }

        public bool GenreExists(string genreName)
        {
            return db.Genres.Any(e => e.Name == genreName);
        }
    }
}
