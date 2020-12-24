using Companies.Domain.CompaniesContext.Companies.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Domain.CompaniesContext.Companies
{
    public class CompanyActivity
    {
        public CompanyActivity(CompanyActivityType type, string code, string description, Guid? id = default)
        {
            Id = id ?? Guid.NewGuid();
            Code = code;
            Description = description;
            Type = type;
        }

        public Guid Id { get; private set; }
        public Guid CompanyId { get; private set; }
        public CompanyActivityType Type { get; private set; }
        public string Code { get; private set; }
        public string Description { get; private set; }
    }
}
