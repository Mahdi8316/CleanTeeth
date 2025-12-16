using CleanTeeth.Domain.Entities;
using CleanTeeth.Domain.Exceptions;
using CleanTeeth.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanTeeth.Tests.Domain.Entities
{
    [TestClass]
    public class DentistTests
    {
        [TestMethod]
        public void Constructor_NullName_Throws()
        {
            var email = new Email("felipe@example.com");
            Assert.Throws<BusinessRuleException>(() => new Dentist(null!, email));
        }

        [TestMethod]
        public void Constructor_NullEmail_Throws()
        {
            Assert.Throws<BusinessRuleException>(() => new Dentist("Felipe", email: null!));
        }

        [TestMethod]
        public void Constructor_ValidDentist_NoExceptions()
        {
            var email = new Email("felipe@example.com");
            new Dentist("Felipe", email);
        }

    }
}
