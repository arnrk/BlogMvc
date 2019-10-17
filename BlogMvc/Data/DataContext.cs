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
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=PostTesting;Trusted_Connection=True;";

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
                    CategoryID = 1,
                    TagID = 1
                },

                 new PostModel
                 {
                     ID = 2,
                     Title = "William",
                     Body = "Shakespeare",
                     Author = "hj",
                     Image = "/images/.jpeg",
                     CategoryID = 1,
                     TagID = 1
                 },

                  new PostModel
                  {
                      ID = 3,
                      Title = "William",
                      Body = "Shakespeare",
                      Author = "hj",
                      Image = "/images/.jpeg",
                      CategoryID = 1,
                      TagID = 1,
                  },

                   new PostModel
                   {
                       ID = 4,
                       Title = "William",
                       Body = "Shakespeare",
                       Author = "hj",
                       Image = "/images/.jpeg",
                       CategoryID = 1,
                       TagID = 1
                   }
                   );

            modelBuilder.Entity<TagModel>().HasData(
                new TagModel
                {
                    ID = 1,
                    TagName = "Food",
                   
                    
                },

                 new TagModel
                 {
                     ID = 2,
                     TagName = "Sun",

                     
                 },

                  new TagModel
                  {
                      ID = 3,
                      TagName = "Fun",

                      
                  },

                   new TagModel
                   {
                       ID = 4,
                       TagName = "Other fun Stuff",

                       
                   }
                   );

            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel
                {
                    ID = 1,
                    CategoryName = "Fun",

                    
                },

                 new CategoryModel
                 {
                     ID = 2,
                     CategoryName = "Food",

                     
                 },

                  new CategoryModel
                  {
                      ID = 3,
                      CategoryName = "Sun",

                      
                  },

                   new CategoryModel
                   {
                       ID = 4,
                       CategoryName = "Other",

                       
                   }
                   );

        }
    }
}
