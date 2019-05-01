using FluentAssertions;
using ISIN_Validator.Configuration;
using ISIN_Validator.Configuration.Models;
using ISIN_Validator.Helpers.FileParsers;
using ISIN_Validator.Helpers.FileReaders._Interfaces;
using ISIN_Validator._Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ISIN_Validator_Tests.Configuration_Tests
{
    [TestClass]
    public class ConfigurationProviderTests
    {
        [TestMethod]
        public void TestConfigurationProviderWithMockedFileReader()
        {
            var expectedConfig = Configuration_TestConstants.DataSourcesList;

            var mockedFileReader = new Mock<IFileReader>();
            mockedFileReader.Setup(x => x.ReadFile(It.IsAny<string>()))
                .Returns(Configuration_TestConstants.CorrectConfigFileContents);

            var provider = new ConfigurationProvider(mockedFileReader.Object, new JsonFileParser<Config>());

            var actualConfig = provider.Config.DataSourcesList;

            actualConfig[DataSources.Source.Csv].Should().Be(expectedConfig[DataSources.Source.Csv]);
            actualConfig[DataSources.Source.Database].Should().Be(expectedConfig[DataSources.Source.Database]);
            actualConfig[DataSources.Source.Web].Should().Be(expectedConfig[DataSources.Source.Web]);
        }
    }
}
