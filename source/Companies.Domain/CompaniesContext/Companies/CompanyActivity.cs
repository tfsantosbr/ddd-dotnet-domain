using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Domain.CompaniesContext.Companies
{
    public class CompanyActivity
    {
        public CompanyActivity(Guid companyId, string code, string description, Guid? id = null)
        {
            Id = id ?? Guid.NewGuid();
            CompanyId = companyId;
            Code = code;
            Description = description;
        }

        public Guid Id { get; private set; }
        public Guid CompanyId { get; private set; }
        public string Code { get; private set; }
        public string Description { get; private set; }
    }
}
