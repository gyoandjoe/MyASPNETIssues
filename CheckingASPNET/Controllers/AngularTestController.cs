using CheckingASPNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckingASPNET.Controllers
{
    public class AngularTestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ObtenerTodasLasPersonas()
        {

            List<Person> personas = new List<Person>();
            personas.Add(new Person() { Apellido = "Sanchez", Email="Sanchez@hotmail.com", IdPerson=1, Nombre="Santiago" });
            personas.Add(new Person() { Apellido = "Lopez", Email = "Lopez@hotmail.com", IdPerson = 1, Nombre = "Areli" });
            personas.Add(new Person() { Apellido = "Vasquez", Email = "Vasquez@hotmail.com", IdPerson = 1, Nombre = "Batman" });

            return Json(personas, JsonRequestBehavior.AllowGet);
        }
    }
}