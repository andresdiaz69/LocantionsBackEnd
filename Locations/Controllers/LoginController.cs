namespace Locations.Controllers
{
    using Locations.Domain.IServices;
    using Locations.Domain.Models;
    using Locations.Utils;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;
        private readonly IConfiguration _config;

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            try
            {
                user.Password = Encrypt.EncryptMD5(user.Password);
                var userFound = await this._loginService.ValidateUser(user);

                if (userFound == null)
                {
                    return BadRequest(new { message = "User or password incorrect!" });
                }

                string token = JwtConfiigurator.GetToken(userFound.Value, this._config);

                return Ok(new { token = token });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
