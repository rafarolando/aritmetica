using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aritmetica.Models;

namespace aritmetica.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Suma()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Suma(valores val) 
        {
            int resul = val.valor1 + val.valor2;
            ViewBag.respuesta = resul;
            return View();
        }
        public ActionResult Resta() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Resta(valores val) 
        {
            int resul = val.valor1 - val.valor2;
            ViewBag.respuesta = resul;
            return View();
        }
        public ActionResult Multiplicacion() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Multiplicacion(valores val)
        {
            int resul = val.valor1 * val.valor2;
            ViewBag.respuesta = resul;
            return View();
        }
        public ActionResult Division() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Division(valores val)
        {
            string mensaje = "NO SE PUEDE DIVIDIR ENTRE 0";
            if (val.valor2 != 0)
            {
                int resul = val.valor1 / val.valor2;
                ViewBag.respuesta = resul;
                return View();
            }
            else
                
                ViewBag.respuesta = mensaje;
                return View();
        }
    }
}
