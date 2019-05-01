using System;
using System.Collections.Generic;
using FluentAssertions;
using ISIN_Validator.Configuration.Helpers;
using ISIN_Validator._Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISIN_Validator_Tests.Configuration_Tests
{
    [TestClass]
    public class ConfigurationFileParserTests
    {
        private readonly Dictionary<DataSources.Source, string> _testValues = new Dictionary<DataSources.Source, string>
        {
            { DataSources.Source.Csv, "CSV" },
            { DataSources.Source.Database, "DATABASE" },
            { DataSources.Source.Web, "WEB"}
        };

        private const string CorrectConfigFileContents = 
            "{\r\n  " +
            "\"DataSources\": {\r\n    " +
            "\"Csv\": \"CSV\",\r\n    " +
            "\"Database\": \"DATABASE\",\r\n    " +
            "\"Web\": \"WEB\"\r\n  " +
            "}\r\n}";

        private const string IncorrectConfigFileContents =
            "{\r\n  " +
            "\"DataSources\": {\r\n    " +
            "\"Csv\": \"CSV\",\r\n    " +
            "\"Database\": \"DATABASE\",\r\n    " +
            "\"Web\": \"WEB\"\r\n  ";

        private ConfigurationFileParser _configurationFileParser;

        [TestInitialize]
        public void TestInit()
        {
            _configurationFileParser = new ConfigurationFileParser();
        }

        [TestCleanup]
        public void TestClean()
        {
            _configurationFileParser = null;
        }

        [TestMethod]
        public void FileParserSuccessfullyParsesCorrectConfigurationJson()
        {
            var config = _configurationFileParser.ParseConfiguration(CorrectConfigFileContents);

            config.DataSourcesList[DataSources.Source.Csv].Should().Be(_testValues[DataSources.Source.Csv]);
            config.DataSourcesList[DataSources.Source.Database].Should().Be(_testValues[DataSources.Source.Database]);
            config.DataSourcesList[DataSources.Source.Web].Should().Be(_testValues[DataSources.Source.Web]);
        }

        [TestMethod]
        public void FileParserFailsToParseIncorrectConfiguration()
        {
            Action act = () => _configurationFileParser.ParseConfiguration(IncorrectConfigFileContents);

            act.Should().Throw<Exception>();

        }
    }
}
