using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public ActionResult GetRecipes()
        {
            string[] recipes = { "Oxtail", "Curry Chicken", "Dumplings", "Kebap", "Köfte" };

            if (recipes.Any())
                return NotFound();
            return Ok(recipes);
        }

        [HttpPost]
        public ActionResult CreateNewRecipes(string recipe)
        {

            return NoContent();
        }

        [HttpDelete]
        public ActionResult DeleteRecipes()
        {
            bool badThingsHappened = false;

            if (badThingsHappened)
                return BadRequest();

            return NoContent();
        }

        [HttpPut]
        public ActionResult UpdateRecipes(string recipe)
        {
            
        }
    }
}
