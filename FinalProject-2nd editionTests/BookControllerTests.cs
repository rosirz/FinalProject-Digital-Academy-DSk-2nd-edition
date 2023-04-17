using FinalProject_2nd_edition.Controllers;
using FinalProject_2nd_edition.DataModels;
using FinalProject_2nd_edition.Models;
using FinalProject_2nd_edition.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace FinalProject_2nd_editionTests
{
    public class BookControllerTests
    {

        private readonly Mock<IBookService> bookService;
        private readonly BooksController controller;
        public BookControllerTests()
        {
            bookService = new Mock<IBookService>();
            controller = new BooksController(bookService.Object);
        }

        [Fact]
        public void Test_Index_ReturnsViewForIndex()
        {
            int skip = 0;
            int take = 0;
            int page = 0;
            string searchString = "";
            bookService.Setup(bookService => bookService.GetAll(searchString, skip, take)).Returns
        (new List<Book>() { new Book(), new Book() });

            var result = controller.Index(searchString, page);
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Test_Index_ReturnsExactNunberOfBooks()
        {
            int skip = 0;
            int take = 0;
            int page = 0;
            string searchString = "";
            bookService.Setup(bookService => bookService.GetAll(searchString, skip, take)).Returns
                (new List<Book>() { new Book(), new Book() });


            var result = controller.Index( searchString, page);
            var viewresult = Assert.IsType<ViewResult>(result);
            var books = Assert.IsType<BookViewModel_List>(viewresult.Model);
            Assert.Equal(2, books.List.Count);
        }
        [Fact]
        public void Test_Create_ReturnsView_If_InvalidModelState()
        {
            controller.ModelState.AddModelError("name", "Name is required");

            var book = new BookViewModel()
            {
                Description = "Description",
                Author = new Author(),
                Genre = new Genre()
            };
            var result = controller.Create(book);
            var viewresult = Assert.IsType<ViewResult>(result);
            var testbook = Assert.IsType<BookViewModel>(viewresult.Model);
            Assert.Equal(book.Description, testbook.Description);
            Assert.Equal(book.Author, testbook.Author);
            Assert.Equal(book.Genre, testbook.Genre);
        }
        [Fact]
        public void Test_Create_NeverExecute_If_InvalidModelState()
        {
            controller.ModelState.AddModelError("name", "Name is required");

            var book = new BookViewModel()
            {
                Description = "Description",
                Author = new Author(),
                Genre = new Genre()
            };
            controller.Create(book);
            bookService.Verify(x => x.Add(It.IsAny<Book>()), Times.Never);
        }

        [Fact]
        public void Test_Create_ReturnsRedirectToActionIndex_If_ValidModelState()
        {
            var book = new BookViewModel()
            {
                Name = "Name",
                Description = "Description",
                Author = new Author(),
                Genre = new Genre()
            };
            var result = controller.Create(book);
            var viewresult = Assert.IsType<RedirectToActionResult>(result);
        }
        [Fact]
        public void Test_Create_ExecuteOnce_If_ValidModelState()
        {
            Book book = null;
            bookService.Setup(x => x.Add(It.IsAny<Book>()))
                .Callback<Book>(x => book = x);
            var testbook = new BookViewModel()
            {
                Name = "Name",
                Description = "Description",
                Author = new Author(),
                Genre = new Genre()
            };
            controller.Create(testbook);
            bookService.Verify(x => x.Add(It.IsAny<Book>()), Times.Once);
            Assert.Equal(book.Name, testbook.Name);
            Assert.Equal(book.Description, testbook.Description);
            Assert.Equal(book.Author, testbook.Author);
            Assert.Equal(book.Genre, testbook.Genre);

        }

        [Fact]
        public void Test_Edit_ReturnsView_If_InvalidModelState()
        {
            bookService.Setup(b => b.GetById(1)).Returns(new Book());

            controller.ModelState.AddModelError("name", "Name is required");

            var book = new BookViewModel()
            {
                BookId = 1,
                Description = "Description",

            };
            var result = controller.Edit(book.BookId);
            var viewresult = Assert.IsType<ViewResult>(result);
            var testbook = Assert.IsType<BookViewModel>(viewresult.Model);

        }

        [Fact]
        public void Test_Edit_NeverExecute_If_InvalidModelState()
        {
            bookService.Setup(b => b.GetById(1)).Returns(new Book());
            controller.ModelState.AddModelError("name", "Name is required");

            var book = new BookViewModel()
            {
                BookId = 1,
                Description = "Description",
                Author = new Author(),
                Genre = new Genre()
            };
            controller.Edit(book.BookId);
            bookService.Verify(x => x.Add(It.IsAny<Book>()), Times.Never);
        }
        [Fact]
        public void Test_Edit_ReturnsRedirectToActionIndex_If_ValidModelState()
        {
            bookService.Setup(b => b.GetById(1)).Returns(new Book());
            var book = new BookViewModel()
            {
                BookId = 1,
                Name = "Name",
                Description = "Description",

            };
            var result = controller.Edit(book.BookId, book);
            var viewresult = Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public void Test_Edit_ExecuteOnce_If_ValidModelState()
        {
            bookService.Setup(b => b.GetById(1)).Returns(new Book());
            Book book = null;
            bookService.Setup(x => x.Update(It.IsAny<Book>()))
                .Callback<Book>(x => book = x);
            var testbook = new BookViewModel()
            {
                BookId = 1,
                Name = "Name",
                Description = "Description",

            };
            controller.Edit(testbook.BookId, testbook);
            bookService.Verify(x => x.Update(It.IsAny<Book>()), Times.Once);


        }

        [Fact]
        public void Test_Delete_ReturnsRedirectToActionIndex_If_ValidModelState()
        {
            var book = new BookViewModel()
            {
                BookId = 1,
                Name = "Name",
                Description = "Description",

            };
            var result = controller.DeleteConfirmed(book.BookId);
            var viewresult = Assert.IsType<RedirectToActionResult>(result);
        }
    }
}
