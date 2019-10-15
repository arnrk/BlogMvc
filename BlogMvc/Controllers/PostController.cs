using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogMvc.Controllers
{
    public class PostController : Controller
    {
        public ViewResult Index()
        {
            

            return View();

        }

        public ViewResult Details()
        {
           

            return View();
        }

    }
}
