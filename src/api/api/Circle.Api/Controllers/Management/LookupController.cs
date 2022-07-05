using Circle.Data.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Circle.Api.Controllers.Management
{
    [Route("api/management/[controller]")]
    [ApiController]
    public class LookupController : ControllerBase
    {
        private readonly ILookupService service;

        public LookupController(ILookupService service)
        {
            this.service = service;
        }
        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id,CancellationToken cancellationToken)
        {
            var result = await service.GetById(id, cancellationToken);
            return Ok(result);
        }
    }
}
