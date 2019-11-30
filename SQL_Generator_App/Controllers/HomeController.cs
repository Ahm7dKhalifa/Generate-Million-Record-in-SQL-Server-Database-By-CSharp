using SQL_Generator_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SQL_Generator_App.SignalR_Hubs;

namespace SQL_Generator_App.Controllers
{
    public class HomeController : Controller
    {
        DatabaseEntities _dbContext = new DatabaseEntities();



        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(string CompleteFilePath)
        {
            int counter = 0;
            string line;

            CounterHub CounterHub = new CounterHub();

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@CompleteFilePath);
            while ((line = file.ReadLine()) != null)
            {
                int noOfRowInserted = _dbContext.Database.ExecuteSqlCommand(line);
                counter++;
                CounterHub.DisplayCounter(counter);
            }

            file.Close();

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
    }
}