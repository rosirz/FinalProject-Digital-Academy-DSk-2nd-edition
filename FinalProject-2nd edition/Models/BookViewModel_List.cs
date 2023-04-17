using System.Collections.Generic;
using System.Linq;


namespace FinalProject_2nd_edition.Models
{
    public class BookViewModel_List
    {
        public ICollection<BookViewModel> List { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }
    }
}
