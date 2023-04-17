using System.Collections.Generic;

namespace FinalProject_2nd_edition.Models
{
    public class AuthorViewModel_List
    {
        public IEnumerable<AuthorViewModel> List { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }
    }
}
