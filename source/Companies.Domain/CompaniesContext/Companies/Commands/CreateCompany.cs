using Companies.Domain.Base.Models;
using Companies.Domain.CompaniesContext.Companies.Models;
using MediatR;
using System.Collections.Generic;

namespace Companies.Domain.CompaniesContext.Companies.Commands
{
    public class CreateCompany : IRequest<Company>
    {
        public string Cnpj { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public AddressModel Address { get; set; }
        public CompanyActivityModel MainActivity { get; set; }
        public IEnumerable<CompanyActivityModel> SecondaryActivities { get; set; }
    }
}
