using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirthdayCardGenerator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CardGenerator()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CardGenerator(Models.CardAttributes cardAttributes)
        {
            if (ModelState.IsValid)
            {
                return View("thanks", cardAttributes);
            } else
            {
                return View();
            }            
        }
    }
}