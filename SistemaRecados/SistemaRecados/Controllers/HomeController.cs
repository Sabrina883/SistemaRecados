using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaRecados.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "O Sistema Recados tem o objetivo de ser um mural de recados eletrônico";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Sua página de contato";

            return View();
        }
    }
}