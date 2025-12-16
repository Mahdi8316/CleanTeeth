using CleanTeeth.Domain.Exceptions;
using CleanTeeth.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanTeeth.Tests.Domain.ValueObjects
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        public void Constructor_NullEmail_Throws()
        {
            Assert.Throws<BusinessRuleException>(() => new Email(null!));
        }

        [TestMethod]
        public void Constructor_EmailWithoutAt_Throws()
        {
            Assert.Throws<BusinessRuleException>(() => new Email("felipe.com"));
        }

        [TestMethod]
        public void Constructor_ValidEmail_NoExceptions()
        {
            new Email("felipe@example.com");
        }
    }
}
