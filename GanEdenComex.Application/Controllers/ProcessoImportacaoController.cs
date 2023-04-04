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
        private IBaseService<DocumentoImportacao> _baseDocImportacaoService;

        public ProcessoImportacaoController(
            IBaseService<ProcessoImportacao> baseUserService
           ,IBaseService<DocumentoImportacao> baseDocImportacaoService )
        {
            _baseUserService = baseUserService;
            _baseDocImportacaoService = baseDocImportacaoService;
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

        [HttpPost("CreateDoc")]
        public IActionResult CreateDoc([FromBody] DocumentoImportacao documentoImportacao)
        {
            if (documentoImportacao == null)
                return NotFound();

            try
            {
                return Ok(_baseDocImportacaoService.Add(documentoImportacao));
            }

            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("GetDocByProcessoImportacao/{idProcesso}")]
        public ActionResult<IList<DocumentoImportacao>> GetDocByProcessoImportacao(int idProcesso)
        {
            try
            {
                return _baseDocImportacaoService.Get().Where(x => x.IdProcesso == idProcesso).ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }


        [HttpDelete("DeleteDoc/{id}")]
        public IActionResult DeleteDoc(int id)
        {
            if (id == 0)
                return NotFound();

            try
            {
                _baseDocImportacaoService.Delete(id);
                return Json(new { success = true, msg = "successfully deleted" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

    }
}
