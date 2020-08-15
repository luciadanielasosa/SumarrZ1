using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sumar.Models;

namespace sumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class peoplecontroller : ControllerBase
    {[HttpGet]
    public Person listar () {
            Person person = new Person()
            {
                PersonId = 1,
                Name = "Lucia Sosa"
            };
            return person;

        }
    }
}
