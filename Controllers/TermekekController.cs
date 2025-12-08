using EtteremApi.Services.IRestaurant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EtteremApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TermekekController : ControllerBase
    {
        private readonly ITermekek _termekek;
        public TermekekController(ITermekek termekek)
        {
            _termekek = termekek;
        }

        [HttpGet]
        public async Task<ActionResult> GetTermek()
        {
            var termek = await _termekek.GetTermek();
            if (termek != null)
            {
                return Ok(termek);
            }
            return BadRequest(termek);

        }
    }
}
