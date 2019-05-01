using System;
using FluentAssertions;
using ISIN_Validator.Configuration.Models;
using ISIN_Validator.Helpers.FileParsers;
using ISIN_Validator._Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISIN_Validator_Tests.Configuration_Tests
{
    [TestClass]
    public class ConfigurationFileParserTests
    {
        private JsonFileParser<Config> _jsonFileParser;

        [TestInitialize]
        public void TestInit()
        {
            _jsonFileParser = new JsonFileParser<Config>();
        }

        [TestCleanup]
        public void TestClean()
        {
            _jsonFileParser = null;
        }

        [TestMethod]
        public void FileParserSuccessfullyParsesCorrectConfigurationJson()
        {
            var expectedConfig = Configuration_TestConstants.DataSourcesList;

            var actualConfig = _jsonFileParser.Parse(Configuration_TestConstants.CorrectConfigFileContents).DataSourcesList;

            actualConfig[DataSources.Source.Csv].Should().Be(expectedConfig[DataSources.Source.Csv]);
            actualConfig[DataSources.Source.Database].Should().Be(expectedConfig[DataSources.Source.Database]);
            actualConfig[DataSources.Source.Web].Should().Be(expectedConfig[DataSources.Source.Web]);
        }

        [TestMethod]
        public void FileParserFailsToParseIncorrectConfiguration()
        {
            Action act = () => _jsonFileParser.Parse(Configuration_TestConstants.IncorrectConfigFileContents);

            act.Should().Throw<Exception>();
        }
    }
}
