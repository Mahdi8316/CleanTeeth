using CleanTeeth.Domain.Entities;
using CleanTeeth.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanTeeth.Tests.Domain.Entities
{
    [TestClass]
    public class DentalOfficeTests
    {
        [TestMethod]
        public void Constructor_NullName_Throws()
        {
            Assert.Throws<BusinessRuleException>(() => new DentalOffice(null!));
        }

    }
}
