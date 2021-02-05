using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

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
            tipi.Add("shanks.png");
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

        public PartialViewResult MenuSaghe(int sagaID)
        {
            List<ListItem> saghe = new List<ListItem>();
            saghe.Add(new ListItem { Text = "Saga di Romance Dawn", Value = 1.ToString() });
            saghe.Add(new ListItem { Text = "Saga di Orange", Value = 2.ToString() });
            saghe.Add(new ListItem { Text = "Saga di Shirop", Value = 3.ToString() });
            saghe.Add(new ListItem { Text = "Saga del Baratie", Value = 4.ToString() });
            saghe.Add(new ListItem { Text = "Saga di Arlong Park", Value = 5.ToString() });
            saghe.Add(new ListItem { Text = "Saga di Alabasta", Value = 6.ToString() });
            ViewBag.SagaID = sagaID;
            return PartialView(saghe);
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