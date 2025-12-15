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

        [HttpGet("withfood")]
        public async Task<ActionResult> GetAllRendelesWithFood()
        {
            var rendeles = await _rendeles.GetAllRendelesWithFood();
            if (rendeles != null)
            {
                return Ok(rendeles);
            }
            return BadRequest(rendeles);

        }

        [HttpGet("withcola")]
        public async Task<ActionResult> GetAllRendelesWithCola()
        {
            var rendeles = await _rendeles.GetAllRendelesWithCola();
            if (rendeles != null)
            {
                return Ok(rendeles);
            }
            return BadRequest(rendeles);

        }

        [HttpGet("rendezes")]
        public async Task<ActionResult> GetRendelesTetelLista()
        {
            var result = await _rendeles.GetRendelesTetelLista();

            if (result != null)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("legalabbegyszer")]
        public async Task<ActionResult> GetTermekRendelesLegalabbEgyszer()
        {
            var result = await _rendeles.GetTermekRendelesLegalabbEgyszer();

            if (result != null)
                return Ok(result);

            return BadRequest(result);
        }

    }
}
