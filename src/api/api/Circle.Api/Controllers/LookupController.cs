using Circle.Data.Services.Abstractions;

namespace Circle.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupController : ControllerBase
    {
        private readonly ILookupService service;

        public LookupController(ILookupService service)
        {
            this.service = service;
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetLookups(CancellationToken cancellationToken)
        {
            var result = await service.GetLookups(cancellationToken);
            return Ok(result);
        }
    }
}
