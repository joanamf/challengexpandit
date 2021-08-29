using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Contacts
    {

        public int ContactId { get; set; }
        public int ContactType { get; set; }
        public string ContactNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int PersonId { get; set; }

        public Contacts()
        {

        }

    }
}
