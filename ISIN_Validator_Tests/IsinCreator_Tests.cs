using System;
using FluentAssertions;
using ISIN_Validator;
using ISIN_Validator.Helpers;
using ISIN_Validator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ISIN_Validator_Tests
{
    [TestClass]
    public class IsinCreatorTests
    {      
        [TestCase("US1234567890")]
        [TestCase("JP9873213131")]
        [TestCase("AU7398213614")]
        public void CreateIsinWithValidInput(string input)
        {
            string country = IsinHelper.ExtractCountry(input);
            string number = IsinHelper.ExtractNumber(input);
            string checkDigit = IsinHelper.ExtractCheckDigit(input);
            var isinCreator = new IsinCreator();

            var isin = isinCreator.CreateIsin(input);

            isin.Country.Should().Be(country);
            isin.Number.Should().Be(number);
            isin.CheckDigit.Should().Be(checkDigit);
        }

        [TestCase("US12345678900")]
        [TestCase("US1234567890123")]
        [TestCase("US123456789")]
        [TestCase("US1234567")]
        public void CreateIsinFailsWhenInputHasIncorrectLength(string input)
        {
            var isinCreator = new IsinCreator();

            Action act = () => isinCreator.CreateIsin(input);

            act.Should().Throw<Exception>()
                .WithMessage("Input has incorrect length");
        }
    }
}
