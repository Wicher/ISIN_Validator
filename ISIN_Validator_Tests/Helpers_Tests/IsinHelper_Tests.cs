using FluentAssertions;
using ISIN_Validator.Constants;
using ISIN_Validator.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ISIN_Validator_Tests.Helpers_Tests
{
    [TestClass]
    public class IsinHelperTests
    {
        [TestCase("US1234567890")]
        [TestCase("JP9873213131")]
        [TestCase("AU7398213614")]
        public void ValidateCountryExtraction(string input)
        {
            string expectedValue = input.Substring(IsinConstraints.CountryStartIndex, IsinConstraints.CountryLength);

            string actualValue = IsinHelper.ExtractCountry(input);

            actualValue.Should().Be(expectedValue);
        }

        [TestCase("US1234567890")]
        [TestCase("JP9873213131")]
        [TestCase("AU7398213614")]
        public void ValidateNumberExtraction(string input)
        {
            string expectedValue = input.Substring(IsinConstraints.NumberStartIndex, IsinConstraints.NumberLength);

            string actualValue = IsinHelper.ExtractNumber(input);

            actualValue.Should().Be(expectedValue);
        }

        [TestCase("US1234567890")]
        [TestCase("JP9873213131")]
        [TestCase("AU7398213614")]
        public void ValidateCheckDigitExtraction(string input)
        {
            string expectedValue = input.Substring(IsinConstraints.CheckDigitStartIndex, IsinConstraints.CheckDigitLength);

            string actualValue = IsinHelper.ExtractCheckDigit(input);

            actualValue.Should().Be(expectedValue);
        }
    }
}
