using System;
using System.Collections.Generic;
using System.Text;

namespace CleanTeeth.Domain.Entities
{
    public class DentalOffice
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; } = null! ;
    }
}
