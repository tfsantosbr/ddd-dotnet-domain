using Companies.Domain.Base.ValueObjects;
using Companies.Domain.CompaniesContext.Companies.Commands;
using Companies.Domain.CompaniesContext.Companies.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Companies.Domain.CompaniesContext.Companies.Handlers
{
    public class CreateCompanyHandler : IRequestHandler<CreateCompany, Company>
    {
        public Task<Company> Handle(CreateCompany request, CancellationToken cancellationToken)
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

            return Task.FromResult(company);
        }
    }
}
