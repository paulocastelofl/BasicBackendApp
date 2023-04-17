using CasteloChurch.Domain.Entities;
using CasteloChurch.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CasteloChurch.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UserController : Controller
    {
        private IBaseService<User> _baseUserService;
        private IUserService _userService;

        public UserController(
            IBaseService<User> baseUserService,
            IUserService userService
        )
        {
            _baseUserService = baseUserService;
            _userService = userService;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Create([FromBody] User user)
        {
            if (user == null)
                return NotFound();

            try
            {
                return Ok(_userService.Add(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpPut]
        public IActionResult Update([FromBody] User user)
        {
            if (user == null)
                return NotFound();

            try
            {
                return Ok(_baseUserService.Update(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet]
        public ActionResult<IList<User>> Get()
        {
            try
            {
                return _baseUserService.Get().ToList();
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

        }

   

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
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
