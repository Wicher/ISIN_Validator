using ISIN_Validator.Configuration.Models;
using ISIN_Validator.Configuration._Interfaces;

namespace ISIN_Validator.Configuration
{
    public class ConfigurationProvider : IConfigurationProvider
    {
        public Config Config { get; }

        public ConfigurationProvider(IConfigurationReader configurationReader)
        {
            Config = configurationReader.LoadConfig();
        }
    }
}
