using Microsoft.AspNetCore.Mvc;

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

