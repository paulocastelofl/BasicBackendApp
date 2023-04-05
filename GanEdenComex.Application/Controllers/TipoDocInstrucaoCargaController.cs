using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GanEdenComex.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class TipoDocInstrucaoCargaController : Controller
    {
        private IBaseService<TipoDocInstrucaoCarga> _baseUserService;

        public TipoDocInstrucaoCargaController(IBaseService<TipoDocInstrucaoCarga> baseUserService)
        {
            _baseUserService = baseUserService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] TipoDocInstrucaoCarga tipodocinstrucaocarga)
        {
            if (tipodocinstrucaocarga == null)
                return NotFound();

            try
            {
                return Ok(_baseUserService.Add(tipodocinstrucaocarga));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] TipoDocInstrucaoCarga tipodocinstrucaocarga)
        {
            if (tipodocinstrucaocarga == null)
                return NotFound();

            try
            {
                return Ok(_baseUserService.Update(tipodocinstrucaocarga));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet]
        public ActionResult<IList<TipoDocInstrucaoCarga>> Get()
        {
            try
            {
                return _baseUserService.Get().ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet("{id}")]
        public ActionResult<TipoDocInstrucaoCarga> Get(int id)
        {
            if (id == 0)
                return NotFound();

            try
            {
                return _baseUserService.GetById(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();

            try
            {
                _baseUserService.Delete(id);
                return Json(new { success = true, msg = "successfully deleted" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

    }
}
