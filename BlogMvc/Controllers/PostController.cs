using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMvc.Models;
using BlogMvc.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BlogMvc.Controllers
{
    public class PostController : Controller
    {
        IRepository<PostModel> postrepo;

        public PostController(IRepository<PostModel>postrepo)
        { this.postrepo = postrepo; }
    
        public ViewResult Index()
        {
            var model = postrepo.GetAll();

            return View(model);

        }

        

        public ViewResult Details(int id)
        {

            var model = postrepo.GetByID(id);
            return View(model);
        }

    }
}
