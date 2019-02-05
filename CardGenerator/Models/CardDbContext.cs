using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGenerator.Models
{
    public class CardDbContext:DbContext
    {
        public CardDbContext(DbContextOptions<CardDbContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<License> Licenses { get; set; }

        public DbSet<Software> Softwares { get; set; }
        
    }
}
