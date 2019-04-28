using FluentAssertions;
using ISIN_Validator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ISIN_Validator_Tests
{
    [TestClass]
    public class IsinTests
    {
        [TestCase("US1234567890")]
        [TestCase("JP9873213131")]
        [TestCase("AU7398213614")]
        public void ValidateIsinToStringMethod(string input)
        {
            string expectedValue = input;

            string actualValue = new Isin(input).ToString();

            actualValue.Should().Be(expectedValue);
        }
    }
}
