using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedEntities
{
    public class Contact
    {
        #region properties
        public int IdContact { get; set; }
        public int ContactType { get; set; }
        public string ContactNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int PersonId { get; set; }
        #endregion

        public Contact()
        {

        }

        #region functions

        public bool saveContact()
        {
            bool result = false;

            return result;
        }

        public Contact getContactByPersonId()
        {
            Contact contactResult = null;

            return contactResult;
        }

        #endregion
    }
}
