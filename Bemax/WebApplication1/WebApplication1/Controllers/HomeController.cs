using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.Sliders = StaticLists.sliders;
            model.Iconboxes = StaticLists.Iconboxes;
            return View(model);
        }
    }
}