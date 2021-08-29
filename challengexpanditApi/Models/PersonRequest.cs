using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace challengexpanditApi.Models
{
    public class PersonsResponses
    {
        public Guid responseId;
        public Guid requestId;
    }

    public class AllPersonsResponseModel : PersonsResponses
    {
        private List<Person> allPersons;

        public List<Person> AllPersons
        {
            get { return this.allPersons; }
            set { this.allPersons = value; }
        }
    }

    public class PersonsResponseError
    {
        public string errorMessage;
        public int errorCode;
    }

    public class PersonResponseModel : PersonsResponses
    {
        private Person person;

        public Person Person
        {
            get { return this.person; }
            set { this.person = value; }
        }
    }
}