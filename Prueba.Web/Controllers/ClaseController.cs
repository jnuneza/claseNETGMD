using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Web.Controllers
{
    public class ClaseController : Controller
    {
        // GET: Clase
        public ActionResult Index()
        {
            List<Clase> lista = new List<Clase>();
            Clase cl1 = new Clase() {ClaseID=1, Nombre="hhh",Comentario="aaa"}
            Clase cl2 = new Clase() { ClaseID = 2, Nombre = "sdf", Comentario = "tyj" }
            Clase cl3 = new Clase() { ClaseID = 3, Nombre = "qwer", Comentario = "atyjaa" }
            lista.Add(cl1);
            lista.Add(cl2);
            lista.Add(cl3);
            return View();
        }
    }
}