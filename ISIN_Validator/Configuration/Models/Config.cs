using System.Collections.Generic;
using ISIN_Validator.CountryProviders._Enums;
using Newtonsoft.Json;

namespace ISIN_Validator.Configuration.Models
{
    public class Config
    {
        [JsonProperty("DataSources")]
        public Dictionary<DataSources.Source, string> DataSourcesList { get; set; }
    }
}
