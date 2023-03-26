using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_2nd_edition.DataModels
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }



        public ICollection<AuthorGenres> AuthorGenres { get; set; }

    }
}
