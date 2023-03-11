using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GanEdenComex.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ProcessoImportacaoController : Controller
    {
        private IBaseService<ProcessoImportacao> _baseUserService;

        public ProcessoImportacaoController(IBaseService<ProcessoImportacao> baseUserService)
        {
            _baseUserService = baseUserService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProcessoImportacao processoimportacao)
        {
            if (processoimportacao == null)
                return NotFound();

            try
            {
                return Ok(_baseUserService.Add(processoimportacao));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] ProcessoImportacao processoimportacao)
        {
            if (processoimportacao == null)
                return NotFound();

            try
            {
                return Ok(_baseUserService.Update(processoimportacao));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet("GetByEmpresa/{idEmpresa}")]
        public ActionResult<IList<ProcessoImportacao>> GetByEmpresa(int idEmpresa)
        {
            try
            {
                return _baseUserService.Get().Where(x => x.IdEmpresa == idEmpresa).ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet("{id}")]
        public ActionResult<ProcessoImportacao> Get(int id)
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
