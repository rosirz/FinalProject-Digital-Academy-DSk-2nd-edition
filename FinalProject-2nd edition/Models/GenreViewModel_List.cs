using System.Collections.Generic;

namespace FinalProject_2nd_edition.Models
{
    public class GenreViewModel_List
    {
        public IEnumerable<GenreViewModel> List { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }
    }
}
