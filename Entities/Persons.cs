using System;

namespace Entities
{
    public class Persons
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

        public Persons()
        {

        }

        #region functions
        public bool savePerson()
        {
            bool result = false;



            return result;
        }

        public Persons getPersonById()
        {
            Persons resultPerson = null;

            return resultPerson;

        }
        #endregion
    }
}
