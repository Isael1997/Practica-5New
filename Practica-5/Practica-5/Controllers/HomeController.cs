using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_5.Models;

using System.Data;
using System.Data.Entity;
using System.Net;

namespace Practica_5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        private ConexionDBTareas db = new ConexionDBTareas();

        // GET: Home


        /*Este Action Resulta es para buscar en un vista distina el nombre del Estudiantes y 
         * luego ingresar la opcion deseada para dirigirlo hacia el ActionResult de COnsulta*/
        public ActionResult BusquedaConsulta()

        {
            return View();
        }


        public ActionResult Consultas()
        {
            return View(db.Students.ToList());
        }

        public ActionResult Lector()
        {
            return View();
        }

        public ActionResult Acercade()
        {
            return View();
        }

    }
}