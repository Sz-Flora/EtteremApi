using EtteremApi.Services.IRestaurant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EtteremApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RendelesController : ControllerBase
    {
        private readonly IRendeles _rendeles;
        public RendelesController(IRendeles rendeles)
        {
            _rendeles = rendeles;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllRendeles()
        {
            var rendeles = await _rendeles.GetAllRendeles();
            if (rendeles != null)
            {
                return Ok(rendeles);
            }
            return BadRequest(rendeles);

        }

        [HttpGet("withcard")]
        public async Task<ActionResult> GetAllRendekesWithCard()
        {
            var rendeles = await _rendeles.GetAllRendekesWithCard();
            if (rendeles != null)
            {
                return Ok(rendeles);
            }
            return BadRequest(rendeles);

        }
    }
}
