using GanEdenComex.Domain.DTO;
using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GanEdenComex.Application.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public ActionResult<dynamic> Login([FromBody] AuthLoginDTO model)
        {
            if(model == null)
                return NotFound();

            try
            {
                return _authService.Login(model);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

            
        }
    }
}
