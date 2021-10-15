using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);

            builder.Entity<Movie>(entity =>
            {
                entity.Property(r => r.Price).HasColumnType("decimal(18,2)");
               
            });
        }
        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
