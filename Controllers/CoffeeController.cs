using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("coffee")]
    [ApiController]
    [AllowAnonymous]
    public class CoffeeController : ControllerBase
    {
        private readonly List<Coffee> coffees = new List<Coffee>()
        {
            new Coffee
            {
                Name = "Americano", 
                Price = 1.99
            },
            new Coffee
            {
                Name = "Latte", 
                Price = 2.99
            },
            new Coffee
            {
                Name = "Espresso", 
                Price = 2.99
            },
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(coffees);
        }
    }
}
