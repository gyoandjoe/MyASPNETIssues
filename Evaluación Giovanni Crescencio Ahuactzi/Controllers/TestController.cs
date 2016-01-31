using Evaluación_Giovanni_Crescencio_Ahuactzi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Evaluación_Giovanni_Crescencio_Ahuactzi.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { IdPerson=1, Nombre = "Juan", Apellido = "Perez", Email = "juanp@hotmail.com" });
            people.Add(new Person() { IdPerson = 2, Nombre = "Margarita", Apellido = "Rivas", Email = "margaritaR@hotmail.com" });
            return View(people);
        }
        public ActionResult GetEditorForPerson(int idPerson)
        {
            return PartialView("_GetEditorForPerson", new Person() { IdPerson = idPerson, Nombre = "Juan", Apellido = "Perez", Email = "juanp@hotmail.com" });
        }
    }
}