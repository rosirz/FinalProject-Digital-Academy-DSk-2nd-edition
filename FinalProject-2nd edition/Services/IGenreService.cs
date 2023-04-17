using System.Collections.Generic;
using FinalProject_2nd_edition.DataModels;

namespace FinalProject_2nd_edition.Services
{
    public interface IGenreService
    {
        List<Genre> GetAll(string searchString, int skip, int take);

        public Genre GetById(int? id);

        public int GetCount();

        public bool GenreExists(int id);

        public bool GenreExists(string genreName);

        void Add(Genre genre);
        void Update(Genre genre); 
        
        void Delete(Genre genre);

    }
}
