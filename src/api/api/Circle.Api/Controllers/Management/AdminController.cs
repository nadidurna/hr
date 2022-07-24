using Circle.Data.Requests.ManagementContracts;
using Circle.Data.Services.Abstractions;

namespace Circle.Api.Controllers.Management
{
    [Route("api/management/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IManagementService service;

        public AdminController(IManagementService service)
        {
            this.service = service;
        }

        [HttpGet("listCmp")]
        public async Task<IActionResult> GetCompanies(CancellationToken cancellationToken)
        {
            var result = await service.GetAll(cancellationToken);
            return Ok(result);
        }
        [HttpPost("addCompany")]
        public async Task<IActionResult> Create([FromBody]NewCompanyRequestDto data, CancellationToken cancellationToken)
        {
            var result = await service.AddCompany(data, cancellationToken);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute]Guid id, CancellationToken cancellationToken)
        {
            var result = await service.DeleteCompany(id, cancellationToken);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateCompanyRequestDto data,CancellationToken cancellationToken)
        {
            var result = await service.UpdateCompany(data, cancellationToken);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}