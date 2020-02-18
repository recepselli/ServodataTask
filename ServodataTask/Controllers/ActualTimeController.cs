using System;
using Microsoft.AspNetCore.Mvc;
using ServodataTask.Repositories.ActualTime;

namespace ServodataTask.Controllers
{
    [Route("api/actualtime")]
    [ApiController]
    public class ActualTimeController : ControllerBase
    {
        readonly IActualTime actualTimeRepository;
        public ActualTimeController(IActualTime _actualTimeRepository)
        {
            actualTimeRepository = _actualTimeRepository;
        }

        [HttpGet("actualtime")]
        [ProducesResponseType(typeof(DateTime), 200)]
        public IActionResult GetActualTime()
        {
            return new JsonResult(actualTimeRepository.GetActualTime());
        }
    }
}