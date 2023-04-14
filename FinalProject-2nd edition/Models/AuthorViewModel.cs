using FinalProject_2nd_edition.DataModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_2nd_edition.Models
{
    public class AuthorViewModel
    {
        public int AuthorId { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [StringLength(300)]
        public string Details { get; set; }

        public ICollection<Book> Books { get; set; }


        public ICollection<Genre> Genres { get; set; }
    }
}
