using FinalProject_2nd_edition.DataModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_2nd_edition.Models
{
    public class BookViewModel
    {
        public int BookId { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }
        public string PictureUrl { get; set; }

        
        public string Description { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<SelectListItem> AuthorList { get; set; }
        public ICollection<SelectListItem> GenreList { get; set; }
    }
}
