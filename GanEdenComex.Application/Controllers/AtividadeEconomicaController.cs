using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace GanEdenComex.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AtividadeEconomicaController : Controller
    {

        private IBaseService<AtividadeEconomica> _baseAtvEconomicaService;

        public AtividadeEconomicaController(IBaseService<AtividadeEconomica> baseAtvEconomicaService)
        {
            _baseAtvEconomicaService = baseAtvEconomicaService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] AtividadeEconomica atvEconomica)
        {
            if (atvEconomica == null)
                return NotFound();

            try
            {
                return Ok(_baseAtvEconomicaService.Add(atvEconomica));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet]
        public ActionResult<IList<AtividadeEconomica>> Get(string q)
        {
            try
            {
                return _baseAtvEconomicaService.Get().Where(x => (x.Codigo!+x.Nome!).ToUpper().Contains(q.ToUpper())).ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
