using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvc.Models
{
    public class TagModel
    {
        public int ID { get; set; }
        public string TagName { get; set; }
        

        public virtual ICollection<PostModel> Posts { get; set; }

        public TagModel()
        {

        }

        public TagModel(int id, string tagName, string tagPost)
        {
            ID = id;
            TagName = tagName;
            
        }
    }
}
