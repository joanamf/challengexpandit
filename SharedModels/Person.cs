using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Person
    {
        #region fields
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public string MobileNumber { get; set; }
        public string HomeNumber { get; set; }
        public string OfficeNumber { get; set; }
        public string OtherNumber { get; set; }

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

        public static DataTable getListPersonsDT(string connName)
        {
            string sql = @"SELECT [personId]
                                 ,[name]
                                 ,[address]
                                 ,[zipCode]
                                 ,[city]
                                 ,[email]
                                 ,[photo]
                                 ,[mobileNumber]
                                 ,[homeNumber]
                                 ,[officeNumber]
                                 ,[otherNumber]
                                 ,[createdOn]
                                 ,[createdBy]
                                 ,[updatedOn]
                                 ,[updatedBy]
                            FROM [Persons]
                            ORDER BY [name] ";

            DataTable dt = DatabaseConnection.getDataTableFromDB(connName, sql, null);

            return dt;
        }

        public static List<Person> getListPersons(string connName)
        {
            List<Person> allPerson = null;

            DataTable dt = getListPersonsDT(connName);

            if (dt != null)
            {
                allPerson = new List<Person>();

                foreach (DataRow dr in dt.Rows)
                {
                    Person pConverted = convertDataRowToPerson(dr);
                    allPerson.Add(pConverted);
                };
            }

            return allPerson;
        }

        public static Person getPersonById(string connName, int id)
        {
            Person resultPerson = null;

            string sql = @"SELECT [personId]
                                 ,[name]
                                 ,[address]
                                 ,[zipCode]
                                 ,[city]
                                 ,[email]
                                 ,[photo]
                                 ,[mobileNumber]
                                 ,[homeNumber]
                                 ,[officeNumber]
                                 ,[otherNumber]
                                 ,[createdOn]
                                 ,[createdBy]
                                 ,[updatedOn]
                                 ,[updatedBy]
                        FROM [Persons]
                        WHERE personId = @personId ";

            List<KeyValuePair<string, object>> parameterList = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("personId", id)
            };

            DataTable dt = DatabaseConnection.getDataTableFromDB(connName, sql, parameterList);

            if(dt != null)
            {
                DataRow dr = dt.Rows[0];

                resultPerson = convertDataRowToPerson(dr);
            };

            return resultPerson;
        }

        #endregion

        #region
        private static Person convertDataRowToPerson(DataRow drConvert)
        {
            Person p = new Person
            {
                PersonId = (int)drConvert["personId"],
                Name = drConvert["name"].ToString(),
                Address = drConvert["address"].ToString(),
                ZipCode = drConvert["zipCode"].ToString(),
                City = drConvert["city"].ToString(),
                Email = drConvert["email"].ToString(),
                MobileNumber = drConvert["mobileNumber"].ToString(),
                HomeNumber = drConvert["homeNumber"].ToString(),
                OfficeNumber = drConvert["officeNumber"].ToString(),
                OtherNumber = drConvert["otherNumber"].ToString(),
                CreatedOn = (DateTime)drConvert["createdOn"],
                CreatedBy = drConvert["createdBy"].ToString(),
                UpdatedOn = (DateTime)drConvert["updatedOn"],
                UpdatedBy = drConvert["updatedBy"].ToString()
            };

            try
            {
                p.Photo = (byte[])drConvert["photo"];
            }
            catch 
            {
                p.Photo = new byte[0];
            }

            return p;
        }
        #endregion

    }
}