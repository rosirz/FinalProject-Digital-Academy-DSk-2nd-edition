using FinalProject_2nd_edition.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_2nd_edition.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<AuthorGenres> AuthorGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author);

            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Books)
                .WithOne(b => b.Genre);

            modelBuilder.Entity<AuthorGenres>().HasKey(pk => new { pk.AuthorId, pk.GenreId });

            modelBuilder.Entity<AuthorGenres>()
                .HasOne(x => x.Author)
                .WithMany(x => x.AuthorGenres)
                .HasForeignKey(x => x.AuthorId);

            modelBuilder.Entity<AuthorGenres>()
                .HasOne(x => x.Genre)
                .WithMany(x => x.AuthorGenres)
                .HasForeignKey(x => x.GenreId);
        }

    }
}
