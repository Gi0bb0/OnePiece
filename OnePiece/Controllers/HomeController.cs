using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnePiece.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult SchedaPersonaggio(string numero)
        {
            ViewBag.Numero = numero;
            return PartialView();
        }

        public PartialViewResult SchedaFrutto(string numero)
        {
            ViewBag.Numero = numero;
            return PartialView();
        }

        public ActionResult Carosello()
        {
            return View();
        }

        public ActionResult Timone()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}