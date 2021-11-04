using System.Collections.Generic;
using System.Linq;
using api.Data;
using api.Models;
using api.Services;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class PersonsRepository
    {
        private readonly ApiDbContext _db;

        public PersonsRepository(ApiDbContext db) {
            _db = db;
        }
        
        public void Create(Person person) {
            _db.Persons.Add(person);
            _db.SaveChanges();
        }
        public Person GetById(int id)//nzn, patikrint, cia reiktu animal, not animal id
        {
            return _db.Persons
                .Include(p => p.Animal)
                .FirstOrDefault(o => o.Id == id);
        }

        public List<Person> GetHasCheapAnimal()
        {
            var persons = _db.Persons
                .Include((p => p.Animal))
                .Where(o => o.Animal.PriceAMonth < 100)
                .ToList();
            return persons;
        }
        public IList<Person> GetAll()
        {
            var persons = _db.Persons
                .Include(p => p.Animal)
                .ToList();
            return persons;
        }
        public void Delete(Person person)
        {
            _db.Persons.Remove(person);
            _db.SaveChanges();
        }
    }
}