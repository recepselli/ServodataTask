using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ServodataTask.Entities.Models;
using ServodataTask.Entities.Querying;
using ServodataTask.Repositories.Person;

namespace ServodataTask.Controllers
{
    [Route("api/person")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        readonly IPersonRepository personRepository;

        public PersonController(IPersonRepository _personRepository)
        {
            personRepository = _personRepository;
        }

        [HttpGet("people")]
        [ProducesResponseType(typeof(GenericPagingData<Person>), 200)]
        public async Task<IActionResult> GetPeople(int page = 1, int pageSize = 10)
        {
            return new JsonResult(await personRepository.GetPersons(page, pageSize));
        }
    }
}