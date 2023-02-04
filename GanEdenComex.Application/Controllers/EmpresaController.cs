using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
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

        public EmpresaController(IBaseService<Empresa> baseUserService)
        {
            _baseUserService = baseUserService;
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
                return Ok(_baseUserService.Update(empresa));
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

    }
}
