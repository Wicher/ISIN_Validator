using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ISIN_Validator.Constants;

namespace ISIN_Validator_Tests
{
    [TestClass]
    public class IsinConstraintsTests
    {
        [TestMethod]
        public void IsinConstraintsValidIsinLengthTest()
        {
            IsinConstraints.ValidIsinLength.Should().Be(12);
        }

        [TestMethod]
        public void IsinConstraintsCountryStartIndexTest()
        {
            IsinConstraints.CountryStartIndex.Should().Be(0);
        }

        [TestMethod]
        public void IsinConstraintsCountryLengthTest()
        {
            IsinConstraints.CountryLength.Should().Be(2);
        }

        [TestMethod]
        public void IsinConstraintsNumberStartIndexTest()
        {
            IsinConstraints.NumberStartIndex.Should().Be(2);
        }

        [TestMethod]
        public void IsinConstraintsNumberLengthTest()
        {
            IsinConstraints.NumberLength.Should().Be(9);
        }

        [TestMethod]
        public void IsinConstraintsCheckDigitStartIndexTest()
        {
            IsinConstraints.CheckDigitStartIndex.Should().Be(11);
        }

        [TestMethod]
        public void IsinConstraintsCheckDigitLengthTest()
        {
            IsinConstraints.CheckDigitLength.Should().Be(1);
        }
    }
}
