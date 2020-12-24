using Companies.Domain.Base.ValueObjects;
using Companies.Domain.CompaniesContext.Companies;
using Companies.Domain.CompaniesContext.Companies.Commands;
using Companies.Domain.CompaniesContext.Companies.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Companies.Api.Controllers
{
    [ApiController]
    [Route("companies")]
    public class CompaniesController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateCompany([FromBody] CreateCompany request)
        {
            var company = new Company(
                cnpj: new Cnpj(request.Cnpj),
                name: request.Name,
                companyName: request.CompanyName,
                address: new Address(
                    postalCode: request.Address.PostalCode,
                    street: request.Address.Street,
                    number: request.Address.Number,
                    complement: request.Address.Complement,
                    district: request.Address.District,
                    city: request.Address.City,
                    state: request.Address.State,
                    country: request.Address.Country
                    ),
                mainActivity: new CompanyActivity(
                    type: CompanyActivityType.Primary,
                    code: request.MainActivity.Code,
                    description: request.MainActivity.Description
                    )
                );

            foreach (var secondaryActivity in request.SecondaryActivities)
            {
                company.AddActivity(new CompanyActivity(
                    type: CompanyActivityType.Secondary,
                    code: secondaryActivity.Code,
                    description: secondaryActivity.Description
                    )
                );
            }

            return Ok(company);
        }
    }
}
