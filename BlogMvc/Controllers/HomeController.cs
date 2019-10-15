using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogMvc.Models;

namespace BlogMvc.Controllers
{
    public class HomeController : Controller
    {
        
        public ViewResult Index()
        {
            return View();
        }

        

        public ViewResult Contact()
        {
            return View();
        }

    }
}

