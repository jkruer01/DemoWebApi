using DemoWebApi.Models;
using DemoWebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DemoWebApi.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        public readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public List<Person> Get(PersonRequest personRequest)
        {
            return new List<Person>();
        }
    }
}