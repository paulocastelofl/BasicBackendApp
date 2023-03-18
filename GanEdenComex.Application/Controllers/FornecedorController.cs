using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GanEdenComex.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class FornecedorController : Controller
    {
        private IBaseService<Fornecedor> _baseUserService;

        public FornecedorController(IBaseService<Fornecedor> baseUserService)
        {
            _baseUserService = baseUserService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Fornecedor fornecedor)
        {
            if (fornecedor == null)
                return NotFound();

            try
            {
                return Ok(_baseUserService.Add(fornecedor));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] Fornecedor fornecedor)
        {
            if (fornecedor == null)
                return NotFound();

            try
            {
                return Ok(_baseUserService.Update(fornecedor));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet]
        public ActionResult<IList<Fornecedor>> Get()
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
        public ActionResult<Fornecedor> Get(int id)
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
                return BadRequest(Json(new { ex.HResult }));
            }

        }

        [HttpGet("GetByQ")]
        public ActionResult<IList<Fornecedor>> Get(string q)
        {
            try
            {
                
               return _baseUserService.Get().Where(x => (x.NomeFantasia!).ToUpper().Contains(q.ToUpper())).ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

    }
}
