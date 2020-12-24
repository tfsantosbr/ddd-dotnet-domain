using Companies.Domain.Base.ValueObjects;
using System;
using System.Collections.Generic;

namespace Companies.Domain.CompaniesContext.Companies
{
    public class Company
    {
        private readonly List<CompanyActivity> secondaryActivities = new List<CompanyActivity>();

        public Company(Cnpj cnpj, string name, string companyName, Address address, CompanyActivity mainActivity, Guid? id = null)
        {
            Id = id ?? Guid.NewGuid();
            Cnpj = cnpj;
            Name = name;
            CompanyName = companyName;
            Address = address;
            MainActivity = mainActivity;
        }

        public Guid Id { get; private set; }
        public Cnpj Cnpj { get; private set; }
        public string Name { get; private set; }
        public string CompanyName { get; private set; }
        public Address Address { get; private set; }
        public CompanyActivity MainActivity { get; private set; }
        public IReadOnlyCollection<CompanyActivity> SecondaryActivities => secondaryActivities.AsReadOnly();
    }
}
