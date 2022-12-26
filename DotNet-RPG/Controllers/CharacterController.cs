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
      public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> Get() 
      {
        return Ok(await _characterService.GetAllCharacters());
      }
      [HttpGet("{id}")]
      public async Task<ActionResult<ServiceResponse<GetCharacterDTO>>> GetSingleCharacter(int id)
      {
        return Ok(await _characterService.GetCharacterById(id));
      }
      [HttpPost]
      public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> AddCharacter(AddCharacterDTO newCharacter)
      {
        return Ok(await _characterService.AddCharacter(newCharacter));
      }
     [HttpPut]
     public async Task<ActionResult<ServiceResponse<List<UpdateCharacterDTO>>>> UpdateCharacter(UpdateCharacterDTO updatedCharacter)
     {
      var response = await _characterService.UpdateCharacter(updatedCharacter);
      if (response.Data is null) 
      {
        return NotFound(response); 
      } else {
        return Ok(await _characterService.UpdateCharacter(updatedCharacter));
      }
     }
    }
}