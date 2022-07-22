using Circle.Data.Requests.Contracts;
using Circle.Data.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Circle.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService service;

        public AuthenticationController(IAuthenticationService service)
        {
            this.service = service;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto data, CancellationToken cancellationToken)
        {
            var result = await service.LoginUser(data, cancellationToken);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}