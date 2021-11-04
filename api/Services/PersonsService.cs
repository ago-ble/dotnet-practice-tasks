using System.Collections.Generic;
using api.Models;
using api.Repositories;

namespace api.Services
{
    public class PersonsService
    {
        private readonly PersonsRepository _personsRepository;

        public PersonsService(PersonsRepository personsRepository)
        {
            _personsRepository = personsRepository;
        }

        public IList<Person> GetAll()
        {
            return _personsRepository.GetAll();
        }

        public Person GetById(int id)
        {
            return _personsRepository.GetById(id);
        }
        
        public void Create(Person person)
        {
            _personsRepository.Create(person);
        }
        public List<Person> GetHasCheapAnimal()
        {
            return _personsRepository.GetHasCheapAnimal();
        }
        public void Delete(Person person)
        {
            _personsRepository.Delete(person);
        }
    }
}