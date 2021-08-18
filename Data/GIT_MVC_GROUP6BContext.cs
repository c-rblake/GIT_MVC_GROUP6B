using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GIT_MVC_GROUP6B.Models.Entities;

namespace GIT_MVC_GROUP6B.Data
{
    public class GIT_MVC_GROUP6BContext : DbContext
    {
        public GIT_MVC_GROUP6BContext (DbContextOptions<GIT_MVC_GROUP6BContext> options)
            : base(options)
        {
        }

        public DbSet<GIT_MVC_GROUP6B.Models.Entities.Thing1> Thing1 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Thing1>()
               .HasData(
                   new Thing1 { Id = 1, Name = "A", Age =1 },
                   new Thing1 { Id = 2, Name = "B", Age =2 },
                   new Thing1 { Id = 3, Name = "C", Age=3},
                   new Thing1 { Id = 4, Name = "D", Age = 4},
                   new Thing1 { Id = 5, Name = "E", Age = 5},
                   new Thing1 { Id = 6, Name = "F", Age = 6}
               );
        }
    }
}
