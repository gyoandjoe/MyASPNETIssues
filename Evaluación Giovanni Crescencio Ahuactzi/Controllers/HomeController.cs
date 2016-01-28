using Evaluación_Giovanni_Crescencio_Ahuactzi.Infrastructure;
using Evaluación_Giovanni_Crescencio_Ahuactzi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Evaluación_Giovanni_Crescencio_Ahuactzi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Evaluacion()
        {
            Session["listBySession"] = new List<TestEntity>();
            return View();
        }

        [HttpPost]
        public ActionResult Evaluacion(TestEntity obj)
        {
            if (ModelState.IsValid)
            {

                List<TestEntity> objectsList = (List<TestEntity>)Session["listBySession"];
                objectsList.Add(obj);
                Session["listBySession"] = objectsList;
            }

            return PartialView(obj);
        }


        public ActionResult GetTableEvaluacion()
        {
            return PartialView((List<TestEntity>)Session["listBySession"]);
        }

        public ActionResult Chat()
        {
            
            if (ChatRepository.chatHistory == null)
                ChatRepository.chatHistory = new List<Message>();
            return View();
        }

        [HttpPost]
        public ActionResult Chat(Message mensaje)
        {
            if (ModelState.IsValid)
            {
                ChatRepository.chatHistory.Add(mensaje);
            }
            return PartialView(mensaje);
        }

        public ActionResult UpdateChatViewer()
        {
                       
            return PartialView(ChatRepository.chatHistory);
        }
    }
}