using Demo.Queries.Person;
using Demo.Repository.Person;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        private readonly IPersonQueries _personQueries;

        public PersonController(IPersonRepository personRepository, IPersonQueries personQueries)
        {
            _personRepository = personRepository;
            _personQueries = personQueries;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetById([FromRoute] int id)
        {
            var result = await _personQueries.GetById(id);

            if(result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _personQueries.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Model.Person person)
        {
            var result = await _personRepository.Create(person);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] Model.Person person)
        {
            var result = await _personRepository.Update(person);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            var result = await _personRepository.Delete(id);
            return Ok(result);
        }
    }
}
