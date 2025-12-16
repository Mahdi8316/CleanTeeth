using CleanTeeth.Domain.Exceptions;
using CleanTeeth.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanTeeth.Tests.Domain.ValueObjects
{
    [TestClass]
    public class TimeIntervalTests
    {
        [TestMethod]
        public void Constructor_StartIsAfterEnd_Throws()
        {
            // Arrange
            var start = DateTime.UtcNow;
            var end = start.AddDays(-1);

            // Act & Assert
            Assert.Throws<BusinessRuleException>(() => new TimeInterval(start, end));
        }

        [TestMethod]
        public void Constructor_ValidTimeInterval_NoExceptions()
        {
            new TimeInterval(DateTime.UtcNow, DateTime.UtcNow.AddHours(1));
        }
    }
}
