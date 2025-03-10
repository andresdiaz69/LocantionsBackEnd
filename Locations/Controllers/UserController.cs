namespace Locations.Controllers
{
    using Locations.Domain.IServices;
    using Locations.Domain.Models;
    using Locations.Utils;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            try
            {
                var validateUser = await _userService.ValidateUser(user);

                if (!validateUser.IsSuccess)
                {
                    return BadRequest(new { message = "Error validate user." });
                }

                user.Password = Encrypt.EncryptMD5(user.Password);

                await _userService.SaveUser(user);
                return Ok(new { message = "User registered OK" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] User user)
        {
            try
            {
                await _userService.UpdateUser(user);
                return Ok(new { message = "User updated OK" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
