using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Domain.Base.ValueObjects
{
    public record Cnpj
    {
        public Cnpj(string value)
        {
            Value = value;
        }

        public string Value { get; private set; }
    }
}
