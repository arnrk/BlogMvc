using BlogMvc.Data;
using BlogMvc.Models;
using BlogMvc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace BlogMvc.Tests
{
    public class PostRepsositoryTests : IDisposable
    {

        private DataContext db;
        private PostRepository underTest;

        public PostRepsositoryTests()
        {
            db = new DataContext();
            db.Database.BeginTransaction();

            underTest = new PostRepository(db);
        }

        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }

        [Fact]
        public void Count_Starts_At_Four()
        {
            var count = underTest.Count();

            Assert.Equal(3, count);
        }

        [Fact]
        public void Create_Increases_Count()
        {
            underTest.Create(new PostModel() { Title = "This Is Great" });

            var count = underTest.Count();
            Assert.Equal(4, count);
        }

        [Fact]
        public void GetById_Returns_Created_Item()
        {
            var expectedHeroModel = new PostModel() { Title = "This Is Better" };
            underTest.Create(expectedHeroModel);

            var result = underTest.GetByID(expectedHeroModel.ID);

            //Assert.Equal(expectedHeroModel.Name, result/*.Name*/);
        }

        [Fact]
        public void Delete_Reduces_Count()
        {
            var HeroModel = new PostModel() { Title = "This Is Awesome" };
            underTest.Create(HeroModel);

            underTest.Delete(HeroModel);
            var count = underTest.Count();

            Assert.Equal(3, count);
        }

        [Fact]
        public void GetAll_Returns_All()
        {
            underTest.Create(new PostModel() { Title = "This Is Not Good" });
            underTest.Create(new PostModel() { Title = "This Is Really Good" });

            var all = underTest.GetAll();

            Assert.Equal(5, all.Count());
        }
    }
}
