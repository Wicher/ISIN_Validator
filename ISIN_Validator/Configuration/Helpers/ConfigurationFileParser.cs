using ISIN_Validator.Configuration.Helpers._Interfaces;
using ISIN_Validator.Configuration.Models;
using Newtonsoft.Json;

namespace ISIN_Validator.Configuration.Helpers
{
    public class ConfigurationFileParser : IConfigurationFileParser
    {
        public Config ParseConfiguration(string input)
        {      
            var config = JsonConvert.DeserializeObject<Config>(input);
            return config;
        }
    }
}
