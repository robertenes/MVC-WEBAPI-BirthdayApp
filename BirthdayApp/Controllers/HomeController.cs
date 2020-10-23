using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BirthdayApp.Models;
namespace BirthdayApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult InvitationForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InvitationForm(InvitationModel model)
        {
            if(ModelState.IsValid)
            {
                DataBase.Add(model);
                return View("Thanks", model);
            }

            return View(model);
        }
        [ChildActionOnly]
        public ActionResult Arrivals()
        {
            var arrival = DataBase.list.Where(i => i.JoinState == true).ToList();
            return PartialView(arrival);
        }
    }
}
