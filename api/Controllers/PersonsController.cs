using api.DTO.Users;
using api.Models;
using api.Repositories;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")] // api/persons
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly PersonsService _personsService;

        public PersonsController(PersonsService personsService)
        {
            _personsService = personsService;
        }
        [HttpGet("{id:int}")] // GET api/persons/{id}
        public ActionResult<Person> GetById(int id)
        {
            var person = _personsService.GetById(id);

            if (person == null)
            {
                return NotFound();
            }
            //_personsService.SaveChanges();//mantro sito tikrai nereik
            return Ok(person);
        }
        [HttpGet()] // GET api/persons
        public ActionResult<Person> GetAll()
        {
            return Ok(_personsService.GetAll());
        }
        [HttpGet("cheap")] // GET api/persons/cheap
        public ActionResult<Person> GetHasCheapAnimal()
        {
            return Ok(_personsService.GetHasCheapAnimal());
        }
        
        [HttpPost] // POST api/persons
        public ActionResult<Person> Create(Person person)
        {
            _personsService.Create(person);
            return Ok(person);
        }

        [HttpDelete("{id:int}")] // DELETE api/users/{id}
        public IActionResult Delete(int id)
        {
            var person = _personsService.GetById(id);
            if (person == null)
            {
                return NotFound();
            }
            _personsService.Delete(person);
            return Ok();
        }

    }
}