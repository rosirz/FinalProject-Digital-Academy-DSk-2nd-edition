using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_2nd_edition.DataModels
{
    public class Author
    {
        public int AuthorId { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public string PictureUrl { get; set; }


        public string Details { get; set; }

        public ICollection<Book> Books { get; set; }



        public ICollection<AuthorGenres> AuthorGenres { get; set; }

    }
}
