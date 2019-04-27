using FluentAssertions;
using ISIN_Validator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ISIN_Validator_Tests
{
    [TestClass]
    public class IsinCountryTests
    {
        [TestCase("AF", "AFGHANISTAN")]
        [TestCase("AG", "ANTIGUA AND BARBUDA")]
        [TestCase("BQ", "BONAIRE, SINT EUSTATIUS AND SABA")]
        public void ValidateIsinCountryToStringMethod(string code, string name)
        {
            string expectedValue = $"{code} - {name}";

            string actualValue = new IsinCountry(code, name).ToString();

            actualValue.Should().Be(expectedValue);
        }
    }
}
