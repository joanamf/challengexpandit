using challengexpanditApi.Models;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Mvc;

namespace challengexpanditApi.Controllers
{
    public class PersonController : Controller
    {
        //for testing purposes
        private string usernameLocal = "testClient";
        private string tokenLocal = "H8Zt-6*j#597!2z4";
        private string connName = string.Empty;

        public string ConnName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(connName) == true)
                {
                    connName =
                        WebConfigurationManager.ConnectionStrings["dbConnection"].ToString();
                }
                return connName;
            }
        }


        // GET: Return list of Persons
        // GET: /person/all
        [System.Web.Mvc.HttpGet]
        public JsonResult All(Guid requestId, string username, string token)
        {
            AllPersonsResponseModel response = new AllPersonsResponseModel();
            response.requestId = requestId;
            response.responseId = new Guid();

            if (requestIsValid(username, token))
            {
                try
                {
                    response.AllPersons = Person.getListPersons(ConnName);
                }
                catch (Exception excep)
                {
                    ExceptionError(excep);
                }
            }
            else
            {
                AuthenticationError();
            };

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        // GET: Return person by id
        // GET: /person/personDetails
        [System.Web.Mvc.HttpGet]
        public JsonResult PersonDetails(Guid requestId, string username, string token, int personId)
        {
            PersonResponseModel personResponse = new PersonResponseModel();
            personResponse.requestId = requestId;
            personResponse.responseId = new Guid();

            if (requestIsValid(username, token))
            {
                try
                {
                    personResponse.Person = Person.getPersonById(ConnName, personId);

                }
                catch (Exception excep)
                {
                    ExceptionError(excep);
                }
            }
            else
            {
                AuthenticationError();
            }

            return Json(personResponse, JsonRequestBehavior.AllowGet);
        }

        //POST: Add person
        //POST: /person/addPerson
        [System.Web.Mvc.HttpPost]
        public ActionResult AddPerson()
        {
            return null;
        }

        #region private methods
        private bool requestIsValid(string username, string token)
        {
            if (username == usernameLocal && token == tokenLocal)
            {
                return true;
            };

            return false;
        }

        private JsonResult AuthenticationError()
        {
            PersonsResponseError error = new PersonsResponseError
            {
                errorCode = 401,
                errorMessage = "Username or token incorrect"
            };

            return Json(error, JsonRequestBehavior.AllowGet);
        }

        private JsonResult ExceptionError(Exception excep)
        {
            PersonsResponseError error = new PersonsResponseError
            {
                errorCode = 400,
                errorMessage = "An exception was thrown. Exception message: " + excep.Message
            };

            return Json(error, JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}