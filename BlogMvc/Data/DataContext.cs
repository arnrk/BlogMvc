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
                    Title = "Impressions so far on Freddie Kitchens",
                    Body = "Kitchens’ thick Southern drawl hugs every syllable that flows from his mouth. But don’t mistake Kitchens for a dolt.  18 years after coaching for Saban, Kitchens has slowly worked his way up the ladder to become an NFL head coach. Kitchens coached for four other teams between his time with LSU and the Browns. He spent all of that time as either a quarterbacks coach, running backs coach, or tight ends coach.",
                    Author = "BK",
                    Image = "/Images1/FredK1.jpg",
                    CategoryID = 1,
                    TagID = 1
                },

                 new PostModel
                 {
                     ID = 2,
                     Title = "What's Wrong with Baker?",
                     Body = "What’s wrong? Well, just about everything. When an offense faceplants to this degree, there isn’t just one culprit. But let’s start with versatility in personnel groupings. Per Sharp Football Analysis, the Browns are running 11 personnel (one running back, one tight end, three wide receivers) on 84% of their offensive snaps. That’s one of the highest rates in the NFL, and in line with the Rams as Sean McVay has become the king of 11 personnel. In fact, the Rams, who ran 11 personnel on 94% of their plays last season, are running it just 83% of the time in 2019, as McVay endeavors to upset defenses who have stacked their schemes to counter his previous predictability.",
                     Author = "BK",
                     Image = "/Images1/BakerM1.jpg",
                     CategoryID = 1,
                     TagID = 1
                 },

                  new PostModel
                  {
                      ID = 3,
                      Title = "Lookout NFL... Nick Chubb is a beast!",
                      Body = "As a standout track & field athlete, Chubb competed from 2011 to 2015 in events ranging from the 100-meters to the shot put. At the 2013 4A Sectionals, he took fifth place in the long jump event with a leap of 6.85 meters (22 ft, 4 in).[3] At the 2014 4A Sectionals, he won the shot put event, recording a top-throw of 17.05 meters (55 ft, 8in), and earned second-place finishes in both the 100-meter dash, with a time of 10.69 seconds (setting a school record), and the 200-meter dash, with a time of 21.83 seconds.[4] He captured the state title in the shot put at the 2014 Class AAAA with a throw of 16.77 meters (55 ft).",
                      Author = "BK",
                      Image = "/Images1/NickC1.jpg",
                      CategoryID = 1,
                      TagID = 1,
                  },

                   new PostModel
                   {
                       ID = 4,
                       Title = "The Browns Schedule is not very friendly",
                       Body = "This is the game Breech listed as the make-or-break game for the Browns, and I agree wholeheartedly. Everyone is assuming the Browns are going to steamroll the Titans because the Titans are boring and the Browns are the Hansel of the NFL. The Browns are a 5.5-point favorite over Tennessee at home. The Browns have been 5.5-point favorites eight times in the last 15 years. They covered three of those games. I'm not saying they won't win the game or even not cover, but the hype is cascading out of control on this team. The Titans nearly made the playoffs last year, have an underrated roster, will try to come in and pound the ball with Derrick Henry and could steal this game. It would send shockwaves through Cleveland if Tennessee pulled off the upset. ",
                       Author = "BK",
                       Image = "/Images1/BSched1.jpg",
                       CategoryID = 1,
                       TagID = 1
                   }
                   );

            modelBuilder.Entity<TagModel>().HasData(
                new TagModel
                {
                    ID = 1,
                    TagName = "Freddie Kitchens",
                   
                    
                },

                 new TagModel
                 {
                     ID = 2,
                     TagName = "Baker Mayfield",

                     
                 },

                  new TagModel
                  {
                      ID = 3,
                      TagName = "Nick Chubb",

                      
                  },

                   new TagModel
                   {
                       ID = 4,
                       TagName = "2019 Schedule",

                       
                   }
                   );

            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel
                {
                    ID = 1,
                    CategoryName = "Freddie Kitchens",

                    
                },

                 new CategoryModel
                 {
                     ID = 2,
                     CategoryName = "Baker Mayfield",

                     
                 },

                  new CategoryModel
                  {
                      ID = 3,
                      CategoryName = "Nick Chubb",

                      
                  },

                   new CategoryModel
                   {
                       ID = 4,
                       CategoryName = "2019 Schedule",

                       
                   }
                   );

        }
    }
}
