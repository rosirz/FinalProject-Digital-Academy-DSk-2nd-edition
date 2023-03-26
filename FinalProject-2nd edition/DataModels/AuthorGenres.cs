namespace FinalProject_2nd_edition.DataModels
{
    public class AuthorGenres
    {
        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }

    }
}
