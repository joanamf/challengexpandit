using SharedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace challengexpanditApi.Models
{
    public class PersonRequest
    {
        public class PersonsResponse
        {
            public Guid responseId;
            public Guid requestId;
            private List<Person> allPersons;
         
            public List<Person> AllPersons
            {
                get { return this.allPersons; }
                set { this.allPersons = value; }
            }
        }
    }
}