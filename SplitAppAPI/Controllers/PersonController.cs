using Microsoft.AspNetCore.Mvc;
using SplitAppAPI.Models;
using SplitAppAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitAppAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        private IPersonsService _personsService;

        public PersonController(IPersonsService personsService)
        {
            _personsService = personsService;
        }

        [HttpGet("GetAllPersons")]
        public IActionResult GetAllPersons()
        {
            var data = _personsService.GetAllPersons();
            return Ok(data);
        }

        [HttpPost("AddPerson")]
        public IActionResult AddPerson(Persons person)
        {
             _personsService.AddPerson(person);
            return Ok();
        }
    }
}
