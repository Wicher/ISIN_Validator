using System;
using System.IO;
using ISIN_Validator.Configuration.Helpers._Interfaces;
using ISIN_Validator.Configuration.Models;
using ISIN_Validator.Configuration._Interfaces;

namespace ISIN_Validator.Configuration
{
    public class ConfigurationProvider : IConfigurationProvider
    {
        public Config Config => InnerConfig ?? (InnerConfig = LoadConfig());

        private const string ConfigurationFilename = "Configuration.json";

        private IConfigurationFileReader ConfigurationFileReader { get; }
        private IConfigurationFileParser ConfigurationFileParser { get; }

        private Config InnerConfig { get; set; }

        public ConfigurationProvider(IConfigurationFileReader configurationFileReader,
            IConfigurationFileParser configurationFileParser)
        {
            ConfigurationFileReader = configurationFileReader;
            ConfigurationFileParser = configurationFileParser;
        }

        private Config LoadConfig()
        {
            string configurationFileFullPath = Path.Combine(Environment.CurrentDirectory, ConfigurationFilename);
            string fileContents = ConfigurationFileReader.ReadConfigurationFile(configurationFileFullPath);
            var config = ConfigurationFileParser.ParseConfiguration(fileContents);
            return config;
        }
    }
}
