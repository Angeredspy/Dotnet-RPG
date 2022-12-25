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
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

      [HttpGet("GetAll")] //The ("GetAll") specifies an additional specific route to the method below in particular.
      public ActionResult<List<Character>> Get() 
      {
        return Ok(_characterService.GetAllCharacters());
      }
      [HttpGet("{id}")]
      public ActionResult<Character> GetSingleCharacter(int id)
      {
        return Ok(_characterService.GetCharacterById(id));
      }
      [HttpPost]
      public ActionResult<List<Character>> AddCharacter(Character newCharacter)
      {
        return Ok(_characterService.AddCharacter(newCharacter));
      }
    }
}