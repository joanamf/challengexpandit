namespace challengexpanditV1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<challengexpanditV1.Models.challengexpanditDBEntities2>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(challengexpanditV1.Models.challengexpanditDBEntities2 context)
        {
            context.Persons.AddOrUpdate(
                new Models.Persons { personId = 1,
                    name = "Joana Freitas", 
                    address = "Tv. F. A. Barido 3", 
                    zipCode = "2430-415",
                    city="Marinha Grande",
                    email = "joanamelofreitas@gmail.com",
                    mobileNumber = "914804646",
                    homeNumber = "244111111",
                    officeNumber = null,
                    otherNumber = null, 
                    photo = null,
                    createdOn = DateTime.UtcNow,
                    createdBy = string.Empty,
                    updatedOn = DateTime.UtcNow,
                    updatedBy = string.Empty
                    },
                new Models.Persons
                {
                    personId = 2,
                    name = "Maria Silva",
                    address = "Rua das Flores",
                    zipCode = "2430-115",
                    city = "Marinha Grande",
                    email = "mariasilva@gmail.com",
                    mobileNumber = "916322145",
                    homeNumber = "244222222",
                    officeNumber = null,
                    otherNumber = null,
                    photo = null,
                    createdOn = DateTime.UtcNow,
                    createdBy = string.Empty,
                    updatedOn = DateTime.UtcNow,
                    updatedBy = string.Empty
                },
                new Models.Persons {
                personId = 1,
                    name = "António Santos", 
                    address = "Rua da Alegria", 
                    zipCode = "2430-151",
                    city = "Marinha Grande",
                    email = "antoniosantos@gmail.com",
                    mobileNumber = "966555611",
                    homeNumber = "244789456",
                    officeNumber = "930485213",
                    otherNumber = null, 
                    photo = null,
                    createdOn = DateTime.UtcNow,
                    createdBy = string.Empty,
                    updatedOn = DateTime.UtcNow,
                    updatedBy = string.Empty
                    }
                );

            base.Seed(context);
        }
    }
}
