using System;
using System.Collections.Generic;
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
        public int DateTime { get; set; }

        public PostModel(int id, string title, string body, string image, string author )
        {
            ID = id;
            Title = title;
            Body = body;
            Image = image;
            Author = author;

        }

        public PostModel()
        {

        }

    }
}
