using Circle.Data.Requests.ManagementContracts;
using Circle.Data.Services.Abstractions;

namespace Circle.Api.Controllers.Management
{
    [Route("api/management/[controller]")]
    [ApiController]
    public class LookupTypeController : ControllerBase
    {
        private readonly ILookupTypeService service;

        public LookupTypeController(ILookupTypeService service)
        {
            this.service = service;
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var result = await service.GetLookupTypeById(id, cancellationToken);
            return Ok(result);
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetAllLookupTypes(CancellationToken cancellationToken)
        {
            var result = await service.GetAll(cancellationToken);
            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] NewLookupTypeRequestDto data, CancellationToken cancellationToken)
        {
            var result = await service.CreateLookupType(data, cancellationToken);
            return Ok(result);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var result = await service.DeleteLookupTypeById(id, cancellationToken);
            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateLookupType([FromBody] UpdateLookupTypeRequestDto data, CancellationToken cancellationToken)
        {
            var result = await service.UpdateLookupType(data, cancellationToken);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}