using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMvc.Models;
using BlogMvc.Data;
using BlogMvc.Repository;


namespace BlogMvc.Repository
{
            public class PostRepository : IRepository<PostModel>
        {
            private DataContext db;
            public PostRepository(DataContext db)
            {
                this.db = db;
            }

            public int Count()
            {
                return db.Post.Count();
            }

            public void Create(PostModel posts)
            {
                db.Post.Add(posts);
                db.SaveChanges();
            }

            public void Delete(PostModel posts)
            {
                db.Post.Remove(posts);
                db.SaveChanges();
            }

            public void Edit(PostModel posts)
            {
                db.Post.Update(posts);
                db.SaveChanges();
            }

            public IEnumerable<PostModel> GetAll()
            {
                return db.Post;
            }

            public PostModel GetByID(int id)
            {
                return db.Post.SingleOrDefault(p => p.ID == id);
            }

            public void Save()
            {
                db.SaveChanges();
            }
        }
    }

