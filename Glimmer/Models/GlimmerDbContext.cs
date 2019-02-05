using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glimmer.Models
{
    public class GlimmerDbContext:DbContext
    {
        public GlimmerDbContext(DbContextOptions<GlimmerDbContext> dbContextOptions):base(dbContextOptions)
        {

        }

       
         
        public DbSet<Post> Posts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<PostCategory> PostCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostCategory>().HasKey(x => new { x.CategoryId, x.PostId });

            modelBuilder.Entity<PostCategory>().HasOne(x => x.Post).WithMany(x => x.PostCategories);

            modelBuilder.Entity<PostCategory>().HasOne(x => x.Category).WithMany(x => x.PostCategories);

            base.OnModelCreating(modelBuilder);
        }
    }
}
