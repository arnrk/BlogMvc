using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvc.Models
{
    public class PostModel
    {
        public int ID{ get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }


        //[DisplayFormat(DataFormatString = "{0:15 OCT 2019}")]
        //public DateTime Date { get; set; }

        public int CategoryID { get; set; }
        public virtual CategoryModel Categories { get; set; }
        public int TagID { get; set; }
        public virtual TagModel Tags { get; set; }

        //public virtual ICollection<PostModel> Posts { get; set; }

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
            CategoryID = categoryID;
            TagID = tagID;



        }

        

    }
}
