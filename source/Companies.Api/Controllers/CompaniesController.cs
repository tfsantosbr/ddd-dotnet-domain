using Companies.Domain.Base.ValueObjects;
using Companies.Domain.CompaniesContext.Companies;
using Companies.Domain.CompaniesContext.Companies.Commands;
using Companies.Domain.CompaniesContext.Companies.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Companies.Api.Controllers
{
    [ApiController]
    [Route("companies")]
    public class CompaniesController : ControllerBase
    {
        private readonly IMediator mediator;

        public CompaniesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany([FromBody] CreateCompany request)
        {
            if (request is null)
            {
                return BadRequest();
            }

            var company = await mediator.Send(request);

            return Ok(company);
        }
    }
}
