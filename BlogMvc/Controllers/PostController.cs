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

        public object PostModelID { get; private set; }

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

        public ViewResult Create(int id)
        {

            var model = postrepo.GetByID(id);
            return View(model);
        }

       

        [HttpPost]
        public ActionResult Create(PostModel post)
        {
            postrepo.Create(post);
            return RedirectToAction("Details");
        }

        [HttpGet]
        public ViewResult CreateByPostID(int id)
        {
            ViewBag.PostModellID = id;
            return View();
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = postrepo.GetByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(PostModel post)
        {
            postrepo.Delete(post);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = postrepo.GetByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(PostModel post)
        {
            postrepo.Edit(post);
            return RedirectToAction("Index");
        }



    }
}
