using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogMvc.Models
{
    public class PostModel
    {
        public int ID{ get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }

        public int CategoryID { get; set; }
        public virtual CategoryModel Categories { get; set; }
        public int TagID { get; set; }
        public virtual TagModel Tags { get; set; }


        public PostModel()
        {

        }

        public PostModel(int id, string title, string body, string image, string author, int categoryID, int tagID, ICollection<PostModel> Posts)
        {
            ID = id;
            Title = title;
            Body = body;
            Image = image;
            Author = author;
            Date = DateTime.Now;
            CategoryID = categoryID;
            TagID = tagID;

        }

        public PostModel(int v1, string v2, string v3, string v4, string v5, int v6, int v7)
        {
        }
    }
}
