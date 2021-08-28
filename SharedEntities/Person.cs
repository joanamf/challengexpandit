using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedEntities
{
    public class Person
    {

        #region properties
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Addrres { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public Int64 Photo { get; set; }

        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        #endregion

        public Person()
        {

        }

        #region functions
        public bool savePerson()
        {
            bool result = false;



            return result;
        }

        public static List<Person> getListPersons()
        {
            List<Person> allPersons = new List<Person>();

            return allPersons;
        }

        public Person getPersonById()
        {
            Person resultPerson = null;

            return resultPerson;

        }
        #endregion
    }
}
