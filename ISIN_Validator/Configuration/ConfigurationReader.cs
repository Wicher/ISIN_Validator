using System;
using System.IO;
using ISIN_Validator.Configuration.Models;
using ISIN_Validator.Configuration._Interfaces;
using Newtonsoft.Json;

namespace ISIN_Validator.Configuration
{
    public class ConfigurationReader : IConfigurationReader
    {
        private string ConfigurationFilename { get; }

        public ConfigurationReader(string configurationFilename)
        {
            ConfigurationFilename = configurationFilename;
        }

        public Config LoadConfig()
        {
            string fullPath = Path.Combine(Environment.CurrentDirectory, ConfigurationFilename);
            if (!File.Exists(fullPath)) throw new FileNotFoundException("Configuration file does not exist");
            string jsonContents = File.ReadAllText(fullPath);
            var config = JsonConvert.DeserializeObject<Config>(jsonContents);
            return config;
        }
    }
}
