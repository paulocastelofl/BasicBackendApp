using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GanEdenComex.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class CertificadoDigitalController : Controller
    {
        private IBaseService<CertificadoDigital> _baseUserService;

        public CertificadoDigitalController(IBaseService<CertificadoDigital> baseUserService)
        {
            _baseUserService = baseUserService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CertificadoDigital certificadoDigital)
        {
            if (certificadoDigital == null)
                return NotFound();

            try
            {
                return Ok(_baseUserService.Add(certificadoDigital));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] CertificadoDigital certificadoDigital)
        {
            if (certificadoDigital == null)
                return NotFound();

            try
            {
                return Ok(_baseUserService.Update(certificadoDigital));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet]
        public ActionResult<IList<CertificadoDigital>> Get()
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
        public ActionResult<CertificadoDigital> Get(int id)
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
