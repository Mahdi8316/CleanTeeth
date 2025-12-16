using System;
using System.Collections.Generic;
using System.Text;

namespace CleanTeeth.Domain.Entities
{
    public  class Patient
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string email { get; private set; } = null!;
    }
}
