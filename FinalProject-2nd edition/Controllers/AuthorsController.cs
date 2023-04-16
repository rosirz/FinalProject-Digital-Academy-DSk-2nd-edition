﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject_2nd_edition.Data;
using FinalProject_2nd_edition.DataModels;
using FinalProject_2nd_edition.Services;
using FinalProject_2nd_edition.Models;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject_2nd_edition.Controllers
{
    [Authorize(Policy = "RequireAdministratorRole")]
    public class AuthorsController : Controller
    {
        private readonly IAuthorService authorService;

        public AuthorsController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        // GET: Authors
        [AllowAnonymous]
        public IActionResult Index()
        {
            var authors = this.authorService.GetAll();
            var model = new AuthorViewModel_List()
            {
                List = GetListofAuthorViewModel(authors)
            };
            return View(model);
        }

        // GET: Authors/Details/5
        [AllowAnonymous]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = this.authorService.GetById(id);
            var model = GetAuthorViewModel(author);
            if (author == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // GET: Authors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Authors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("AuthorId,Name,Details")] AuthorViewModel author)
        {
            if (ModelState.IsValid)
            {
                if (AuthorExists((GetAuthorDataModel(author).Name)))
                {
                    ModelState.AddModelError("name", "The author already exists");
                }
                else
                {
                    this.authorService.Add(GetAuthorDataModel(author));
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(author);
        }

        private bool AuthorExists(string name)
        {
            return this.authorService.AuthorExists(name);
        }

        // GET: Authors/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = this.authorService.GetById(id);
            var model = GetAuthorViewModel(author);
            if (author == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // POST: Authors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("AuthorId,Name,Details")] AuthorViewModel author)
        {
            if (id != author.AuthorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this.authorService.Update(GetAuthorDataModel(author));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuthorExists(author.AuthorId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

        // GET: Authors/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = this.authorService.GetById(id);
            var model = GetAuthorViewModel(author);
            if (author == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: Authors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var author = this.authorService.GetById(id);
            var model = GetAuthorViewModel(author);
            if (ModelState.IsValid)
            {
                if (CheckBooks(author) || author.AuthorGenres != null)
                {
                    ModelState.AddModelError("name", "You could not delete author if there are books or genres of this author");
                }
                else 
                {
                    this.authorService.Delete(author);
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(model);

        }

       

        private bool AuthorExists(int id)
        {
            return this.authorService.AuthorExists(id);

        }

        private Author GetAuthorDataModel(AuthorViewModel author)
        {
            return new Author
            {
                AuthorId = author.AuthorId,
                Name = author.Name,
                Details = author.Details
            };
        }

        private AuthorViewModel GetAuthorViewModel(Author a)
        {
            var model = new AuthorViewModel();
            model.AuthorId = a.AuthorId;
            model.Name = a.Name;
            model.Details = a.Details;
            if (CheckBooks(a))
            {
                var genres = new List<Genre>();
                foreach (var item in a.AuthorGenres)
                {
                    genres.Add(item.Genre);
                }

                model.Books = a.Books.ToList();
                model.Genres = genres;
            }
            else
            {
                model.Books = null;
                model.Genres = null;
            }
            return model;
        }
        private bool CheckBooks(Author a)
        {
            if (a.Books != null)
            {
                return true;
            }
            return false;
        }

        private IEnumerable<AuthorViewModel> GetListofAuthorViewModel(List<Author> sourse)
        {
            var authors = new List<AuthorViewModel>();
            foreach (var a in sourse)
            {
                authors.Add(GetAuthorViewModel(a));
            }
            return authors;
        }
    }
}
