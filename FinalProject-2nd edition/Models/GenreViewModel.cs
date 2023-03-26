using System.Collections.Generic;
using FinalProject_2nd_edition.DataModels;

namespace FinalProject_2nd_edition.Models
{
    public class GenreViewModel
    {
        
        public int GenreId { get; set; }

        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
        

        public ICollection<Author> Authors { get; set; }
    }
}
