using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvc.Models
{
    public class CategoryModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryPost { get; set; }

        public CategoryModel()
        {

        }

        public CategoryModel(int id, string categoryName, string categoryPost)
        {
            ID = id;
            CategoryName = categoryName;
            CategoryPost = categoryPost;
        }

    }
}
