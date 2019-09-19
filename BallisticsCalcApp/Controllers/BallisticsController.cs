using BallisticsCalcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BallisticsCalcApp.Controllers
{
    public class BallisticsController : Controller
    {
            

        public ActionResult Index()
        {
            Ballistics ballistics = new Ballistics();

            return View("Index", ballistics);
        }

        [HttpPost]
        public ActionResult Index(Ballistics ballistics)
        {

            return View("Index", ballistics);
        }

        // GET: Ballistics/Create
        [HttpPost]
        public ActionResult Result(Ballistics ballistics)
        {
            // contextDB.Ballistics.Add(ballistics);
            //OH GOD!!!!!
            ballistics.SetTemp(ballistics.tempFarenheit);
            ballistics.ToKilograms(ballistics.mass);
            ballistics.ToArea(ballistics.diameter);
            ballistics.FromFeetPerSecond(ballistics.velocity);
            

            // Doesn't like this statement here...
            
            ballistics.CalculatePressure(ballistics.tempCelcius);
           


            return View("Result", ballistics);
        }
        public BallisticsController()
        {
        }

        private class BindPropertyAttribute : Attribute
        {
        }
    }
}
