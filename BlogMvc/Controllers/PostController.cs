using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogMvc.Controllers
{
    public class PostController : Controller
    {
        public ViewResult Index(int ID, string Title, string Body, string Image, string Author)
        {
            var model = new PostModel();
            model.ID = 32;
            model.Title = "Best Blog Ever";
            model.Body = "I have never read such engaging material";
            model.Image = "Some Cool Image";
            model.Author = "Joe Smith";

            return View(model);

        }

        public ViewResult Details(int ID, string Title, string Body, string Image, string Author)
        {
            var model = new PostModel();
            model.ID = 32;
            model.Title = "Best Blog Ever";
            model.Body = "I have never read such engaging material";
            model.Image = "Some Cool Image";
            model.Author = "Joe Smith";

            return View(model);
        }

    }
}
