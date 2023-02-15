using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
using GanEdenComex.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GanEdenComex.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class EmpresaController : Controller
    {
        private IBaseService<Empresa> _baseUserService;
        private IEmpresaService _empresaService;


        public EmpresaController(IBaseService<Empresa> baseUserService,  IEmpresaService empresaService)
        {
            _baseUserService = baseUserService;
            _empresaService = empresaService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Empresa empresa)
        {
            if (empresa == null)
                return NotFound();

            try
            {
                return Ok(_baseUserService.Add(empresa));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] Empresa empresa)
        {
            if (empresa == null)
                return NotFound();

            try
            {
                return Ok(_empresaService.Update(empresa));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet]
        public ActionResult<IList<Empresa>> Get()
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
        public ActionResult<Empresa> Get(int id)
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

        [HttpGet("GetByEmpresa/{id}")]
        public ActionResult<IList<Empresa>> GetByEmpresa(int id)
        {
            try
            {
                return _empresaService.GetByEmpresa(id).ToList();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

        }

        [HttpPut("UpdateStatus/{id}/{status}")]
        public IActionResult UpdateStatus(int id, bool status)
        {

            try
            {
                return Ok(_empresaService.UpdateStatus(id, status));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

    }
}
