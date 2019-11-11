using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMvc.model;

namespace MyMvc.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            var setViewModel = new SetViewModel();
            return View(setViewModel.Get());
        }
    }
}