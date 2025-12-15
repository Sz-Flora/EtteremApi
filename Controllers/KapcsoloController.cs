using EtteremApi.Models.Dtos;
using EtteremApi.Services.IRestaurant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace EtteremApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KapcsoloController : ControllerBase
    {
        private readonly IKapcsolo kapcsolo;
        public KapcsoloController(IKapcsolo kapcsolo)
        {
            this.kapcsolo = kapcsolo;
        }

        [HttpPost]
        public async Task<ActionResult> PostRelation(AddRelationDto addRelationDto)
        {
            var requestResult = await kapcsolo.PostNewRelation(addRelationDto) as ResultResponseDto;
            var result = requestResult.result as AddRelationDto;
            if(requestResult.result != null)
            {
                return Ok(requestResult);
            }
            else if (requestResult == null)
            {
                return NotFound(requestResult);
            }
            else
            {
                return BadRequest(requestResult);
            }         
        }
    }
}
