using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Contacts
    {
        #region properties
        public int IdContact {get; set;}
        public int ContactType { get; set; }
        public string ContactNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int PersonId { get; set; }
        #endregion

        public Contacts()
        {

        }

        #region functions

        public bool saveContact()
        {
            bool result = false;

            return result;
        }

        public Contacts getContactByPersonId()
        {
            Contacts contactResult = null;

            return contactResult;
        }

        #endregion
    }
}
