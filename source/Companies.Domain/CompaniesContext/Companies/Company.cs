using Companies.Domain.Base.ValueObjects;
using Companies.Domain.CompaniesContext.Companies.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Companies.Domain.CompaniesContext.Companies
{
    public class Company
    {
        private readonly List<CompanyActivity> activities = new List<CompanyActivity>();

        public Company(Cnpj cnpj, string name, string companyName, Address address, CompanyActivity mainActivity, Guid? id = default)
        {
            Id = id ?? Guid.NewGuid();
            Cnpj = cnpj;
            Name = name;
            CompanyName = companyName;
            Address = address;

            AddActivity(mainActivity);
        }

        public Guid Id { get; private set; }
        public Cnpj Cnpj { get; private set; }
        public string Name { get; private set; }
        public string CompanyName { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<CompanyActivity> Activities => activities.AsReadOnly();

        public void AddActivity(CompanyActivity activity)
        {
            if (activity.Type == CompanyActivityType.Primary && 
                activities.Any(a => a.Type == CompanyActivityType.Primary))
            {
                throw new InvalidOperationException("Company must have only one primary activity");
            }

            activities.Add(activity);
        }
    }
}
