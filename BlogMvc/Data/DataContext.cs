using BlogMvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvc.Data
{
    public class DataContext : DbContext
    {
        public DbSet<CategoryModel> Category { get; set; }
        public DbSet<PostModel> Post { get; set; }
        public DbSet<TagModel> Tag { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MusicTesting;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostModel>().HasData(
                new PostModel
                {
                    ID = 1,
                    Title = "William",
                    Body = "Shakespeare",
                    Author = "hj",
                    Image = "/images/.jpeg",
                    CategoryID = 1
                },

                 new PostModel
                 {
                     ID = 2,
                     Title = "William",
                     Body = "Shakespeare",
                     Author = "hj",
                     Image = "/images/.jpeg",
                     CategoryID = 1
                 },

                  new PostModel
                  {
                      ID = 3,
                      Title = "William",
                      Body = "Shakespeare",
                      Author = "hj",
                      Image = "/images/.jpeg",
                      CategoryID = 1
                  },

                   new PostModel
                   {
                       ID = 4,
                       Title = "William",
                       Body = "Shakespeare",
                       Author = "hj",
                       Image = "/images/.jpeg",
                       CategoryID = 1
                   }
                   );
        }
    }
}
