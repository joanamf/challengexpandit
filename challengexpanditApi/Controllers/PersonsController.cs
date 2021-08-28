using SharedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static challengexpanditApi.Models.PersonRequest;

namespace challengexpanditApi.Controllers
{
    public class PersonsController : Controller
    {
        // GET: Persons
        [HttpGet]
        public JsonResult Persons(Guid requestId)
        {
            PersonsResponse response = new PersonsResponse();
            try
            {
                response.requestId = requestId;
                response.responseId = new Guid();

                response.AllPersons = Person.getListPersons();

            }catch(Exception excep)
            {

            }
            return null;
            //return View();
        }

        // GET: Return person by id
        [HttpGet]
        public JsonResult Persons(Guid requestId, int id)
        {
            return null;
        }

        //POST: Add person
        [HttpPost]
        public ActionResult AddPerson()
        {
            return null;
        }

    }
}