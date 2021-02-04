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
            List<string> tipi = new List<string>();
            tipi.Add("rufy.png");
            tipi.Add("zoro.png");
            tipi.Add("sanji.png");
            var random = new Random();
            int index = random.Next(tipi.Count);
            ViewBag.Tipo = tipi[index];
            ViewBag.Numero = numero;
            return PartialView();
        }

        public PartialViewResult SchedaFrutto(string numero)
        {
            List<string> tipi = new List<string>();
            tipi.Add("rogia.png");
            tipi.Add("paramisha.png");
            tipi.Add("zoozoo.png");
            var random = new Random();
            int index = random.Next(tipi.Count);
            ViewBag.Tipo = tipi[index];
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