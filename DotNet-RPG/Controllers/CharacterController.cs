using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_RPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class CharacterController : ControllerBase
    {
      private static List<Character> characters = new List<Character> {
        new Character(),
        new Character {Name = "Zenitsu"}
      }; 
      [HttpGet("GetAll")] //The ("GetAll") specifies an additional specific route to the method below in particular.
      public ActionResult<List<Character>> Get() 
      {
        return Ok(characters);
      }
      [HttpGet]
      public ActionResult<Character> GetSingleCharacter()
      {
        return Ok(characters[0]);
      }
    }
}