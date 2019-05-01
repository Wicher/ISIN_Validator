using System;
using System.IO;
using ISIN_Validator.Configuration.Models;
using ISIN_Validator.Configuration._Interfaces;
using ISIN_Validator.Helpers.FileParsers._Interfaces;
using ISIN_Validator.Helpers.FileReaders._Interfaces;

namespace ISIN_Validator.Configuration
{
    public class ConfigurationProvider : IConfigurationProvider
    {
        public Config Config => InnerConfig ?? (InnerConfig = LoadConfig());

        private const string ConfigurationFilename = "Configuration.json";

        private IFileReader FileReader { get; }
        private IFileParser<Config> ConfigurationFileParser { get; }

        private Config InnerConfig { get; set; }

        public ConfigurationProvider(IFileReader fileReader,
            IFileParser<Config> configurationFileParser)
        {
            FileReader = fileReader;
            ConfigurationFileParser = configurationFileParser;
        }

        private Config LoadConfig()
        {
            string configurationFileFullPath = Path.Combine(Environment.CurrentDirectory, ConfigurationFilename);
            string fileContents = FileReader.ReadFile(configurationFileFullPath);
            var config = ConfigurationFileParser.Parse(fileContents);
            return config;
        }
    }
}
