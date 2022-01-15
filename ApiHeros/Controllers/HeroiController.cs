using ApiHeros.Model;
using ApiHeros.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiHeros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HeroiController : ControllerBase
    {

        private readonly ILogger<HeroiController> _logger;
        private readonly IHeroiService _heroiService;

        public HeroiController(ILogger<HeroiController> logger, IHeroiService heroiService)
        {
            _logger = logger;
            _heroiService = heroiService;
        }

        [HttpGet]
        public IActionResult Get()
        {
           return Ok(_heroiService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            var pathId = _heroiService.GetById(id);

            if(pathId == null) return NotFound();

            return Ok(pathId);    
        }

        [HttpPost]
        public IActionResult Post([FromBody] Heroi heroi)
        {
          if (heroi == null) return BadRequest();

            return Ok(_heroiService.Create(heroi));
        }


        [HttpPut]
        public IActionResult Put([FromBody] Heroi heroi)
        {
            if (heroi == null) return BadRequest();

            return Ok(_heroiService.Update(heroi));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _heroiService.Delete(id);
            
            return NoContent();
        }


    }
}
