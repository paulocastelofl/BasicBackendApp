using CasteloChurch.Domain.DTO;
using CasteloChurch.Domain.Entities;
using CasteloChurch.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CasteloChurch.Application.Controllers
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
        [AllowAnonymous]
        public ActionResult<dynamic> Login([FromBody] AuthLoginDTO model)
        {
            if (model == null)
                return NotFound();


            return _authService.Login(model);



        }
    }
}
