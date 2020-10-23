using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BirthdayApp.Models;
namespace BirthdayApp.Controllers
{
    public class BirthdayAPIController : ApiController
    {
        [HttpGet]
        public IEnumerable<InvitationModel> Arrivals()
        {
            return DataBase.list.Where(x => x.JoinState == true).ToList();
        }
        [HttpGet]
        public IEnumerable<InvitationModel> NotComing()
        {
            return DataBase.list.Where(x => x.JoinState == false).ToList();
        }
        [HttpPost]
        public IHttpActionResult AddInvited(InvitationModel model)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    DataBase.Add(model);
                    return Ok("Ok");
                }
                return NotFound();
            }
            catch (Exception)
            {

                return NotFound();
            }


        }
    }
}
