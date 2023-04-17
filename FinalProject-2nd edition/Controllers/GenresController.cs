using System;
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
    public class GenresController : Controller
    {
        private readonly IGenreService genreService;

        public GenresController(IGenreService genreService)
        {
            this.genreService = genreService;
        }

        // GET: Genres
        [AllowAnonymous]
        public IActionResult Index(string searchString, int currentPage = 1)
        {
            var skip = (currentPage - 1) * 3;
            var take = 3;
            var genres = this.genreService.GetAll(searchString, skip, take);
            var totalGenres = this.genreService.GetCount();

            var totalPages = totalGenres / 3;
            if (totalGenres % 3 > 0)
            {
                totalPages++;
            }

            var model = new GenreViewModel_List()
            {
                List = GetListofGenresViewModel(genres),
                CurrentPage = currentPage,
                TotalPages = totalPages
            };
            return View(model);
        }

        // GET: Genres/Details/5
        [AllowAnonymous]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = this.genreService.GetById(id);
            var model = GetGenreViewModel(genre);

            if (genre == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // GET: Genres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Genres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("GenreId,Name")] GenreViewModel genre)
        {
            if (ModelState.IsValid)
            {
                if (GenreExists(GetGenreDataModel(genre).Name))
                {
                    ModelState.AddModelError("name", "The genre already exists");
                }
                else
                {
                    this.genreService.Add(GetGenreDataModel(genre));

                    return RedirectToAction(nameof(Index));
                }
            }
            return View(genre);
        }

        // GET: Genres/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = this.genreService.GetById(id);
            var model = GetGenreViewModel(genre);
            if (genre == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // POST: Genres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("GenreId,Name")] GenreViewModel genre)
        {
            if (id != genre.GenreId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this.genreService.Update(GetGenreDataModel(genre));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenreExists(genre.GenreId))
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
            return View(genre);
        }

        // GET: Genres/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = this.genreService.GetById(id);
            var model = GetGenreViewModel(genre);
            if (genre == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            
                var genre = this.genreService.GetById(id);
                var model = GetGenreViewModel(genre);
            if (ModelState.IsValid)
            {
                if (CheckBooks(genre) || genre.AuthorGenres != null)
                {
                    ModelState.AddModelError("name", "You could not delete genre if there are books or authors of this genre");
                    
                }
                
                else
                {
                    this.genreService.Delete(genre);
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(model);
        }
       

        private bool GenreExists(int id)
        {
            return this.genreService.GenreExists(id);

        }

        private bool GenreExists(string name)
        {
            return this.genreService.GenreExists(name);

        }

        private Genre GetGenreDataModel(GenreViewModel genre)
        {
            return new Genre
            {
                GenreId = genre.GenreId,
                Name = genre.Name
            };
        }

        private GenreViewModel GetGenreViewModel(Genre g)
        {
            var model = new GenreViewModel();
            model.GenreId = g.GenreId;
            model.Name = g.Name;
            if (CheckBooks(g))
            {
                var authors = new List<Author>();
                foreach (var item in g.AuthorGenres)
                {
                    authors.Add(item.Author);
                }

                model.Books = g.Books.ToList();
                model.Authors = authors;
            }
            else
            {
                model.Books = null;
                model.Authors = null;
            }
            return model;
        }
        private bool CheckBooks(Genre g)
        {
            if (g.Books != null)
            {
                return true;
            }
            return false;
        }


        private IEnumerable<GenreViewModel> GetListofGenresViewModel(List<Genre> sourse)
        {
            var genres = new List<GenreViewModel>();
            foreach (var g in sourse)
            {
                genres.Add(GetGenreViewModel(g));
            }
            return genres;
        }

    }


}
