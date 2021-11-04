using api.Models;
using System.Linq;

namespace api.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApiDbContext db)
        {
            if (db.Persons.Any())
                return;

            var persons = new Person[]
            {
                new ()
                {
                    Name = "gus",
                    Animal = new Animal()
                    {
                        Name = "Mr.buble",
                        PriceAMonth = 50,
                        Type = "Fish"
                    }
                },
                new ()
                {
                    Name = "antans",
                    Animal = new Animal()
                    {
                        Name = "Pete",
                        PriceAMonth = 120,
                        Type = "Dog"
                    }
                },
                new ()
                {
                    Name = "tom",
                    Animal = new Animal()
                    {
                        Name = "Ana",
                        PriceAMonth = 60,
                        Type = "Rat"
                    }
                }
            };

            db.Persons.AddRange(persons);
            db.SaveChanges();
        }
    }
}
