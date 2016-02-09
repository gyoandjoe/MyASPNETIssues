using CheckingASPNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace CheckingASPNET.Controllers
{
    public class ProjectController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTableProjects()
        {
            List<Project> listProjects = new List<Project>();
            listProjects.Add(new Project() { IdProject = 0, NombreProject = "Proyecto 1", Descripcion = "Este es el proyecto 1", FechaCreacion = DateTime.UtcNow });
            listProjects.Add(new Project() { IdProject = 1, NombreProject = "Proyecto 2", Descripcion = "Este es el proyecto 2", FechaCreacion = DateTime.UtcNow });
            listProjects.Add(new Project() { IdProject = 2, NombreProject = "Proyecto 3", Descripcion = "Este es el proyecto 3", FechaCreacion = DateTime.UtcNow });
            listProjects.Add(new Project() { IdProject = 3, NombreProject = "Proyecto 4", Descripcion = "Este es el proyecto 4", FechaCreacion = DateTime.UtcNow });
            return PartialView("_TableProjects" , listProjects);
        }

        public JsonResult FindProjectById(int id)
        {
            List<Project> listProjects = new List<Project>();
            listProjects.Add(new Project() { IdProject = 0, NombreProject = "Proyecto 1", Descripcion = "Este es el proyecto 1", FechaCreacion = DateTime.UtcNow });
            listProjects.Add(new Project() { IdProject = 1, NombreProject = "Proyecto 2", Descripcion = "Este es el proyecto 2", FechaCreacion = DateTime.UtcNow });
            listProjects.Add(new Project() { IdProject = 2, NombreProject = "Proyecto 3", Descripcion = "Este es el proyecto 3", FechaCreacion = DateTime.UtcNow });
            listProjects.Add(new Project() { IdProject = 3, NombreProject = "Proyecto 4", Descripcion = "Este es el proyecto 4", FechaCreacion = DateTime.UtcNow });

            return Json(listProjects.Where(x => x.IdProject == id).SingleOrDefault(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult EditProject(Project project)
        {
            return PartialView();
        }
    }
}