using System.Collections.Generic;
using FinalProject_2nd_edition.DataModels;

namespace FinalProject_2nd_edition.Services
{
    public interface IGenreService
    {
        List<Genre> GetAll();

        public Genre GetById(int? id);

        public bool GenreExists(int id);

        void Add(Genre genre);
        void Update(Genre genre); 
        
        void Delete(Genre genre);

    }
}
