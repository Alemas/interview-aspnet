using Interview.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository repository;

        public ProductController()
        {
            repository = new ProductRepository();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Details()
        {
            return View();
        }
    }
}