using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FinalProject_2nd_edition.DataModels;

namespace FinalProject_2nd_edition.Models
{
    public class GenreViewModel
    {
        
        public int GenreId { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
        

        public ICollection<Author> Authors { get; set; }
    }
}
