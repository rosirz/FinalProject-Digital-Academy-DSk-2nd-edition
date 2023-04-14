using FinalProject_2nd_edition.Models;
using System;
using Xunit;

namespace FinalProject_2nd_editionTests
{
    public class ValidationTests
    {
        
        [Theory]
        [InlineData("")]
        [InlineData("ab")]
        [InlineData("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv")]
        public void Test_BookName_InvalidLength(string bookName)
        {
            var book = new BookViewModel();
            book.Name = bookName;
            Assert.False(book.Name.Length > 3 && book.Name.Length < 30);

        }

        [Theory]
        [InlineData("")]
        [InlineData("ab")]
        [InlineData("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv")]
        public void Test_AuthorName_InvalidLength(string authorName)
        {
            var author = new AuthorViewModel();
            author.Name = authorName;
            Assert.False(author.Name.Length > 3 && author.Name.Length < 30);
        }
        [Theory]
        [InlineData("")]
        [InlineData("ab")]
        [InlineData("vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv")]
        public void Test_GenreName_InvalidLength(string genreName)
        {
            var genre = new GenreViewModel();
            genre.Name = genreName;
            Assert.False(genre.Name.Length > 3 && genre.Name.Length < 30);
        }
    }
}
