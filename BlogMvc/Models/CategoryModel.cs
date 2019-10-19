using System.Collections.Generic;

namespace BlogMvc.Models
{
    public class CategoryModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        

        public virtual ICollection<PostModel> Posts { get; set; }

        public CategoryModel()
        {

        }

        public CategoryModel(int id, string categoryName, string categoryPost)
        {
            ID = id;
            CategoryName = categoryName;
            
        }

    }
}
